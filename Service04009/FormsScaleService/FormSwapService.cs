using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class FormSwapService : Form
    {
        Shooter? shooter1Form;
        Shooter? shooter2Form;
        Service? service1Form;
        Service? service2Form;


        public FormSwapService()
        {
            InitializeComponent();
        }

        private void numAtrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btQueryShooters_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                if (numAtrBox1.Text == "")
                {
                    numAtrBox1.Text = "0";
                }
                if (numAtrBox2.Text == "")
                {
                    numAtrBox2.Text = "0";
                }
                Shooter? shooter1 = db.Shooters.Where(s => s.numAtr == int.Parse(numAtrBox1.Text)).FirstOrDefault();
                Shooter? shooter2 = db.Shooters.Where(s => s.numAtr == int.Parse(numAtrBox2.Text)).FirstOrDefault();

                if (numAtrBox1.Text == numAtrBox2.Text)
                {
                    MessageBox.Show($"Não é possível realizar trocas de serviço usando o mesmo atirador nos dois campos.");
                    shooter1InfoLabel.Visible = false;
                    shooter2InfoLabel.Visible = false;
                    date1Label.Visible = false;
                    date2Label.Visible = false;
                    dateTimeService1.Visible = false;
                    dateTimeService2.Visible = false;
                    btQueryServices.Visible = false;
                    btSwap.Visible = false;
                    service1InfoLabel.Visible = false;
                    service2InfoLabel.Visible = false;
                    service1Form = null;
                    service2Form = null;
                    shooter1Form = null;
                    shooter2Form = null;
                }
                else if (shooter1 == null)
                {
                    MessageBox.Show($"Não foi encontrado o primeiro atirador de número {numAtrBox1.Text}");
                    shooter1InfoLabel.Visible = false;
                    shooter2InfoLabel.Visible = false;
                    date1Label.Visible = false;
                    date2Label.Visible = false;
                    dateTimeService1.Visible = false;
                    dateTimeService2.Visible = false;
                    btQueryServices.Visible = false;
                    btSwap.Visible = false;
                    service1InfoLabel.Visible = false;
                    service2InfoLabel.Visible = false;
                    service1Form = null;
                    service2Form = null;
                    shooter1Form = null;
                    shooter2Form = null;
                }
                else if (shooter2 == null)
                {
                    MessageBox.Show($"Não foi " +
                        $"encontrado o segundo atirador de número {numAtrBox2.Text}");
                    shooter1InfoLabel.Visible = false;
                    shooter2InfoLabel.Visible = false;
                    date1Label.Visible = false;
                    date2Label.Visible = false;
                    dateTimeService1.Visible = false;
                    dateTimeService2.Visible = false;
                    btQueryServices.Visible = false;
                    btSwap.Visible = false;
                    service1InfoLabel.Visible = false;
                    service2InfoLabel.Visible = false;
                    service1Form = null;
                    service2Form = null;
                    shooter1Form = null;
                    shooter2Form = null;
                }
                else
                {
                    shooter1Form = shooter1;
                    shooter2Form = shooter2;
                    shooter1InfoLabel.Text = $"Atirador {shooter1.numAtr} {shooter1.warName} foi selecionado para a troca";
                    shooter2InfoLabel.Text = $"Atirador {shooter2.numAtr} {shooter2.warName} foi selecionado para a troca";
                    shooter1InfoLabel.Visible = true;
                    shooter2InfoLabel.Visible = true;
                    date1Label.Visible = true;
                    date2Label.Visible = true;
                    dateTimeService1.Visible = true;
                    dateTimeService2.Visible = true;
                    btQueryServices.Visible = true;
                }
            }
        }

        private void btQueryServices_Click(object sender, EventArgs e)
        {
            if (shooter1Form == null)
            {
                MessageBox.Show($"Não foi encontrado o primeiro atirador.");
                shooter1InfoLabel.Visible = false;
                shooter2InfoLabel.Visible = false;
                date1Label.Visible = false;
                date2Label.Visible = false;
                dateTimeService1.Visible = false;
                dateTimeService2.Visible = false;
                btQueryServices.Visible = false;
                service1Form = null;
                service2Form = null;
            }
            else if (shooter2Form == null)
            {
                MessageBox.Show($"Não foi encontrado o segundo atirador.");
                shooter1InfoLabel.Visible = false;
                shooter2InfoLabel.Visible = false;
                date1Label.Visible = false;
                date2Label.Visible = false;
                dateTimeService1.Visible = false;
                dateTimeService2.Visible = false;
                btQueryServices.Visible = false;
                service1Form = null;
                service2Form = null;
            }
            else
            {
                using (var db = new ServiceContext())
                {
                    DateOnly date1 = DateOnly.FromDateTime(dateTimeService1.Value);
                    DateOnly date2 = DateOnly.FromDateTime(dateTimeService2.Value);

                    // Carregar ServiceScale com todos os serviços associados e suas propriedades relacionadas
                    var service1 = db.Services
                        .Include(s => s.CommanderOfTheGuard)
                        .Include(s => s.Permanences)
                        .Include(s => s.Sentinels)
                        .Where(s => s.Date == date1)
                        .FirstOrDefault();
                    var service2 = db.Services
                        .Include(s => s.CommanderOfTheGuard)
                        .Include(s => s.Permanences)
                        .Include(s => s.Sentinels)
                        .Where(s => s.Date == date2)
                        .FirstOrDefault();

                    if (service1 != null && service2 != null)
                    {
                        btSwap.Visible = true;
                        service1InfoLabel.Visible = true;
                        service2InfoLabel.Visible = true;
                        service1Form = service1;
                        service2Form = service2;
                        service1InfoLabel.Text = $"Serviço com a data {date1} foi encontrado para a troca.";
                        service2InfoLabel.Text = $"Serviço com a data {date2} foi encontrado para a troca.";
                    }
                    else if (service1 == null)
                    {
                        MessageBox.Show($"Não foi encontrado o primeiro serviço da troca com a data {date1}.");
                        btSwap.Visible = false;
                        service1InfoLabel.Visible = false;
                        service2InfoLabel.Visible = false;
                        service1Form = null;
                        service2Form = null;
                    }
                    else if (service2 == null)
                    {
                        MessageBox.Show($"Não foi encontrado o segundo serviço da troca com a data {date2}.");
                        btSwap.Visible = false;
                        service1InfoLabel.Visible = false;
                        service2InfoLabel.Visible = false;
                        service1Form = null;
                        service2Form = null;
                    }
                }
            }
        }

        private void btSwap_Click(object sender, EventArgs e)
        {
            if (service1Form == null || service2Form == null || shooter1Form == null || shooter2Form == null)
            {
                MessageBox.Show("Não foi possível realizar a troca de serviço porque um dos dados solicitados está nulo.");
            }
            else
            {
                using (var db = new ServiceContext())
                {
                    if (!service1Form.HasShooter(shooter1Form))
                    {
                        MessageBox.Show($"O atirador {shooter1Form.numAtr} {shooter1Form.warName} não foi encontrado no serviço de data {service1Form.Date}.");
                    }
                    else if (!service2Form.HasShooter(shooter2Form))
                    {
                        MessageBox.Show($"O atirador {shooter2Form.numAtr} {shooter2Form.warName} não foi encontrado no serviço de data {service2Form.Date}.");
                    }
                    else
                    {
                        Shooter? shooter1 = db.Shooters.Where(s => s.numAtr == shooter1Form.numAtr).FirstOrDefault();
                        Shooter? shooter2 = db.Shooters.Where(s => s.numAtr == shooter2Form.numAtr).FirstOrDefault();
                        var service1 = db.Services
                        .Include(s => s.CommanderOfTheGuard)
                        .Include(s => s.Permanences)
                        .Include(s => s.Sentinels)
                        .Where(s => s.Date == service1Form.Date)
                        .FirstOrDefault();
                        var service2 = db.Services
                            .Include(s => s.CommanderOfTheGuard)
                            .Include(s => s.Permanences)
                            .Include(s => s.Sentinels)
                            .Where(s => s.Date == service2Form.Date)
                            .FirstOrDefault();
                        if(service1 != null && service2 != null && shooter1 != null && shooter2 != null)
                        {
                            int s1 = service1.ShowShooterFunctionInScale(shooter1);
                            int s2 = service2.ShowShooterFunctionInScale(shooter2);
                            if ((s1 == 1) && (s2 == 1))
                            {
                                service1.RemovePermanence(shooter1);
                                service2.RemovePermanence(shooter2);
                                service1.AddPermanenceSwap(shooter2);
                                service2.AddPermanenceSwap(shooter1);
                            }
                            else if ((s1 == 1) && (s2 == 2))
                            {
                                service1.RemovePermanence(shooter1);
                                service2.RemoveSentinel(shooter2);
                                service1.AddPermanenceSwap(shooter2);
                                service2.AddSentinelSwap(shooter1);
                            }
                            else if ((s1 == 1) && (s2 == 3))
                            {
                                service1.RemovePermanence(shooter1);
                                service1.AddPermanenceSwap(shooter2);
                                service2.SetCommanderOfTheGuardSwap(shooter1);
                            }
                            else if ((s1 == 2) && (s2 == 1))
                            {
                                service1.RemoveSentinel(shooter1);
                                service2.RemovePermanence(shooter2);
                                service1.AddSentinelSwap(shooter2);
                                service2.AddPermanenceSwap(shooter1);
                            }
                            else if ((s1 == 2) && (s2 == 2))
                            {
                                service1.RemoveSentinel(shooter1);
                                service2.RemoveSentinel(shooter2);
                                service1.AddSentinelSwap(shooter2);
                                service2.AddSentinelSwap(shooter1);
                            }
                            else if ((s1 == 2) && (s2 == 3))
                            {
                                service1.RemoveSentinel(shooter1);
                                service1.AddSentinelSwap(shooter2);
                                service2.SetCommanderOfTheGuardSwap(shooter1);
                            }
                            else if ((s1 == 3) && (s2 == 1))
                            {
                                service1.SetCommanderOfTheGuardSwap(shooter2);
                                service2.RemovePermanence(shooter2);
                                service2.AddPermanenceSwap(shooter1);
                            }
                            else if ((s1 == 3) && (s2 == 2))
                            {
                                service1.SetCommanderOfTheGuardSwap(shooter2);
                                service2.RemoveSentinel(shooter2);
                                service2.AddSentinelSwap(shooter1);
                            }
                            else if ((s1 == 3) && (s2 == 3))
                            {
                                service1.SetCommanderOfTheGuardSwap(shooter2);
                                service2.SetCommanderOfTheGuardSwap(shooter1);
                            }
                            db.SaveChanges();

                            MessageBox.Show($"A troca de serviço foi realizada com sucesso!!\nNo serviço do dia {service1.Date} ficou o atirador {shooter2.numAtr} {shooter2.warName}.\nNo serviço do dia {service2.Date} ficou o atirador {shooter1.numAtr} {shooter1.warName}.");
                        }
                    }
                }
            }
        }
    }
}
