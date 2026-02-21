using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service04009.FormsScaleService
{
    public partial class FormCreateScaleService : BaseChildForm
    {
        private ServiceConfig? _config;

        public FormCreateScaleService()
        {
            InitializeComponent();
            ArrangeLayout();
            LoadConfig();
        }

        private void ArrangeLayout()
        {
            label1.Location = new Point(20, 10);
            label16.Location = new Point(30, 65);
            label16.Padding = Padding.Empty;
            dateTimePicker1.Location = new Point(30, 92);
            dateTimePicker1.Size = new Size(200, 26);
            label2.Location = new Point(260, 65);
            label2.Padding = Padding.Empty;
            dateTimePicker2.Location = new Point(260, 92);
            dateTimePicker2.Size = new Size(200, 26);
            btQuery.Location = new Point(30, 135);
            btQuery.Size = new Size(500, 32);
            scaleInfo.Location = new Point(30, 180);
            labelInfoCfc.Location = new Point(30, 210);
            notCfcNecessary.Location = new Point(700, 210);
            labelInfoNotCfc.Location = new Point(30, 240);
            cfcNecessary.Location = new Point(700, 240);
            btLimpar.Location = new Point(900, 210);
            btLimpar.Size = new Size(200, 28);
            btCadastrar.Location = new Point(250, 290);
            btCadastrar.Size = new Size(750, 48);
        }

        private void LoadConfig()
        {
            using var db = new ServiceContext();
            _config = db.ServiceConfigs.FirstOrDefault();
            if (_config == null)
            {
                _config = new ServiceConfig();
                db.ServiceConfigs.Add(_config);
                db.SaveChanges();
            }
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            DateOnly dateFirst = DateOnly.FromDateTime(dateTimePicker1.Value);
            DateOnly dateEnd = DateOnly.FromDateTime(dateTimePicker2.Value);
            int numServices = dateEnd.DayNumber - dateFirst.DayNumber;

            if (numServices < 0)
            {
                MessageBox.Show("Por favor informe uma data de início do serviço menor do que a data de fim da escala de serviço");
                btLimpar.Visible = false;
                scaleInfo.Visible = false;
                labelInfoCfc.Visible = false;
                labelInfoNotCfc.Visible = false;
                cfcNecessary.Visible = false;
                notCfcNecessary.Visible = false;
                btCadastrar.Visible = false;
            }
            else
            {
                cfcNecessary.Text = ServiceScale.GetNecessaryCfcForScale(dateFirst, dateEnd, _config).ToString();
                notCfcNecessary.Text = ServiceScale.GetNecessaryShootersNotSfcForScale(dateFirst, dateEnd, _config).ToString();
                scaleInfo.Text = $"Escala do dia {dateFirst} para o dia {dateEnd} que terá {numServices + 1} serviços.";
                btLimpar.Visible = true;
                scaleInfo.Visible = true;
                labelInfoCfc.Visible = true;
                labelInfoNotCfc.Visible = true;
                cfcNecessary.Visible = true;
                notCfcNecessary.Visible = true;
                btCadastrar.Visible = true;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            btLimpar.Visible = false;
            scaleInfo.Visible = false;
            labelInfoCfc.Visible = false;
            labelInfoNotCfc.Visible = false;
            cfcNecessary.Visible = false;
            notCfcNecessary.Visible = false;
            btCadastrar.Visible = false;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DateOnly dateFirst = DateOnly.FromDateTime(dateTimePicker1.Value);
            DateOnly dateEnd = DateOnly.FromDateTime(dateTimePicker2.Value);
            int numServices = (dateEnd.DayNumber - dateFirst.DayNumber); // Inclui ambos os dias

            if (numServices < 0)
            {
                MessageBox.Show("Por favor informe uma data de início do serviço menor do que a data de fim da escala de serviço");
                return;
            }

            using (var db = new ServiceContext())
            {
                // Obter todos os atiradores e serviços uma vez
                var shooters = db.Shooters.ToList();
                var services = db.Services.ToList();

                // Calcular necessidades de atiradores
                int cfcNecessary = ServiceScale.GetNecessaryCfcForScale(dateFirst, dateEnd, _config);
                int notCfcNecessary = ServiceScale.GetNecessaryShootersNotSfcForScale(dateFirst, dateEnd, _config);

                // Verificar ambiguidade na criação da escala
                bool ambiguidade = false;
                for (int i = 0; i <= numServices; i++)
                {
                    var serviceScale = db.ServiceScales
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Commanders)
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Permanences)
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Sentinels)
                    .Where(sc => sc.firstDay <= dateFirst.AddDays(i) && sc.lastDay >= dateFirst.AddDays(i))
                    .FirstOrDefault();

                    if (serviceScale != null)
                    {
                        ambiguidade = true;
                        break;
                    }
                }

                // Verificar se há atiradores suficientes
                if (notCfcNecessary > shooters.Count(s => !s.isCfc))
                {
                    MessageBox.Show("Não há atiradores que não são cfc suficientes para criar a escala de serviço;");
                }
                else if (cfcNecessary > shooters.Count(s => s.isCfc))
                {
                    MessageBox.Show("Não há atiradores que são cfc suficientes para criar a escala de serviço.");
                }
                else if (ambiguidade)
                {
                    MessageBox.Show("A escala de serviço não pode ser criada porque algum dos dias escolhidos para a criação da escala já foi usado em outro serviço.");
                }
                else
                {
                    var scale = new ServiceScale(dateFirst, dateEnd, _config);
                    scale.DefineScale(shooters);
                    db.ServiceScales.Add(scale);
                    db.SaveChanges();
                    MessageBox.Show($"A Escala do dia {dateFirst} para o dia {dateEnd} que terá {numServices + 1} serviços foi criada com sucesso.");
                }
            }
        }
    }
}
