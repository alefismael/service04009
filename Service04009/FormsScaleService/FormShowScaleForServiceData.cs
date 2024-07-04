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
    public partial class FormShowScaleForServiceData : Form
    {
        public FormShowScaleForServiceData()
        {
            InitializeComponent();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                DateOnly date = DateOnly.FromDateTime(dateTime.Value);

                // Carregar ServiceScale com todos os serviços associados e suas propriedades relacionadas
                var serviceScale = db.ServiceScales
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.CommanderOfTheGuard)
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Permanences)
                    .Include(sc => sc.Services)
                        .ThenInclude(s => s.Sentinels)
                    .Where(sc => sc.firstDay <= date && sc.lastDay >= date)
                    .FirstOrDefault();

                if (serviceScale != null)
                {
                    infoLabel.Text = $"Escala do dia {serviceScale.firstDay} para o dia {serviceScale.lastDay} que terá {serviceScale.CountDaysService()} serviços.";
                    infoLabel.Visible = true;

                    // Converter serviços para ServiceDT
                    List<ServiceDT> servicesDt = serviceScale.Services
                        .Select(service => new ServiceDT(service))
                        .ToList();

                    table.DataSource = servicesDt;
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
