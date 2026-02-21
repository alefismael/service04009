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
    public partial class FormRelatorioAtiradores : BaseChildForm
    {
        private DataTable? _currentData;
        private bool _isIndividualMode;

        public FormRelatorioAtiradores()
        {
            InitializeComponent();
            LoadOrdenacao();
            LoadFormatos();
            LoadAtiradores();
        }

        private void LoadOrdenacao()
        {
            cmbOrdenacao.Items.Clear();
            cmbOrdenacao.Items.Add("Número do Atirador");
            cmbOrdenacao.Items.Add("Nome de Guerra");
            cmbOrdenacao.Items.Add("Serviços Tirados (maior → menor)");
            cmbOrdenacao.Items.Add("Serviços Tirados (menor → maior)");
            cmbOrdenacao.SelectedIndex = 0;
        }

        private void LoadFormatos()
        {
            cmbFormato.Items.Clear();
            cmbFormato.Items.Add("Word (.docx)");
            cmbFormato.Items.Add("PDF (.pdf)");
            cmbFormato.Items.Add("Excel (.xlsx)");
            cmbFormato.SelectedIndex = 0;
        }

        private void LoadAtiradores()
        {
            using var db = new ServiceContext();
            var shooters = db.Shooters.OrderBy(s => s.numAtr).ToList();
            cmbAtiradores.Items.Clear();
            foreach (var s in shooters)
                cmbAtiradores.Items.Add(new ShooterItem(s.numAtr, s.warName));
            if (cmbAtiradores.Items.Count > 0)
                cmbAtiradores.SelectedIndex = 0;
        }

        private void rbTodos_CheckedChanged(object? sender, EventArgs e)
        {
            _isIndividualMode = rbIndividual.Checked;
            lblAtirador.Visible = _isIndividualMode;
            cmbAtiradores.Visible = _isIndividualMode;
            lblOrdenar.Visible = !_isIndividualMode;
            cmbOrdenacao.Visible = !_isIndividualMode;
            // Reset
            lblShooterInfo.Visible = false;
            table.Visible = false;
            btnExportar.Visible = false;
            cmbFormato.Visible = false;
            lblFormato.Visible = false;
        }

        private void cmbOrdenacao_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (!_isIndividualMode && _currentData != null)
                ApplySort();
        }

        private void btnGerar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (_isIndividualMode)
                    GenerateIndividualReport();
                else
                    GenerateAllReport();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = $"Erro: {ex.Message}";
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateAllReport()
        {
            using var db = new ServiceContext();
            var shooters = db.Shooters.OrderBy(s => s.numAtr).ToList();

            var allServices = db.Services
                .Include(s => s.Commanders)
                .Include(s => s.Permanences)
                .Include(s => s.Sentinels)
                .OrderByDescending(s => s.Date)
                .ToList();

            var dt = new DataTable();
            dt.Columns.Add("Nº Atr", typeof(int));
            dt.Columns.Add("Nome de Guerra", typeof(string));
            dt.Columns.Add("CFC", typeof(string));
            dt.Columns.Add("Serviços Tirados", typeof(int));
            dt.Columns.Add("Serviços Extras", typeof(int));
            dt.Columns.Add("Último Serviço", typeof(string));
            dt.Columns.Add("Função (Último)", typeof(string));

            foreach (var shooter in shooters)
            {
                var lastService = allServices.FirstOrDefault(s =>
                    s.Commanders.Any(c => c.numAtr == shooter.numAtr) ||
                    s.Permanences.Any(p => p.numAtr == shooter.numAtr) ||
                    s.Sentinels.Any(sen => sen.numAtr == shooter.numAtr));

                string lastDate = lastService?.Date.ToString("dd/MM/yyyy") ?? "—";
                string lastFunc = "—";
                if (lastService != null)
                {
                    if (lastService.Commanders.Any(c => c.numAtr == shooter.numAtr)) lastFunc = "Comandante";
                    else if (lastService.Permanences.Any(p => p.numAtr == shooter.numAtr)) lastFunc = "Permanência";
                    else if (lastService.Sentinels.Any(s => s.numAtr == shooter.numAtr)) lastFunc = "Sentinela";
                }

                var row = dt.NewRow();
                row["Nº Atr"] = shooter.numAtr;
                row["Nome de Guerra"] = shooter.warName;
                row["CFC"] = shooter.isCfc ? "Sim" : "Não";
                row["Serviços Tirados"] = shooter.numOfService;
                row["Serviços Extras"] = shooter.numServiceExtra;
                row["Último Serviço"] = lastDate;
                row["Função (Último)"] = lastFunc;
                dt.Rows.Add(row);
            }

            _currentData = dt;
            ApplySort();
            lblShooterInfo.Visible = false;
            table.Visible = true;
            cmbFormato.Visible = true;
            lblFormato.Visible = true;
            btnExportar.Visible = true;
            lblStatus.ForeColor = AppTheme.AccentColor;
            lblStatus.Text = $"{dt.Rows.Count} atiradores encontrados.";
        }

        private void GenerateIndividualReport()
        {
            if (cmbAtiradores.SelectedItem is not ShooterItem selected)
            {
                MessageBox.Show("Selecione um atirador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new ServiceContext();
            var shooter = db.Shooters.FirstOrDefault(s => s.numAtr == selected.NumAtr);
            if (shooter == null)
            {
                MessageBox.Show("Atirador não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var services = db.Services
                .Include(s => s.Commanders)
                .Include(s => s.Permanences)
                .Include(s => s.Sentinels)
                .Where(s => s.Commanders.Any(c => c.numAtr == shooter.numAtr) ||
                            s.Permanences.Any(p => p.numAtr == shooter.numAtr) ||
                            s.Sentinels.Any(sen => sen.numAtr == shooter.numAtr))
                .OrderBy(s => s.Date)
                .ToList();

            // Mostrar info do atirador
            lblShooterInfo.Visible = true;
            lblShooterInfo.Text = $"Atirador Nº {shooter.numAtr}  —  {shooter.warName}  —  CFC: {(shooter.isCfc ? "Sim" : "Não")}  —  Serviços: {shooter.numOfService}  —  Extras: {shooter.numServiceExtra}";

            var dt = new DataTable();
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Dia", typeof(string));
            dt.Columns.Add("Função", typeof(string));

            foreach (var service in services)
            {
                string funcao = "—";
                if (service.Commanders.Any(c => c.numAtr == shooter.numAtr)) funcao = "Comandante";
                else if (service.Permanences.Any(p => p.numAtr == shooter.numAtr)) funcao = "Permanência";
                else if (service.Sentinels.Any(s => s.numAtr == shooter.numAtr)) funcao = "Sentinela";

                var row = dt.NewRow();
                row["Data"] = service.Date.ToString("dd/MM/yyyy");
                row["Dia"] = GetDiaSemana(service.Date.DayOfWeek);
                row["Função"] = funcao;
                dt.Rows.Add(row);
            }

            _currentData = dt;
            table.DataSource = dt;
            table.Visible = true;
            cmbFormato.Visible = true;
            lblFormato.Visible = true;
            btnExportar.Visible = true;
            lblStatus.ForeColor = AppTheme.AccentColor;
            lblStatus.Text = $"{services.Count} serviço(s) encontrado(s).";
        }

        private void ApplySort()
        {
            if (_currentData == null) return;
            string sort = cmbOrdenacao.SelectedIndex switch
            {
                1 => "[Nome de Guerra] ASC",
                2 => "[Serviços Tirados] DESC",
                3 => "[Serviços Tirados] ASC",
                _ => "[Nº Atr] ASC"
            };
            _currentData.DefaultView.Sort = sort;
            table.DataSource = _currentData.DefaultView;
        }

        private void btnExportar_Click(object? sender, EventArgs e)
        {
            if (_currentData == null || _currentData.Rows.Count == 0)
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
                saveDialog.FileName = $"Relatorio_Atiradores_{DateTime.Now:yyyyMMdd_HHmmss}.{ext}";

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                switch (formatIdx)
                {
                    case 1: ExportPdf(saveDialog.FileName); break;
                    case 2: ExportExcel(saveDialog.FileName); break;
                    default: ExportWord(saveDialog.FileName); break;
                }

                lblStatus.ForeColor = AppTheme.AccentColor;
                lblStatus.Text = $"Exportado: {Path.GetFileName(saveDialog.FileName)}";
                MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = $"Erro: {ex.Message}";
                MessageBox.Show($"Erro ao exportar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Exportação Word ──────────────────────────────────────────────

        private void ExportWord(string filePath)
        {
            using var doc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document);
            var mainPart = doc.AddMainDocumentPart();
            mainPart.Document = new Wp.Document();
            var body = mainPart.Document.AppendChild(new Wp.Body());

            body.Append(WordHelper.Paragraph("Relatório de Atiradores", bold: true, fontSize: "36",
                align: Wp.JustificationValues.Center));
            body.Append(WordHelper.Paragraph($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm}",
                fontSize: "18", align: Wp.JustificationValues.Center, color: "888888"));
            body.Append(WordHelper.Paragraph(""));

            if (_isIndividualMode)
            {
                body.Append(WordHelper.Paragraph(lblShooterInfo.Text, bold: true, fontSize: "22"));
                body.Append(WordHelper.Paragraph(""));

                var tbl = WordHelper.CreateTable();
                var headerRow = new Wp.TableRow();
                foreach (var h in new[] { "Data", "Dia", "Função" })
                    headerRow.Append(WordHelper.Cell(h, bold: true));
                tbl.Append(headerRow);

                foreach (System.Data.DataRow r in _currentData!.Rows)
                {
                    var row = new Wp.TableRow();
                    row.Append(WordHelper.Cell(r["Data"].ToString()!));
                    row.Append(WordHelper.Cell(r["Dia"].ToString()!));
                    row.Append(WordHelper.Cell(r["Função"].ToString()!));
                    tbl.Append(row);
                }
                body.Append(tbl);
            }
            else
            {
                body.Append(WordHelper.Paragraph($"Ordenação: {cmbOrdenacao.SelectedItem}", fontSize: "18"));
                body.Append(WordHelper.Paragraph(""));

                var view = _currentData!.DefaultView;
                var tbl = WordHelper.CreateTable();
                var headerRow = new Wp.TableRow();
                foreach (var h in new[] { "Nº Atr", "Nome de Guerra", "CFC", "Serviços", "Extras", "Último Serviço", "Função (Último)" })
                    headerRow.Append(WordHelper.Cell(h, bold: true));
                tbl.Append(headerRow);

                for (int i = 0; i < view.Count; i++)
                {
                    var r = view[i];
                    var row = new Wp.TableRow();
                    row.Append(WordHelper.Cell(r["Nº Atr"].ToString()!));
                    row.Append(WordHelper.Cell(r["Nome de Guerra"].ToString()!));
                    row.Append(WordHelper.Cell(r["CFC"].ToString()!));
                    row.Append(WordHelper.Cell(r["Serviços Tirados"].ToString()!));
                    row.Append(WordHelper.Cell(r["Serviços Extras"].ToString()!));
                    row.Append(WordHelper.Cell(r["Último Serviço"].ToString()!));
                    row.Append(WordHelper.Cell(r["Função (Último)"].ToString()!));
                    tbl.Append(row);
                }
                body.Append(tbl);
            }

            body.Append(WordHelper.Paragraph(""));
            body.Append(WordHelper.Paragraph("Relatório gerado automaticamente pelo Service04009.",
                fontSize: "14", align: Wp.JustificationValues.Center, color: "888888"));
            body.Append(WordHelper.LandscapeA4());
            mainPart.Document.Save();
        }

        // ── Exportação PDF ───────────────────────────────────────────────

        private void ExportPdf(string filePath)
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
                        col.Item().AlignCenter().Text("Relatório de Atiradores").Bold().FontSize(18);
                        col.Item().AlignCenter().Text($"Gerado em: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor(Colors.Grey.Medium);
                        if (_isIndividualMode)
                            col.Item().Text(lblShooterInfo.Text).Bold().FontSize(11);
                        else
                            col.Item().Text($"Ordenação: {cmbOrdenacao.SelectedItem}").FontSize(9);
                        col.Item().PaddingBottom(10);
                    });

                    page.Content().Table(tbl =>
                    {
                        if (_isIndividualMode)
                        {
                            tbl.ColumnsDefinition(c =>
                            {
                                c.RelativeColumn(1.5f);
                                c.RelativeColumn(1.5f);
                                c.RelativeColumn(2);
                            });

                            tbl.Header(header =>
                            {
                                foreach (var h in new[] { "Data", "Dia", "Função" })
                                    header.Cell().Border(0.5f).Background(Colors.Grey.Lighten3).Padding(4).Text(h).Bold().FontSize(9);
                            });

                            foreach (System.Data.DataRow r in _currentData!.Rows)
                            {
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Data"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Dia"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Função"].ToString()!).FontSize(9);
                            }
                        }
                        else
                        {
                            var view = _currentData!.DefaultView;
                            tbl.ColumnsDefinition(c =>
                            {
                                c.RelativeColumn(0.7f);
                                c.RelativeColumn(2);
                                c.RelativeColumn(0.6f);
                                c.RelativeColumn(1);
                                c.RelativeColumn(1);
                                c.RelativeColumn(1.2f);
                                c.RelativeColumn(1.3f);
                            });

                            string[] headers = { "Nº Atr", "Nome de Guerra", "CFC", "Serviços", "Extras", "Último Serviço", "Função (Último)" };
                            tbl.Header(header =>
                            {
                                foreach (var h in headers)
                                    header.Cell().Border(0.5f).Background(Colors.Grey.Lighten3).Padding(4).Text(h).Bold().FontSize(9);
                            });

                            for (int i = 0; i < view.Count; i++)
                            {
                                var r = view[i];
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Nº Atr"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Nome de Guerra"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["CFC"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Serviços Tirados"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Serviços Extras"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Último Serviço"].ToString()!).FontSize(9);
                                tbl.Cell().Border(0.5f).Padding(3).Text(r["Função (Último)"].ToString()!).FontSize(9);
                            }
                        }
                    });

                    page.Footer().AlignCenter().Text("Relatório gerado automaticamente pelo Service04009.").FontSize(7).FontColor(Colors.Grey.Medium);
                });
            });

            document.GeneratePdf(filePath);
        }

        // ── Exportação Excel ─────────────────────────────────────────────

        private void ExportExcel(string filePath)
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Atiradores");

            ws.Cell(1, 1).Value = "Relatório de Atiradores";
            ws.Cell(1, 1).Style.Font.Bold = true;
            ws.Cell(1, 1).Style.Font.FontSize = 14;

            if (_isIndividualMode)
            {
                ws.Range(1, 1, 1, 3).Merge();
                ws.Cell(2, 1).Value = lblShooterInfo.Text;
                ws.Range(2, 1, 2, 3).Merge();

                string[] headers = { "Data", "Dia", "Função" };
                for (int c = 0; c < headers.Length; c++)
                {
                    ws.Cell(4, c + 1).Value = headers[c];
                    ws.Cell(4, c + 1).Style.Font.Bold = true;
                    ws.Cell(4, c + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                }

                int rowIdx = 5;
                foreach (System.Data.DataRow r in _currentData!.Rows)
                {
                    ws.Cell(rowIdx, 1).Value = r["Data"].ToString();
                    ws.Cell(rowIdx, 2).Value = r["Dia"].ToString();
                    ws.Cell(rowIdx, 3).Value = r["Função"].ToString();
                    rowIdx++;
                }
            }
            else
            {
                ws.Range(1, 1, 1, 7).Merge();
                ws.Cell(2, 1).Value = $"Ordenação: {cmbOrdenacao.SelectedItem}";
                ws.Range(2, 1, 2, 7).Merge();

                string[] headers = { "Nº Atr", "Nome de Guerra", "CFC", "Serviços Tirados", "Serviços Extras", "Último Serviço", "Função (Último)" };
                for (int c = 0; c < headers.Length; c++)
                {
                    ws.Cell(4, c + 1).Value = headers[c];
                    ws.Cell(4, c + 1).Style.Font.Bold = true;
                    ws.Cell(4, c + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                }

                var view = _currentData!.DefaultView;
                for (int i = 0; i < view.Count; i++)
                {
                    var r = view[i];
                    ws.Cell(5 + i, 1).Value = Convert.ToInt32(r["Nº Atr"]);
                    ws.Cell(5 + i, 2).Value = r["Nome de Guerra"].ToString();
                    ws.Cell(5 + i, 3).Value = r["CFC"].ToString();
                    ws.Cell(5 + i, 4).Value = Convert.ToInt32(r["Serviços Tirados"]);
                    ws.Cell(5 + i, 5).Value = Convert.ToInt32(r["Serviços Extras"]);
                    ws.Cell(5 + i, 6).Value = r["Último Serviço"].ToString();
                    ws.Cell(5 + i, 7).Value = r["Função (Último)"].ToString();
                }
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(filePath);
        }

        // ── Utilitários ──────────────────────────────────────────────────

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

        private class ShooterItem
        {
            public int NumAtr { get; }
            public string WarName { get; }

            public ShooterItem(int numAtr, string warName)
            {
                NumAtr = numAtr;
                WarName = warName;
            }

            public override string ToString() => $"Nº {NumAtr} — {WarName}";
        }
    }
}
