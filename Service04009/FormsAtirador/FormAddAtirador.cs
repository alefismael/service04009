using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service04009.FormsAtirador
{
    public partial class FormAddAtirador : BaseChildForm
    {
        public FormAddAtirador()
        {
            InitializeComponent();
            ArrangeLayout();
            using (var db = new ServiceContext())
            {
                List<ShooterDT> shooterDt = db.Shooters.OrderBy(s => s.numAtr).Select(shoot => new ShooterDT(shoot)).ToList();
                table.DataSource = shooterDt;
            }
        }

        private void ArrangeLayout()
        {
            // Título
            label1.Location = new Point(20, 10);

            // Campos de cadastro — coluna esquerda
            int leftX = 25;
            int fieldY = 55;

            label2.Location = new Point(leftX, fieldY);
            label2.Padding = Padding.Empty;
            warNameBox.Location = new Point(leftX, fieldY + 22);
            warNameBox.Size = new Size(240, 25);

            label3.Location = new Point(leftX, fieldY + 58);
            label3.Padding = Padding.Empty;
            numAtrBox.Location = new Point(leftX, fieldY + 80);
            numAtrBox.Size = new Size(160, 25);

            label4.Location = new Point(leftX, fieldY + 116);
            label4.Padding = Padding.Empty;
            numServiceBox.Location = new Point(leftX, fieldY + 138);
            numServiceBox.Size = new Size(200, 25);

            label5.Location = new Point(leftX, fieldY + 174);
            label5.Padding = Padding.Empty;
            checkIsNotCfc.Location = new Point(leftX, fieldY + 196);
            checkIsCfc.Location = new Point(leftX + 65, fieldY + 196);

            // Tabela — direita dos campos
            label16.Location = new Point(300, fieldY);
            label16.Padding = Padding.Empty;
            table.Location = new Point(300, fieldY + 22);
            table.Size = new Size(930, 210);

            // Disponibilidade — linha abaixo
            int availY = 300;
            label6.Location = new Point(leftX, availY);
            label6.Padding = Padding.Empty;

            string[] dayLabels = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            Label[] dayLabelControls = { label12, label13, label11, label9, label10, label15, label14 };
            CheckBox[] morningChecks = { sunMorning, monMorning, tueMorning, wedMorning, thuMorning, friMorning, satMorning };
            CheckBox[] nightChecks = { sunNight, monNight, tueNight, wedNight, thuNight, friNight, satNight };

            int colStart = 140;
            int colWidth = 115;
            for (int i = 0; i < 7; i++)
            {
                int cx = colStart + i * colWidth;
                dayLabelControls[i].Text = dayLabels[i];
                dayLabelControls[i].Location = new Point(cx + 25, availY);
                dayLabelControls[i].Padding = Padding.Empty;
                morningChecks[i].Location = new Point(cx, availY + 22);
                morningChecks[i].Size = new Size(105, 26);
                nightChecks[i].Location = new Point(cx, availY + 56);
                nightChecks[i].Size = new Size(105, 26);
            }

            label7.Location = new Point(leftX, availY + 25);
            label7.Padding = Padding.Empty;
            label8.Location = new Point(leftX, availY + 59);
            label8.Padding = Padding.Empty;

            // Botão cadastrar
            btCadastrar.Location = new Point(200, availY + 100);
            btCadastrar.Size = new Size(750, 48);
        }

        private void checkIsCfc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsCfc.Checked == true && checkIsNotCfc.Checked == true)
            {
                checkIsNotCfc.Checked = false;
            }
        }

        private void checkIsNotCfc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsNotCfc.Checked == true && checkIsCfc.Checked == true)
            {
                checkIsCfc.Checked = false;
            }
        }

        private void warNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Conjunto de caracteres adicionais permitidos
            char[] allowedSpecialChars = { (char)8, ' ', '.' };

            // Verificar se é uma letra ou caractere permitido
            if (char.IsLetter(e.KeyChar) || allowedSpecialChars.Contains(e.KeyChar))
            {
                return;
            }

            // Caso contrário, cancelar o evento de tecla
            e.Handled = true;
        }

        private void numAtrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void numServiceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                int numAtr = 0;
                if (numAtrBox.Text != "")
                {
                    numAtr = int.Parse(numAtrBox.Text);
                }
                int numService = 0;
                if (numServiceBox.Text != "")
                {
                    numService = int.Parse(numServiceBox.Text);
                }

                if (numAtr == 0)
                {
                    MessageBox.Show("Por favor, passe apenas um número maior que 0 para o atirador ser poder cadastrado");
                }
                else if (warNameBox.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, informe um nome para o atirador");
                }
                else if (!checkIsCfc.Checked && !checkIsNotCfc.Checked)
                {
                    MessageBox.Show("Por favor, informe se o atirador a ser adicionado é CFC ou não");
                }
                else if (db.Shooters.Where(s => s.warName == warNameBox.Text).ToList().Count > 0)
                {
                    MessageBox.Show("Por favor, informe um nome para o atirador que ainda não foi cadastrado no sistema.");
                }
                else if (db.Shooters.Where(s => s.numAtr == numAtr).ToList().Count > 0)
                {
                    MessageBox.Show("Por favor, informe um número para o atirador que ainda não foi cadastrado no sistema.");
                }
                else if (warNameBox.Text != "" && numAtrBox.Text != "" && (checkIsCfc.Checked || checkIsNotCfc.Checked) && numServiceBox.Text != "")
                {
                    Shooter shooter;
                    bool cfc = false;
                    if (checkIsCfc.Checked)
                    {
                        cfc = true;
                    }
                    shooter = new Shooter(int.Parse(numAtrBox.Text), warNameBox.Text.Trim(), cfc, int.Parse(numServiceBox.Text), sunMorning.Checked, sunNight.Checked, monMorning.Checked, monNight.Checked, tueMorning.Checked, tueNight.Checked, wedMorning.Checked, wedNight.Checked, thuMorning.Checked, thuNight.Checked, friMorning.Checked, friNight.Checked, satMorning.Checked, satNight.Checked);
                    db.Shooters.Add(shooter);
                    db.SaveChanges();
                    MessageBox.Show($"O atirador {numAtrBox.Text} {warNameBox.Text.Trim()} foi cadastrado no sistema.");
                    List<ShooterDT> shooterDt = db.Shooters.OrderBy(s => s.numAtr).Select(shoot => new ShooterDT(shoot)).ToList();
                    table.DataSource = shooterDt;
                }
                else if (warNameBox.Text != "" && numAtrBox.Text != "" && (checkIsCfc.Checked || checkIsNotCfc.Checked) && numServiceBox.Text == "")
                {
                    Shooter shooter;
                    bool cfc = false;
                    if (checkIsCfc.Checked)
                    {
                        cfc = true;
                    }
                    shooter = new Shooter(int.Parse(numAtrBox.Text), warNameBox.Text.Trim(), cfc, 0, sunMorning.Checked, sunNight.Checked, monMorning.Checked, monNight.Checked, tueMorning.Checked, tueNight.Checked, wedMorning.Checked, wedNight.Checked, thuMorning.Checked, thuNight.Checked, friMorning.Checked, friNight.Checked, satMorning.Checked, satNight.Checked);

                    db.Shooters.Add(shooter);
                    db.SaveChanges();
                    MessageBox.Show($"O atirador {numAtrBox.Text} {warNameBox.Text.Trim()} foi cadastrado no sistema.");
                    List<ShooterDT> shooterDt = db.Shooters.OrderBy(s => s.numAtr).Select(shoot => new ShooterDT(shoot)).ToList();
                    table.DataSource = shooterDt;

                }
            }
        }

        private void sunMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (sunMorning.Checked == true)
            {
                sunMorning.Text = "Disponível";
            }
            else
            {
                sunMorning.Text = "Indisponível";
            }
        }

        private void sunNight_CheckedChanged(object sender, EventArgs e)
        {
            if (sunNight.Checked == true)
            {
                sunNight.Text = "Disponível";
            }
            else
            {
                sunNight.Text = "Indisponível";
            }
        }

        private void monMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (monMorning.Checked == true)
            {
                monMorning.Text = "Disponível";
            }
            else
            {
                monMorning.Text = "Indisponível";
            }
        }

        private void monNight_CheckedChanged(object sender, EventArgs e)
        {
            if (monNight.Checked == true)
            {
                monNight.Text = "Disponível";
            }
            else
            {
                monNight.Text = "Indisponível";
            }
        }

        private void tueMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (tueMorning.Checked == true)
            {
                tueMorning.Text = "Disponível";
            }
            else
            {
                tueMorning.Text = "Indisponível";
            }
        }

        private void tueNight_CheckedChanged(object sender, EventArgs e)
        {
            if (tueNight.Checked == true)
            {
                tueNight.Text = "Disponível";
            }
            else
            {
                tueNight.Text = "Indisponível";
            }
        }

        private void wedMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (wedMorning.Checked == true)
            {
                wedMorning.Text = "Disponível";
            }
            else
            {
                wedMorning.Text = "Indisponível";
            }
        }

        private void wedNight_CheckedChanged(object sender, EventArgs e)
        {
            if (wedNight.Checked == true)
            {
                wedNight.Text = "Disponível";
            }
            else
            {
                wedNight.Text = "Indisponível";
            }
        }

        private void thuMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (thuMorning.Checked == true)
            {
                thuMorning.Text = "Disponível";
            }
            else
            {
                thuMorning.Text = "Indisponível";
            }
        }

        private void thuNight_CheckedChanged(object sender, EventArgs e)
        {
            if (thuNight.Checked == true)
            {
                thuNight.Text = "Disponível";
            }
            else
            {
                thuNight.Text = "Indisponível";
            }
        }

        private void friMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (friMorning.Checked == true)
            {
                friMorning.Text = "Disponível";
            }
            else
            {
                friMorning.Text = "Indisponível";
            }
        }

        private void friNight_CheckedChanged(object sender, EventArgs e)
        {
            if (friNight.Checked == true)
            {
                friNight.Text = "Disponível";
            }
            else
            {
                friNight.Text = "Indisponível";
            }
        }

        private void satMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (satMorning.Checked == true)
            {
                satMorning.Text = "Disponível";
            }
            else
            {
                satMorning.Text = "Indisponível";
            }
        }

        private void satNight_CheckedChanged(object sender, EventArgs e)
        {
            if (satNight.Checked == true)
            {
                satNight.Text = "Disponível";
            }
            else
            {
                satNight.Text = "Indisponível";
            }
        }
    }
}