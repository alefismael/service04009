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
    public partial class FormShowServiceForData : Form
    {
        public FormShowServiceForData()
        {
            InitializeComponent();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                DateOnly date = DateOnly.FromDateTime(dateTime.Value);

                // Carregar ServiceScale com todos os serviços associados e suas propriedades relacionadas
                var service = db.Services
                    .Include(s => s.CommanderOfTheGuard)
                    .Include(s => s.Permanences)
                    .Include(s => s.Sentinels)
                    .Where(s => s.Date == date)
                    .FirstOrDefault();

                if (service != null)
                {
                    infoLabel.Text = $"Serviço do dia {service.Date}.";
                    infoLabel.Visible = true;

                    // Converter serviços para ServiceDT
                    List<ServiceDT> servicesDt = new List<ServiceDT>() {new ServiceDT(service) };

                    table.DataSource = servicesDt;
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
