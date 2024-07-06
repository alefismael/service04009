using DocumentFormat.OpenXml.Drawing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Service04009.FormsScaleService
{
    public partial class FormDeleteServiceScale : Form
    {
        ServiceScale? serviceScaleForm;
        DateOnly? dateForm;

        public FormDeleteServiceScale()
        {
            InitializeComponent();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                DateOnly date = DateOnly.FromDateTime(dateTime.Value);
                dateForm = date;

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
                    serviceScaleForm = serviceScale;
                    infoLabel.Text = $"Escala do dia {serviceScale.firstDay} até o dia {serviceScale.lastDay} que terá {serviceScale.CountDaysService()} serviços foi encontrada.";
                    infoLabel.Visible = true;

                    // Converter serviços para ServiceDT
                    List<ServiceDT> servicesDt = serviceScale.Services
                        .Select(service => new ServiceDT(service))
                        .ToList();
                    table.DataSource = servicesDt;
                    table.Visible = true;
                    btRemover.Visible = true;
                    infoLabel.BackColor = Color.Lime;
                }
                else
                {
                    MessageBox.Show($"Não foi encontrado uma escala de serviço que tenha um serviço na data {date}");
                    infoLabel.Visible = false;
                    table.Visible = false;
                    btRemover.Visible = false;
                    serviceScaleForm = null;
                    infoLabel.BackColor = Color.Red;
                    dateForm = null;
                }
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (serviceScaleForm == null)
            {
                MessageBox.Show("Não há escala de serviço disponível para remoção.");
            }
            else if (dateForm == null)
            {
                MessageBox.Show("Não há uma data de serviço disponível para procurar a escala de serviço para remoção.");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Deseja continuar com a remoção da escala de serviço do dia {serviceScaleForm.firstDay} até o dia {serviceScaleForm.lastDay} que terá {serviceScaleForm.CountDaysService()}?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    using (var db = new ServiceContext())
                    {
                        var serviceScalesToDelete = db.ServiceScales
        .Include(sc => sc.Services)
            .ThenInclude(s => s.CommanderOfTheGuard)
        .Include(sc => sc.Services)
            .ThenInclude(s => s.Permanences)
        .Include(sc => sc.Services)
            .ThenInclude(s => s.Sentinels)
        .Where(sc => sc.firstDay <= dateForm && sc.lastDay >= dateForm)
        .ToList();

                        // Remover todos os Services associados a cada ServiceScale
                        foreach (var serviceScale in serviceScalesToDelete)
                        {
                            db.Services.RemoveRange(serviceScale.Services);
                        }

                        // Remover os ServiceScales
                        db.ServiceScales.RemoveRange(serviceScalesToDelete);

                        // Salvar as alterações no banco de dados
                        db.SaveChanges();
                        MessageBox.Show($"O serviço do dia {serviceScaleForm.firstDay} até o dia {serviceScaleForm.lastDay} que terá {serviceScaleForm.CountDaysService()} foi removido do sistema.");
                        infoLabel.Text = $"O serviço do dia {serviceScaleForm.firstDay} até o dia {serviceScaleForm.lastDay} que terá {serviceScaleForm.CountDaysService()} foi removido do sistema.";
                        btRemover.Visible = false;
                        infoLabel.Text = $"O serviço do dia {serviceScaleForm.firstDay} até o dia {serviceScaleForm.lastDay} que terá {serviceScaleForm.CountDaysService()} foi removido do sistema.";
                        table.Visible = false;
                        btRemover.Visible = false;
                        serviceScaleForm = null;
                        infoLabel.BackColor = Color.Lime;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Operação cancelada.");
                    infoLabel.Text = "Sem atirador informado para remover os dados";
                    table.DataSource = null;
                    infoLabel.Visible = false;
                    table.Visible = false;
                    btRemover.Visible = false;
                    serviceScaleForm = null;
                    dateForm = null;
                }
            }
        }
    }
}
