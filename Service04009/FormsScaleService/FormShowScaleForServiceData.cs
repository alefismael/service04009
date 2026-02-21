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
    public partial class FormShowScaleForServiceData : BaseChildForm
    {
        public FormShowScaleForServiceData()
        {
            InitializeComponent();
            ArrangeLayout();
        }

        private void ArrangeLayout()
        {
            label1.Location = new Point(20, 10);
            label16.Location = new Point(30, 60);
            label16.Padding = Padding.Empty;
            dateTime.Location = new Point(30, 88);
            dateTime.Size = new Size(300, 26);
            btQuery.Location = new Point(350, 85);
            btQuery.Size = new Size(400, 30);
            infoLabel.Location = new Point(30, 130);
            infoLabel.Padding = new Padding(10, 4, 10, 4);
            table.Location = new Point(30, 170);
            table.Size = new Size(1185, 410);
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                DateOnly date = DateOnly.FromDateTime(dateTime.Value);

                // Carregar ServiceScale com todos os serviços associados e suas propriedades relacionadas
                var serviceScale = db.ServiceScales
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Commanders)
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Permanences)
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Sentinels)
                    .Where(sc => sc.firstDay <= date && sc.lastDay >= date)
                    .FirstOrDefault();

                if (serviceScale != null)
                {
                    infoLabel.Text = $"Escala do dia {serviceScale.firstDay} até o dia {serviceScale.lastDay} que terá {serviceScale.CountDaysService()} serviços.";
                    infoLabel.Visible = true;

                    // Converter serviços para DataTable dinâmico
                    table.DataSource = ServiceDT.ToDataTable(serviceScale.Services);
                    table.Visible = true;
                }
                else
                {
                    MessageBox.Show($"Não foi encontrado uma escala de serviço que tenha um serviço na data {date}");
                    infoLabel.Visible = false;
                    table.Visible = false;
                }
            }
        }
    }
}
