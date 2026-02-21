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
    public partial class FormDeleteServiceScale : BaseChildForm
    {
        ServiceScale? serviceScaleForm;
        DateOnly? dateForm;

        public FormDeleteServiceScale()
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
            btQuery.Size = new Size(380, 30);
            infoLabel.Location = new Point(30, 130);
            infoLabel.Padding = new Padding(10, 4, 10, 4);
            table.Location = new Point(30, 175);
            table.Size = new Size(1185, 280);
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            btRemover.Location = new Point(300, 475);
            btRemover.Size = new Size(600, 48);
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
                        .ThenInclude(s => s.Commanders)
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

                    // Converter serviços para DataTable dinâmico
                    table.DataSource = ServiceDT.ToDataTable(serviceScale.Services);
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
                        var serviceScaleToDelete = db.ServiceScales
        .Include(sc => sc.Services)
            .ThenInclude(s => s.Commanders)
        .Include(sc => sc.Services)
            .ThenInclude(s => s.Permanences)
        .Include(sc => sc.Services)
            .ThenInclude(s => s.Sentinels)
        .Where(sc => sc.firstDay <= dateForm && sc.lastDay >= dateForm)
        .FirstOrDefault();

                        if (serviceScaleToDelete != null)
                        {
                            serviceScaleToDelete.subtractNumberOfServicesFromAllShootersOnTheScale();
                            db.Services.RemoveRange(serviceScaleToDelete.Services);
                            db.ServiceScales.Remove(serviceScaleToDelete);
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
                        else
                        {
                            MessageBox.Show("Operação cancelada por erro ao excluir dados, a escala de serviço não foi encontrada.");
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
