using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Service04009.FormsAtirador
{
    public partial class FormImportExportAtiradores : BaseChildForm
    {
        private static readonly string[] DayHeaders =
        {
            "Dom Manhã", "Dom Noite",
            "Seg Manhã", "Seg Noite",
            "Ter Manhã", "Ter Noite",
            "Qua Manhã", "Qua Noite",
            "Qui Manhã", "Qui Noite",
            "Sex Manhã", "Sex Noite",
            "Sáb Manhã", "Sáb Noite"
        };

        public FormImportExportAtiradores()
        {
            InitializeComponent();
        }

        // ── Gerar Template ───────────────────────────────────────────────

        private void linkTemplate_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            saveDialog.FileName = "Template_Atiradores.xlsx";

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Atiradores");

                // Cabeçalhos
                string[] headers = BuildHeaders();
                for (int c = 0; c < headers.Length; c++)
                {
                    ws.Cell(1, c + 1).Value = headers[c];
                    ws.Cell(1, c + 1).Style.Font.Bold = true;
                    ws.Cell(1, c + 1).Style.Fill.BackgroundColor = XLColor.LightGreen;
                }

                // Linha de exemplo
                ws.Cell(2, 1).Value = 1;                       // Nº Atirador
                ws.Cell(2, 2).Value = "Silva";                 // Nome de Guerra
                ws.Cell(2, 3).Value = "Sim";                   // CFC
                ws.Cell(2, 4).Value = 0;                       // Serviços Tirados
                ws.Cell(2, 5).Value = 0;                       // Serviços Extras
                // Disponibilidade: todos "Sim" por padrão
                for (int c = 0; c < 14; c++)
                    ws.Cell(2, 6 + c).Value = "Sim";

                // Instruções na aba extra
                var wsInst = wb.Worksheets.Add("Instruções");
                wsInst.Cell(1, 1).Value = "Como preencher o template:";
                wsInst.Cell(1, 1).Style.Font.Bold = true;
                wsInst.Cell(2, 1).Value = "• Nº Atirador: Número inteiro positivo e único.";
                wsInst.Cell(3, 1).Value = "• Nome de Guerra: Apenas letras e espaços.";
                wsInst.Cell(4, 1).Value = "• CFC: \"Sim\" ou \"Não\".";
                wsInst.Cell(5, 1).Value = "• Serviços Tirados / Serviços Extras: Número inteiro ≥ 0.";
                wsInst.Cell(6, 1).Value = "• Disponibilidade (14 colunas): \"Sim\" = disponível, \"Não\" = indisponível.";
                wsInst.Cell(7, 1).Value = "• A linha 1 é o cabeçalho — NÃO altere.";
                wsInst.Cell(8, 1).Value = "• Preencha a partir da linha 2. A linha de exemplo pode ser sobrescrita.";
                wsInst.Columns().AdjustToContents();

                ws.Columns().AdjustToContents();
                wb.SaveAs(saveDialog.FileName);

                lblResultado.Visible = true;
                lblResultado.ForeColor = AppTheme.AccentColor;
                lblResultado.Text = $"Template salvo em: {saveDialog.FileName}";
                MessageBox.Show("Template gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblResultado.Visible = true;
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = $"Erro: {ex.Message}";
            }
        }

        // ── Importar Planilha ────────────────────────────────────────────

        private void linkImportar_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using var openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            openDialog.Title = "Selecione a planilha de atiradores";

            if (openDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var resultPath = ImportFromExcel(openDialog.FileName);

                lblResultado.Visible = true;
                lblResultado.ForeColor = AppTheme.AccentColor;
                lblResultado.Text = $"Importação concluída. Resultado salvo em: {resultPath}";
                MessageBox.Show($"Importação concluída!\nPlanilha de resultado salva em:\n{resultPath}",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblResultado.Visible = true;
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = $"Erro na importação: {ex.Message}";
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ImportFromExcel(string filePath)
        {
            using var wb = new XLWorkbook(filePath);
            var ws = wb.Worksheet(1); // primeira aba

            int lastRow = ws.LastRowUsed()?.RowNumber() ?? 1;
            if (lastRow < 2)
                throw new InvalidOperationException("A planilha não contém dados (apenas cabeçalho ou vazia).");

            string[] expectedHeaders = BuildHeaders();
            int colCount = expectedHeaders.Length;

            // Adicionar coluna "Resultado" se não existir
            int resultCol = colCount + 1;
            ws.Cell(1, resultCol).Value = "Resultado";
            ws.Cell(1, resultCol).Style.Font.Bold = true;
            ws.Cell(1, resultCol).Style.Fill.BackgroundColor = XLColor.LightYellow;

            // Preview DataTable
            var dt = new DataTable();
            for (int c = 0; c < colCount; c++)
                dt.Columns.Add(expectedHeaders[c], typeof(string));
            dt.Columns.Add("Resultado", typeof(string));

            int imported = 0;
            int errors = 0;

            using var db = new ServiceContext();
            var existingNumbers = db.Shooters.Select(s => s.numAtr).ToHashSet();
            var existingNames = db.Shooters.Select(s => s.warName.ToLower()).ToHashSet();
            var newNumbers = new HashSet<int>();
            var newNames = new HashSet<string>();

            for (int row = 2; row <= lastRow; row++)
            {
                var errorList = new List<string>();
                var rowValues = new string[colCount];

                for (int c = 0; c < colCount; c++)
                    rowValues[c] = ws.Cell(row, c + 1).GetString().Trim();

                // Validar Nº Atirador
                if (!int.TryParse(rowValues[0], out int numAtr) || numAtr <= 0)
                    errorList.Add("Nº Atirador inválido (deve ser inteiro > 0)");
                else if (existingNumbers.Contains(numAtr) || newNumbers.Contains(numAtr))
                    errorList.Add($"Nº Atirador {numAtr} já existe");

                // Validar Nome de Guerra
                string warName = rowValues[1];
                if (string.IsNullOrWhiteSpace(warName))
                    errorList.Add("Nome de Guerra é obrigatório");
                else if (!Regex.IsMatch(warName, @"^[\p{L}\s.]+$"))
                    errorList.Add("Nome de Guerra deve conter apenas letras e espaços");
                else if (existingNames.Contains(warName.ToLower()) || newNames.Contains(warName.ToLower()))
                    errorList.Add($"Nome '{warName}' já existe");

                // Validar CFC
                string cfcStr = rowValues[2].ToLower();
                bool isCfc = false;
                if (cfcStr == "sim" || cfcStr == "s" || cfcStr == "true" || cfcStr == "1")
                    isCfc = true;
                else if (cfcStr != "não" && cfcStr != "nao" && cfcStr != "n" && cfcStr != "false" && cfcStr != "0" && cfcStr != "")
                    errorList.Add("CFC deve ser 'Sim' ou 'Não'");

                // Validar Serviços Tirados
                int numService = 0;
                if (!string.IsNullOrWhiteSpace(rowValues[3]))
                {
                    if (!int.TryParse(rowValues[3], out numService) || numService < 0)
                        errorList.Add("Serviços Tirados deve ser inteiro ≥ 0");
                }

                // Validar Serviços Extras
                int numExtra = 0;
                if (!string.IsNullOrWhiteSpace(rowValues[4]))
                {
                    if (!int.TryParse(rowValues[4], out numExtra) || numExtra < 0)
                        errorList.Add("Serviços Extras deve ser inteiro ≥ 0");
                }

                // Validar Disponibilidade (14 colunas)
                bool[] availability = new bool[14];
                for (int i = 0; i < 14; i++)
                {
                    string val = (i + 5 < colCount) ? rowValues[i + 5].ToLower() : "";
                    if (val == "sim" || val == "s" || val == "true" || val == "1" || val == "")
                        availability[i] = true;
                    else if (val == "não" || val == "nao" || val == "n" || val == "false" || val == "0")
                        availability[i] = false;
                    else
                        errorList.Add($"Disponibilidade '{DayHeaders[i]}' inválida (use 'Sim' ou 'Não')");
                }

                string resultado;
                if (errorList.Count == 0)
                {
                    // Cadastrar atirador
                    var shooter = new Shooter(numAtr, warName.Trim(), isCfc, numService,
                        availability[0], availability[1],   // Dom
                        availability[2], availability[3],   // Seg
                        availability[4], availability[5],   // Ter
                        availability[6], availability[7],   // Qua
                        availability[8], availability[9],   // Qui
                        availability[10], availability[11], // Sex
                        availability[12], availability[13]  // Sáb
                    );
                    // Serviços extras — set via reflection ou public setter workaround
                    // numServiceExtra is set via constructor only with basic ctor;
                    // Use the full constructor that includes numService, then add extras manually
                    if (numExtra > 0)
                    {
                        for (int x = 0; x < numExtra; x++)
                            shooter.AddServiceExtra();
                    }

                    db.Shooters.Add(shooter);
                    newNumbers.Add(numAtr);
                    newNames.Add(warName.ToLower());
                    imported++;
                    resultado = "✅ Importado";
                }
                else
                {
                    errors++;
                    resultado = "❌ " + string.Join("; ", errorList);
                }

                ws.Cell(row, resultCol).Value = resultado;

                // Add to preview
                var dtRow = dt.NewRow();
                for (int c = 0; c < colCount; c++)
                    dtRow[c] = rowValues[c];
                dtRow["Resultado"] = resultado;
                dt.Rows.Add(dtRow);
            }

            db.SaveChanges();

            // Colorir coluna de resultado
            for (int row = 2; row <= lastRow; row++)
            {
                var cell = ws.Cell(row, resultCol);
                if (cell.GetString().StartsWith("✅"))
                    cell.Style.Font.FontColor = XLColor.DarkGreen;
                else
                    cell.Style.Font.FontColor = XLColor.Red;
            }

            ws.Columns().AdjustToContents();

            // Salvar resultado
            string dir = Path.GetDirectoryName(filePath)!;
            string name = Path.GetFileNameWithoutExtension(filePath);
            string resultPath = Path.Combine(dir, $"{name}_resultado.xlsx");
            wb.SaveAs(resultPath);

            // Show preview
            table.DataSource = dt;
            table.Visible = true;

            // Colorir coluna Resultado no DataGridView
            table.CellFormatting += (s, ev) =>
            {
                var resultadoCol = table.Columns["Resultado"];
                if (resultadoCol != null && ev.ColumnIndex == resultadoCol.Index && ev.Value != null)
                {
                    string val = ev.Value?.ToString() ?? "";
                    if (val.StartsWith("✅"))
                        ev.CellStyle!.ForeColor = Color.DarkGreen;
                    else if (val.StartsWith("❌"))
                        ev.CellStyle!.ForeColor = Color.Red;
                }
            };

            lblResultado.Text = $"Importação: {imported} cadastrado(s), {errors} erro(s). Resultado salvo em: {Path.GetFileName(resultPath)}";
            return resultPath;
        }

        // ── Utilitários ──────────────────────────────────────────────────

        private static string[] BuildHeaders()
        {
            var headers = new List<string>
            {
                "Nº Atirador",
                "Nome de Guerra",
                "CFC",
                "Serviços Tirados",
                "Serviços Extras"
            };
            headers.AddRange(DayHeaders);
            return headers.ToArray();
        }
    }
}
