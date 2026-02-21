using System;
using System.Windows.Forms;

namespace Service04009.FormsScaleService
{
    public partial class FormOpcoes : BaseChildForm
    {
        // 7 dias da semana, na ordem Domingo → Sábado (DayOfWeek enum order)
        private static readonly (string Label, DayOfWeek Day)[] _days =
        {
            ("Domingo",  DayOfWeek.Sunday),
            ("Segunda",  DayOfWeek.Monday),
            ("Terça",    DayOfWeek.Tuesday),
            ("Quarta",   DayOfWeek.Wednesday),
            ("Quinta",   DayOfWeek.Thursday),
            ("Sexta",    DayOfWeek.Friday),
            ("Sábado",   DayOfWeek.Saturday),
        };

        public FormOpcoes()
        {
            InitializeComponent();
            LoadConfigIntoGrid();
        }

        private ServiceConfig LoadOrCreateConfig()
        {
            using var db = new ServiceContext();
            var config = db.ServiceConfigs.FirstOrDefault();
            if (config == null)
            {
                config = new ServiceConfig();
                db.ServiceConfigs.Add(config);
                db.SaveChanges();
            }
            return config;
        }

        private void LoadConfigIntoGrid()
        {
            dgvConfig.Rows.Clear();
            var cfg = LoadOrCreateConfig();

            foreach (var (label, day) in _days)
            {
                dgvConfig.Rows.Add(
                    label,
                    cfg.GetPermanences(day),
                    cfg.GetSentinels(day),
                    cfg.GetCommanders(day),
                    cfg.MustCommanderBeCfc(day)
                );
            }
        }

        private void btnSalvar_Click(object? sender, EventArgs e)
        {
            try
            {
                // Valida todas as 7 linhas
                for (int row = 0; row < 7; row++)
                {
                    for (int col = 1; col <= 3; col++)
                    {
                        var val = dgvConfig.Rows[row].Cells[col].Value?.ToString();
                        if (!int.TryParse(val, out int num) || num < 0)
                        {
                            MessageBox.Show(
                                $"Valor inválido na linha '{_days[row].Label}', coluna '{dgvConfig.Columns[col].HeaderText}'.\nDeve ser um número inteiro ≥ 0.",
                                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                using var db = new ServiceContext();
                var cfg = db.ServiceConfigs.FirstOrDefault();
                if (cfg == null)
                {
                    cfg = new ServiceConfig();
                    db.ServiceConfigs.Add(cfg);
                }

                for (int row = 0; row < 7; row++)
                {
                    var day = _days[row].Day;
                    cfg.SetPermanences(day, int.Parse(dgvConfig.Rows[row].Cells[1].Value!.ToString()!));
                    cfg.SetSentinels(day, int.Parse(dgvConfig.Rows[row].Cells[2].Value!.ToString()!));
                    cfg.SetCommanders(day, int.Parse(dgvConfig.Rows[row].Cells[3].Value!.ToString()!));
                    cfg.SetCommanderMustBeCfc(day, Convert.ToBoolean(dgvConfig.Rows[row].Cells[4].Value));
                }

                db.SaveChanges();
                MessageBox.Show("Configuração salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetar_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja resetar a configuração para os valores padrão?",
                "Confirmar Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using var db = new ServiceContext();
                var cfg = db.ServiceConfigs.FirstOrDefault();
                if (cfg != null)
                    db.ServiceConfigs.Remove(cfg);

                db.ServiceConfigs.Add(new ServiceConfig());
                db.SaveChanges();
                LoadConfigIntoGrid();
                MessageBox.Show("Configuração resetada para o padrão.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
