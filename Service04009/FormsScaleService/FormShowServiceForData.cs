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
    public partial class FormShowServiceForData : BaseChildForm
    {
        public FormShowServiceForData()
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
            btQuery.Size = new Size(350, 30);
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
                var service = db.Services
                    .Include(s => s.Commanders)
                    .Include(s => s.Permanences)
                    .Include(s => s.Sentinels)
                    .Where(s => s.Date == date)
                    .FirstOrDefault();

                if (service != null)
                {
                    infoLabel.Text = $"Serviço do dia {service.Date}.";
                    infoLabel.Visible = true;

                    // Converter serviço para DataTable dinâmico
                    table.DataSource = ServiceDT.ToDataTable(service);
                    table.Visible = true;
                }
                else
                {
                    MessageBox.Show($"Não foi encontrar um serviço que tenha a data {date}");
                    infoLabel.Visible = false;
                    table.Visible = false;
                }
            }
        }
    }
}
