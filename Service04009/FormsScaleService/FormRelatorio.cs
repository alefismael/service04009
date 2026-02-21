using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using Wp = DocumentFormat.OpenXml.Wordprocessing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Service04009.FormsScaleService
{
    public partial class FormRelatorio : BaseChildForm
    {
        private List<ServiceScale>? _currentEscalas;

        public FormRelatorio()
        {
            InitializeComponent();
            LoadEscalas();
            LoadFormatos();
        }

        private void LoadFormatos()
        {
            cmbFormato.Items.Clear();
            cmbFormato.Items.Add("Word (.docx)");
            cmbFormato.Items.Add("PDF (.pdf)");
            cmbFormato.Items.Add("Excel (.xlsx)");
            cmbFormato.SelectedIndex = 0;
        }

        private void LoadEscalas()
        {
            using var db = new ServiceContext();
            var escalas = db.ServiceScales
                .Include(sc => sc.Services)
                .OrderByDescending(sc => sc.firstDay)
                .ToList();

            cmbEscalas.Items.Clear();
            foreach (var esc in escalas)
            {
                cmbEscalas.Items.Add(new EscalaItem(esc.id, esc.firstDay, esc.lastDay));
            }
            if (cmbEscalas.Items.Count > 0)
                cmbEscalas.SelectedIndex = 0;
        }

        private void rbPeriodo_CheckedChanged(object? sender, EventArgs e)
        {
            panelPeriodo.Visible = rbPeriodo.Checked;
            panelEscala.Visible = !rbPeriodo.Checked;
        }

        private void rbEscalaCompleta_CheckedChanged(object? sender, EventArgs e)
        {
            panelPeriodo.Visible = !rbEscalaCompleta.Checked;
            panelEscala.Visible = rbEscalaCompleta.Checked;
        }

        private List<ServiceScale>? LoadEscalasFromSelection()
        {
            using var db = new ServiceContext();

            if (rbPeriodo.Checked)
            {
                var inicio = DateOnly.FromDateTime(dtpInicio.Value);
                var fim = DateOnly.FromDateTime(dtpFim.Value);
                if (fim < inicio)
                {
                    MessageBox.Show("A data de fim deve ser maior ou igual à data de início.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                var escalas = db.ServiceScales
                    .Include(sc => sc.Services).ThenInclude(s => s.Commanders)
                    .Include(sc => sc.Services).ThenInclude(s => s.Permanences)
                    .Include(sc => sc.Services).ThenInclude(s => s.Sentinels)
                    .Where(sc => sc.firstDay <= fim && sc.lastDay >= inicio)
                    .OrderBy(sc => sc.firstDay)
                    .ToList();

                if (escalas.Count == 0)
                {
                    MessageBox.Show("Nenhuma escala encontrada para o período informado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
                return escalas;
            }
            else
            {
                if (cmbEscalas.SelectedItem is not EscalaItem selected)
                {
                    MessageBox.Show("Selecione uma escala.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                var escala = db.ServiceScales
                    .Include(sc => sc.Services).ThenInclude(s => s.Commanders)
                    .Include(sc => sc.Services).ThenInclude(s => s.Permanences)
                    .Include(sc => sc.Services).ThenInclude(s => s.Sentinels)
                    .FirstOrDefault(sc => sc.id == selected.Id);

                if (escala == null)
                {
                    MessageBox.Show("Escala não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return new List<ServiceScale> { escala };
            }
        }

        private void btnGerar_Click(object? sender, EventArgs e)
        {
            try
            {
                _currentEscalas = LoadEscalasFromSelection();
                if (_currentEscalas == null) return;

                // Montar DataTable para pré-visualização
                var dt = BuildPreviewTable(_currentEscalas);
                table.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                table.DataSource = dt;
                table.Visible = true;
                cmbFormato.Visible = true;
                lblFormato.Visible = true;
                btnExportar.Visible = true;

                int totalServicos = _currentEscalas.Sum(esc => esc.Services.Count);
                lblStatus.ForeColor = AppTheme.AccentColor;
                lblStatus.Text = $"{totalServicos} serviço(s) encontrado(s) em {_currentEscalas.Count} escala(s).";
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = $"Erro: {ex.Message}";
            }
        }

        private System.Data.DataTable BuildPreviewTable(List<ServiceScale> escalas)
        {
            var dt = new System.Data.DataTable();
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Dia", typeof(string));
            dt.Columns.Add("Permanências", typeof(string));
            dt.Columns.Add("Sentinelas", typeof(string));
            dt.Columns.Add("Comandante(s)", typeof(string));

            foreach (var escala in escalas)
            {
                foreach (var service in escala.Services.OrderBy(s => s.Date))
                {
                    var row = dt.NewRow();
                    row["Data"] = service.Date.ToString("dd/MM/yyyy");
                    row["Dia"] = GetDiaSemana(service.Date.DayOfWeek);
                    row["Permanências"] = service.Permanences.Count > 0
                        ? string.Join("\n", service.Permanences.OrderBy(p => p.numAtr).Select(p => $"{p.warName} ({p.numAtr})"))
                        : "—";
                    row["Sentinelas"] = service.Sentinels.Count > 0
                        ? string.Join("\n", service.Sentinels.OrderBy(s => s.numAtr).Select(s => $"{s.warName} ({s.numAtr})"))
                        : "—";
                    row["Comandante(s)"] = service.Commanders.Count > 0
                        ? string.Join("\n", service.Commanders.OrderBy(c => c.numAtr).Select(c => $"{c.warName} ({c.numAtr})"))
                        : "—";
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        private void btnExportar_Click(object? sender, EventArgs e)
        {
            if (_currentEscalas == null || _currentEscalas.Count == 0)
            {
                MessageBox.Show("Gere o relatório primeiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int formatIdx = cmbFormato.SelectedIndex;
                string filter, ext;
                switch (formatIdx)
                {
                    case 1: filter = "PDF (*.pdf)|*.pdf"; ext = "pdf"; break;
                    case 2: filter = "Excel (*.xlsx)|*.xlsx"; ext = "xlsx"; break;
                    default: filter = "Documento Word (*.docx)|*.docx"; ext = "docx"; break;
                }

                using var saveDialog = new SaveFileDialog();
                saveDialog.Filter = filter;
                saveDialog.FileName = $"Relatorio_Escala_{DateTime.Now:yyyyMMdd_HHmmss}.{ext}";

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;

                switch (formatIdx)
                {
                    case 1: GeneratePdfReport(_currentEscalas, saveDialog.FileName); break;
                    case 2: GenerateExcelReport(_currentEscalas, saveDialog.FileName); break;
                    default: GenerateWordReport(_currentEscalas, saveDialog.FileName); break;
                }

                lblStatus.ForeColor = AppTheme.AccentColor;
                lblStatus.Text = $"Relatório exportado: {Path.GetFileName(saveDialog.FileName)}";
                MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = $"Erro: {ex.Message}";
                MessageBox.Show($"Erro ao exportar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateWordReport(List<ServiceScale> escalas, string filePath)
        {
            using var doc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document);
            var mainPart = doc.AddMainDocumentPart();
            mainPart.Document = new Wp.Document();
            var body = mainPart.Document.AppendChild(new Wp.Body());

            body.Append(WordHelper.Paragraph("Relatório de Escala de Serviço", bold: true, fontSize: "36",
                align: Wp.JustificationValues.Center));
            body.Append(WordHelper.Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm}",
                fontSize: "18", align: Wp.JustificationValues.Center, color: "888888"));
            body.Append(WordHelper.Paragraph(""));

            foreach (var escala in escalas)
            {
                body.Append(WordHelper.Paragraph($"Escala: {escala.firstDay:dd/MM/yyyy} a {escala.lastDay:dd/MM/yyyy}",
                    bold: true, fontSize: "26"));
                body.Append(WordHelper.Paragraph($"Total de dias: {escala.CountDaysService()}", fontSize: "18"));

                int totalEsc = escala.Services.Sum(s => s.Commanders.Count + s.Permanences.Count + s.Sentinels.Count);
                body.Append(WordHelper.Paragraph($"Resumo: {totalEsc} escalações totais | {escala.Services.Count} dias de serviço",
                    bold: true, fontSize: "18"));
                body.Append(WordHelper.Paragraph(""));

                var tbl = WordHelper.CreateTable();

                // Cabeçalho
                var headerRow = new Wp.TableRow();
                foreach (var h in new[] { "Data", "Dia", "Permanências", "Sentinelas", "Comandante(s)" })
                    headerRow.Append(WordHelper.Cell(h, bold: true));
                tbl.Append(headerRow);

                // Linhas — cada atirador em parágrafo separado na célula
                foreach (var service in escala.Services.OrderBy(s => s.Date))
                {
                    var row = new Wp.TableRow();
                    row.Append(WordHelper.Cell(service.Date.ToString("dd/MM/yyyy")));
                    row.Append(WordHelper.Cell(GetDiaSemana(service.Date.DayOfWeek)));
                    row.Append(WordHelper.MultiLineCell(
                        service.Permanences.OrderBy(p => p.numAtr).Select(p => $"{p.warName} ({p.numAtr})")));
                    row.Append(WordHelper.MultiLineCell(
                        service.Sentinels.OrderBy(s => s.numAtr).Select(s => $"{s.warName} ({s.numAtr})")));
                    row.Append(WordHelper.MultiLineCell(
                        service.Commanders.OrderBy(c => c.numAtr).Select(c => $"{c.warName} ({c.numAtr})")));
                    tbl.Append(row);
                }

                body.Append(tbl);
                body.Append(WordHelper.Paragraph(""));
            }

            body.Append(WordHelper.Paragraph("Relatório gerado automaticamente pelo Service04009.",
                fontSize: "14", align: Wp.JustificationValues.Center, color: "888888"));
            body.Append(WordHelper.LandscapeA4());
            mainPart.Document.Save();
        }

        private void GeneratePdfReport(List<ServiceScale> escalas, string filePath)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Header().Column(col =>
                    {
                        col.Item().AlignCenter().Text("Relatório de Escala de Serviço").Bold().FontSize(18);
                        col.Item().AlignCenter().Text($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor(Colors.Grey.Medium);
                        col.Item().PaddingBottom(10);
                    });

                    page.Content().Column(col =>
                    {
                        foreach (var escala in escalas)
                        {
                            col.Item().Text($"Escala: {escala.firstDay:dd/MM/yyyy} a {escala.lastDay:dd/MM/yyyy}").Bold().FontSize(13);
                            col.Item().Text($"Total de dias: {escala.CountDaysService()}").FontSize(9);

                            int totalEsc = 0;
                            foreach (var svc in escala.Services)
                                totalEsc += svc.Commanders.Count + svc.Permanences.Count + svc.Sentinels.Count;
                            col.Item().Text($"Resumo: {totalEsc} escalações totais | {escala.Services.Count} dias de serviço").Bold().FontSize(9);
                            col.Item().PaddingVertical(5);

                            col.Item().Table(tbl =>
                            {
                                tbl.ColumnsDefinition(c =>
                                {
                                    c.RelativeColumn(1.2f); // Data
                                    c.RelativeColumn(1);    // Dia
                                    c.RelativeColumn(2);    // Permanências
                                    c.RelativeColumn(2);    // Sentinelas
                                    c.RelativeColumn(2);    // Comandantes
                                });

                                // Header
                                tbl.Header(header =>
                                {
                                    foreach (var h in new[] { "Data", "Dia", "Permanências", "Sentinelas", "Comandante(s)" })
                                        header.Cell().Border(0.5f).Background(Colors.Grey.Lighten3).Padding(4).Text(h).Bold().FontSize(9);
                                });

                                foreach (var service in escala.Services.OrderBy(s => s.Date))
                                {
                                    tbl.Cell().Border(0.5f).Padding(4).Text(service.Date.ToString("dd/MM/yyyy")).FontSize(9);
                                    tbl.Cell().Border(0.5f).Padding(4).Text(GetDiaSemana(service.Date.DayOfWeek)).FontSize(9);

                                    tbl.Cell().Border(0.5f).Padding(4).Column(c =>
                                    {
                                        foreach (var p in service.Permanences.OrderBy(x => x.numAtr))
                                            c.Item().Text($"{p.warName} ({p.numAtr})").FontSize(9);
                                        if (service.Permanences.Count == 0) c.Item().Text("—").FontSize(9);
                                    });

                                    tbl.Cell().Border(0.5f).Padding(4).Column(c =>
                                    {
                                        foreach (var s in service.Sentinels.OrderBy(x => x.numAtr))
                                            c.Item().Text($"{s.warName} ({s.numAtr})").FontSize(9);
                                        if (service.Sentinels.Count == 0) c.Item().Text("—").FontSize(9);
                                    });

                                    tbl.Cell().Border(0.5f).Padding(4).Column(c =>
                                    {
                                        foreach (var cmd in service.Commanders.OrderBy(x => x.numAtr))
                                            c.Item().Text($"{cmd.warName} ({cmd.numAtr})").FontSize(9);
                                        if (service.Commanders.Count == 0) c.Item().Text("—").FontSize(9);
                                    });
                                }
                            });

                            col.Item().PaddingVertical(10);
                        }
                    });

                    page.Footer().AlignCenter().Text("Relatório gerado automaticamente pelo Service04009.").FontSize(7).FontColor(Colors.Grey.Medium);
                });
            });

            document.GeneratePdf(filePath);
        }

        private void GenerateExcelReport(List<ServiceScale> escalas, string filePath)
        {
            using var wb = new XLWorkbook();

            foreach (var escala in escalas)
            {
                string sheetName = $"{escala.firstDay:ddMMyyyy}";
                if (sheetName.Length > 31) sheetName = sheetName[..31];
                var ws = wb.Worksheets.Add(sheetName);

                ws.Cell(1, 1).Value = $"Escala: {escala.firstDay:dd/MM/yyyy} a {escala.lastDay:dd/MM/yyyy}";
                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 1).Style.Font.FontSize = 14;
                ws.Range(1, 1, 1, 5).Merge();

                int totalEsc = 0;
                foreach (var svc in escala.Services)
                    totalEsc += svc.Commanders.Count + svc.Permanences.Count + svc.Sentinels.Count;

                ws.Cell(2, 1).Value = $"Total de dias: {escala.CountDaysService()} | {totalEsc} escalações totais";
                ws.Range(2, 1, 2, 5).Merge();

                // Header row
                string[] headers = { "Data", "Dia", "Permanências", "Sentinelas", "Comandante(s)" };
                for (int c = 0; c < headers.Length; c++)
                {
                    ws.Cell(4, c + 1).Value = headers[c];
                    ws.Cell(4, c + 1).Style.Font.Bold = true;
                    ws.Cell(4, c + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                }

                int rowIdx = 5;
                foreach (var service in escala.Services.OrderBy(s => s.Date))
                {
                    ws.Cell(rowIdx, 1).Value = service.Date.ToString("dd/MM/yyyy");
                    ws.Cell(rowIdx, 2).Value = GetDiaSemana(service.Date.DayOfWeek);
                    ws.Cell(rowIdx, 3).Value = service.Permanences.Count > 0
                        ? string.Join("\n", service.Permanences.OrderBy(p => p.numAtr).Select(p => $"{p.warName} ({p.numAtr})"))
                        : "—";
                    ws.Cell(rowIdx, 4).Value = service.Sentinels.Count > 0
                        ? string.Join("\n", service.Sentinels.OrderBy(s => s.numAtr).Select(s => $"{s.warName} ({s.numAtr})"))
                        : "—";
                    ws.Cell(rowIdx, 5).Value = service.Commanders.Count > 0
                        ? string.Join("\n", service.Commanders.OrderBy(c => c.numAtr).Select(c => $"{c.warName} ({c.numAtr})"))
                        : "—";

                    // Habilitar wrap text para quebra de linha
                    ws.Cell(rowIdx, 3).Style.Alignment.WrapText = true;
                    ws.Cell(rowIdx, 4).Style.Alignment.WrapText = true;
                    ws.Cell(rowIdx, 5).Style.Alignment.WrapText = true;
                    rowIdx++;
                }

                ws.Columns().AdjustToContents();
            }

            wb.SaveAs(filePath);
        }

        private static string GetDiaSemana(DayOfWeek day) => day switch
        {
            DayOfWeek.Sunday => "Domingo",
            DayOfWeek.Monday => "Segunda",
            DayOfWeek.Tuesday => "Terça",
            DayOfWeek.Wednesday => "Quarta",
            DayOfWeek.Thursday => "Quinta",
            DayOfWeek.Friday => "Sexta",
            DayOfWeek.Saturday => "Sábado",
            _ => day.ToString()
        };

        // Classe auxiliar para exibição no ComboBox
        private class EscalaItem
        {
            public int Id { get; }
            public DateOnly FirstDay { get; }
            public DateOnly LastDay { get; }

            public EscalaItem(int id, DateOnly firstDay, DateOnly lastDay)
            {
                Id = id;
                FirstDay = firstDay;
                LastDay = lastDay;
            }

            public override string ToString() => $"Escala {FirstDay:dd/MM/yyyy} a {LastDay:dd/MM/yyyy}";
        }
    }
}
