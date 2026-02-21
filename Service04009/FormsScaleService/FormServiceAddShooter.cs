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
    public partial class FormServiceAddShooter : BaseChildForm
    {
        public FormServiceAddShooter()
        {
            InitializeComponent();
            ArrangeLayout();
        }

        private void ArrangeLayout()
        {
            // ── Título ──
            label1.Location = new Point(20, 10);

            // ── Busca do atirador ──
            int secY = 65;
            label3.Location = new Point(30, secY);
            label3.Padding = Padding.Empty;
            numAtrBox1.Location = new Point(30, secY + 22);
            numAtrBox1.Size = new Size(280, 25);
            btQueryShooters.Location = new Point(320, secY + 20);
            btQueryShooters.Size = new Size(420, 28);
            shooter1InfoLabel.Location = new Point(30, secY + 58);
            shooter1InfoLabel.Padding = new Padding(8, 4, 8, 4);

            // ── Data do serviço ──
            int dateY = secY + 95;
            date1Label.Location = new Point(30, dateY);
            date1Label.Padding = Padding.Empty;
            dateTimeService1.Location = new Point(30, dateY + 22);
            dateTimeService1.Size = new Size(280, 26);

            // ── Atirador que perderá serviço ──
            int sec2Y = dateY + 65;
            numAtr2Label.Location = new Point(30, sec2Y);
            numAtr2Label.Padding = Padding.Empty;
            numAtrBox2.Location = new Point(30, sec2Y + 22);
            numAtrBox2.Size = new Size(280, 25);

            btQueryServices.Location = new Point(320, sec2Y + 55);
            btQueryServices.Size = new Size(500, 30);

            service1InfoLabel.Location = new Point(30, sec2Y + 95);
            service1InfoLabel.Size = new Size(1185, 64);
            service1InfoLabel.Padding = new Padding(8, 4, 8, 4);

            // ── Botão atribuir ──
            btSwap.Location = new Point(150, sec2Y + 175);
            btSwap.Size = new Size(950, 50);
        }
        Shooter? shooter1Form;
        Shooter? shooter2Form;
        Service? service1Form;

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
                Shooter? shooter1 = db.Shooters.Where(s => s.numAtr == int.Parse(numAtrBox1.Text)).FirstOrDefault();

                if (shooter1 == null)
                {
                    MessageBox.Show($"Não foi encontrado o atirador de número {numAtrBox1.Text}.");
                    shooter1InfoLabel.Visible = false;
                    date1Label.Visible = false;
                    dateTimeService1.Visible = false;
                    btQueryServices.Visible = false;
                    btSwap.Visible = false;
                    numAtr2Label.Visible = false;
                    numAtrBox2.Visible = false;
                    service1InfoLabel.Visible = false;
                    service1Form = null;
                    shooter1Form = null;
                    shooter2Form = null;
                }
                else
                {
                    shooter1Form = shooter1;
                    shooter1InfoLabel.Text = $"Atirador {shooter1.numAtr} {shooter1.warName} foi selecionado para receber um serviço";
                    shooter1InfoLabel.Visible = true;
                    date1Label.Visible = true;
                    dateTimeService1.Visible = true;
                    btQueryServices.Text = $"Clique aqui para buscar o serviço que será atribuído ao atirador {shooter1.numAtr} {shooter1.warName}.";
                    btQueryServices.Visible = true;
                    numAtr2Label.Visible = true;
                    numAtrBox2.Visible = true;
                }
            }
        }

        private void btQueryServices_Click(object sender, EventArgs e)
        {
            if (shooter1Form == null)
            {
                MessageBox.Show($"Não foi encontrado o atirador que receberá o serviço.");
                shooter1InfoLabel.Visible = false;
                date1Label.Visible = false;
                dateTimeService1.Visible = false;
                btQueryServices.Visible = false;
                numAtr2Label.Visible = false;
                numAtrBox2.Visible = false;
                service1Form = null;
                shooter2Form = null;
            }
            else
            {
                using (var db = new ServiceContext())
                {
                    DateOnly date1 = DateOnly.FromDateTime(dateTimeService1.Value);

                    // Carregar ServiceScale com todos os serviços associados e suas propriedades relacionadas
                    var service1 = db.Services
                        .Include(s => s.Commanders)
                        .Include(s => s.Permanences)
                        .Include(s => s.Sentinels)
                        .Where(s => s.Date == date1)
                        .FirstOrDefault();
                    var shooter2 = db.Shooters.Where(s => s.numAtr == int.Parse(numAtrBox2.Text)).FirstOrDefault();

                    if (service1 != null && shooter2 != null)
                    {

                        if (!service1.HasShooter(shooter2))
                        {
                            MessageBox.Show($"O atirador {shooter2.numAtr} {shooter2.warName} não foi encontrado no serviço do dia {service1.Date}");
                            shooter1InfoLabel.Visible = false;
                            date1Label.Visible = false;
                            dateTimeService1.Visible = false;
                            btQueryServices.Visible = false;
                            service1Form = null;
                            shooter2Form = null;
                            btSwap.Visible = false;
                            service1InfoLabel.Visible = false;
                            numAtr2Label.Visible = false;
                            numAtrBox2.Visible = false;
                        }
                        else
                        {
                            btSwap.Visible = true;
                            service1InfoLabel.Visible = true;
                            service1Form = service1;
                            shooter2Form = shooter2;
                            int s = service1.ShowShooterFunctionInScale(shooter2);
                            if (s == 1)
                            {
                                service1InfoLabel.Text = $"Serviço com a data {date1} foi encontrado para a alteração tirando do serviço o atirador {shooter2.numAtr} {shooter2.warName} que está de permanência e passando o serviço para o atirador {shooter1Form.numAtr} {shooter1Form.warName}.";
                            }
                            if (s == 2)
                            {
                                service1InfoLabel.Text = $"Serviço com a data {date1} foi encontrado para a alteração tirando do serviço o atirador {shooter2.numAtr} {shooter2.warName} que está de sentinela e passando o serviço para o atirador {shooter1Form.numAtr} {shooter1Form.warName}.";
                            }
                            if (s == 3)
                            {
                                service1InfoLabel.Text = $"Serviço com a data {date1} foi encontrado para a alteração tirando do serviço o atirador {shooter2.numAtr} {shooter2.warName} que está de comandante da guarda e passando o serviço para o atirador {shooter1Form.numAtr} {shooter1Form.warName}.";
                            }
                        }
                    }
                    else if (shooter2 == null)
                    {
                        MessageBox.Show($"Não foi encontrado o atirador do serviço que será alterado.");
                        shooter1InfoLabel.Visible = false;
                        date1Label.Visible = false;
                        dateTimeService1.Visible = false;
                        btQueryServices.Visible = false;
                        service1Form = null;
                        btSwap.Visible = false;
                        service1InfoLabel.Visible = false;
                        numAtr2Label.Visible = false;
                        numAtrBox2.Visible = false;
                    }
                    else if (service1 == null)
                    {
                        MessageBox.Show($"Não foi encontrado o serviço para a alteração com a data {date1}.");
                        btSwap.Visible = false;
                        service1InfoLabel.Visible = false;
                        service1Form = null;
                        shooter1InfoLabel.Visible = false;
                        date1Label.Visible = false;
                        dateTimeService1.Visible = false;
                        btQueryServices.Visible = false;
                        numAtr2Label.Visible = false;
                        numAtrBox2.Visible = false;
                        shooter2Form = null;
                    }
                }
            }
        }

        private void btSwap_Click(object sender, EventArgs e)
        {
            if (service1Form == null || shooter1Form == null || shooter2Form == null)
            {
                MessageBox.Show("Não foi possível realizar a troca de serviço porque um dos dados solicitados está nulo.");
            }
            else
            {
                using (var db = new ServiceContext())
                {
                    if (!service1Form.HasShooter(shooter2Form))
                    {
                        MessageBox.Show($"O atirador {shooter1Form.numAtr} {shooter1Form.warName} não foi encontrado no serviço de data {service1Form.Date}.");
                    }
                    else
                    {
                        Shooter? shooter1 = db.Shooters.Where(s => s.numAtr == shooter1Form.numAtr).FirstOrDefault();
                        Shooter? shooter2 = db.Shooters.Where(s => s.numAtr == shooter2Form.numAtr).FirstOrDefault();
                        var service1 = db.Services
                        .Include(s => s.Commanders)
                        .Include(s => s.Permanences)
                        .Include(s => s.Sentinels)
                        .Where(s => s.Date == service1Form.Date)
                        .FirstOrDefault();
                        if (service1 != null && shooter1 != null && shooter2 != null)
                        {
                            shooter1.AddServiceExtra();
                            shooter2.SubtractServiceExtra();
                            int s1 = service1.ShowShooterFunctionInScale(shooter2);
                            if (s1 == 1)
                            {
                                service1.RemovePermanence(shooter2);
                                service1.AddPermanenceSwap(shooter1);
                            }
                            else if (s1 == 2)
                            {
                                service1.RemoveSentinel(shooter2);
                                service1.AddSentinelSwap(shooter1);
                            }
                            else if (s1 == 3)
                            {
                                service1.RemoveCommander(shooter2);
                                service1.AddCommanderSwap(shooter1);
                            }
                            db.SaveChanges();

                            MessageBox.Show($"A atribuição de serviço foi realizada com sucesso!!\nNo serviço do dia {service1.Date} ficou o atirador {shooter1.numAtr} {shooter1.warName}.");
                            btSwap.Visible = false;
                            service1InfoLabel.Visible = false;
                            service1Form = null;
                            shooter1InfoLabel.Visible = false;
                            date1Label.Visible = false;
                            dateTimeService1.Visible = false;
                            btQueryServices.Visible = false;
                            numAtr2Label.Visible = false;
                            numAtrBox2.Visible = false;
                            service1Form = null;
                            shooter1Form = null;
                            shooter2Form = null;
                        }
                    }
                }
            }
        }
    }
}
