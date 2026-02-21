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

namespace Service04009.FormsAtirador
{
    public partial class FormUpdateByName : BaseChildForm
    {
        private Shooter? shooter;

        public FormUpdateByName()
        {
            InitializeComponent();
            ArrangeLayout();
        }

        private void ArrangeLayout()
        {
            // ── Limpar estilos antigos do Designer ──
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Label lbl && lbl != label1 && lbl != infoLabel)
                {
                    lbl.BackColor = Color.Transparent;
                    lbl.Padding = Padding.Empty;
                }
            }

            // ── Título ──
            label1.Location = new Point(20, 10);

            // ── Busca (linha compacta) ──
            int searchY = 58;
            label3.Location = new Point(30, searchY);
            nameQueryBox.Location = new Point(30, searchY + 22);
            nameQueryBox.Size = new Size(280, 25);
            btQuery.Location = new Point(320, searchY + 20);
            btQuery.Size = new Size(420, 28);
            infoLabel.Location = new Point(760, searchY + 18);
            infoLabel.Padding = new Padding(10, 4, 10, 4);

            // ── Tabela ──
            table.Location = new Point(30, searchY + 58);
            table.Size = new Size(1185, 70);
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ── Campos de edição — linha uniforme ──
            int editY = searchY + 145;
            int col1 = 30, col2 = 270, col3 = 470, col4 = 700;

            warNameLabel.Location = new Point(col1, editY);
            warNameBox.Location = new Point(col1, editY + 22);
            warNameBox.Size = new Size(220, 25);

            numAtrLabel.Location = new Point(col2, editY);
            numAtrUpBox.Location = new Point(col2, editY + 22);
            numAtrUpBox.Size = new Size(170, 25);

            numServiceLabel.Location = new Point(col3, editY);
            numServiceBox.Location = new Point(col3, editY + 22);
            numServiceBox.Size = new Size(200, 25);

            isCfcLabel.Location = new Point(col4, editY);
            isCfcLabel.Padding = Padding.Empty;
            checkIsNotCfc.Location = new Point(col4, editY + 22);
            checkIsCfc.Location = new Point(col4 + 55, editY + 22);

            // ── Disponibilidade ──
            int dispY = editY + 65;
            disponibleLabel.Location = new Point(30, dispY);

            string[] dayNames = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            Label[] dayLabels = { sunLabel, monLabel, tueLabel, wedLabel, thuLabel, friLabel, satLabel };
            CheckBox[] morningCbs = { sunMorning, monMorning, tueMorning, wedMorning, thuMorning, friMorning, satMorning };
            CheckBox[] nightCbs = { sunNight, monNight, tueNight, wedNight, thuNight, friNight, satNight };

            int gridStartX = 160;
            int colSpacing = 130;
            int headerY = dispY;
            int morningY = dispY + 25;
            int nightY = dispY + 55;

            permaLabel.Location = new Point(30, morningY);
            sentiLabel.Location = new Point(30, nightY);

            for (int i = 0; i < 7; i++)
            {
                int cx = gridStartX + colSpacing * i;
                dayLabels[i].Text = dayNames[i];
                dayLabels[i].Location = new Point(cx + 20, headerY);
                morningCbs[i].Location = new Point(cx, morningY);
                morningCbs[i].Size = new Size(115, 24);
                nightCbs[i].Location = new Point(cx, nightY);
                nightCbs[i].Size = new Size(115, 24);
            }

            // ── Botão salvar ──
            btCadastrar.Location = new Point(200, nightY + 42);
            btCadastrar.Size = new Size(850, 48);
        }

        private void checkIsNotCfc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsNotCfc.Checked == true && checkIsCfc.Checked == true)
            {
                checkIsCfc.Checked = false;
            }
        }

        private void checkIsCfc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsCfc.Checked == true && checkIsNotCfc.Checked == true)
            {
                checkIsNotCfc.Checked = false;
            }
        }
        
        private void nameQueryBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void numAtrUpBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
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

        private void numServiceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
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

        private void btQuery_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                var shooterQuery = db.Shooters.Where(s => s.warName == nameQueryBox.Text.Trim()).ToList();
                if (shooterQuery.Count == 0)
                {
                    MessageBox.Show("Sem atirador encontrado");
                    shooter = null;
                    infoLabel.Text = "Sem atirador informado para atualizar os dados";
                    infoLabel.BackColor = Color.Red;

                    btCadastrar.Visible = false;
                    warNameBox.Visible = false;
                    numAtrUpBox.Visible = false;
                    numServiceBox.Visible = false;
                    isCfcLabel.Visible = false;
                    warNameLabel.Visible = false;
                    numAtrLabel.Visible = false;
                    numServiceLabel.Visible = false;
                    isCfcLabel.Visible = false;
                    checkIsNotCfc.Visible = false;
                    checkIsCfc.Visible = false;

                    disponibleLabel.Visible = false;
                    permaLabel.Visible = false;
                    sentiLabel.Visible = false;
                    sunLabel.Visible = false;
                    sunMorning.Visible = false;
                    sunNight.Visible = false;
                    monLabel.Visible = false;
                    monMorning.Visible = false;
                    monNight.Visible = false;
                    tueLabel.Visible = false;
                    tueMorning.Visible = false;
                    tueNight.Visible = false;

                    wedLabel.Visible = false;
                    wedMorning.Visible = false;
                    wedNight.Visible = false;
                    thuLabel.Visible = false;
                    thuMorning.Visible = false;
                    thuNight.Visible = false;

                    friLabel.Visible = false;
                    friMorning.Visible = false;
                    friNight.Visible = false;
                    satLabel.Visible = false;
                    satMorning.Visible = false;
                    satNight.Visible = false;

                    table.DataSource = null;
                }
                else
                {
                    shooter = shooterQuery.FirstOrDefault();
                    if (shooter != null)
                    {
                        table.DataSource = new List<ShooterDT> { new ShooterDT(shooter) };
                    }
                    infoLabel.Text = "Esse é o atirador que você atualizará os dados.";

                    infoLabel.BackColor = Color.Lime;
                    btCadastrar.Visible = true;
                    warNameBox.Visible = true;
                    numAtrUpBox.Visible = true;
                    numServiceBox.Visible = true;
                    isCfcLabel.Visible = true;
                    warNameLabel.Visible = true;
                    numAtrLabel.Visible = true;
                    numServiceLabel.Visible = true;
                    isCfcLabel.Visible = true;
                    checkIsNotCfc.Visible = true;
                    checkIsCfc.Visible = true;

                    disponibleLabel.Visible = true;
                    permaLabel.Visible = true;
                    sentiLabel.Visible = true;
                    sunLabel.Visible = true;
                    sunMorning.Visible = true;
                    sunNight.Visible = true;
                    monLabel.Visible = true;
                    monMorning.Visible = true;
                    monNight.Visible = true;
                    tueLabel.Visible = true;
                    tueMorning.Visible = true;
                    tueNight.Visible = true;

                    wedLabel.Visible = true;
                    wedMorning.Visible = true;
                    wedNight.Visible = true;
                    thuLabel.Visible = true;
                    thuMorning.Visible = true;
                    thuNight.Visible = true;

                    friLabel.Visible = true;
                    friMorning.Visible = true;
                    friNight.Visible = true;
                    satLabel.Visible = true;
                    satMorning.Visible = true;
                    satNight.Visible = true;

                    warNameBox.Visible = true;
                    numAtrUpBox.Visible = true;
                    numServiceBox.Visible = true;
                    checkIsNotCfc.Visible = true;
                    checkIsCfc.Visible = true;

                    if (shooter != null)
                    {
                        warNameBox.Text = shooter.warName;
                        numAtrUpBox.Text = shooter.numAtr.ToString();
                        numServiceBox.Text = shooter.CountService().ToString();
                        if (shooter.isCfc)
                        {
                            checkIsCfc.Checked = true;
                            checkIsNotCfc.Checked = false;
                        }
                        else
                        {
                            checkIsCfc.Checked = false;
                            checkIsNotCfc.Checked = true;
                        }

                        sunMorning.Checked = shooter.sunMorning;
                        sunMorning.Text = sunMorning.Checked ? "Disponível" : "Indisponível";
                        sunNight.Checked = shooter.sunNight;
                        sunNight.Text = sunNight.Checked ? "Disponível" : "Indisponível";
                        monMorning.Checked = shooter.monMorning;
                        monMorning.Text = monMorning.Checked ? "Disponível" : "Indisponível";
                        monNight.Checked = shooter.monNight;
                        monNight.Text = monNight.Checked ? "Disponível" : "Indisponível";
                        tueMorning.Checked = shooter.tueMorning;
                        tueMorning.Text = tueMorning.Checked ? "Disponível" : "Indisponível";
                        tueNight.Checked = shooter.tueNight;
                        tueNight.Text = tueNight.Checked ? "Disponível" : "Indisponível";

                        wedMorning.Checked = shooter.wedMorning;
                        wedMorning.Text = wedMorning.Checked ? "Disponível" : "Indisponível";
                        wedNight.Checked = shooter.wedNight;
                        wedNight.Text = wedNight.Checked ? "Disponível" : "Indisponível";
                        thuMorning.Checked = shooter.thuMorning;
                        thuMorning.Text = thuMorning.Checked ? "Disponível" : "Indisponível";
                        thuNight.Checked = shooter.thuNight;
                        thuNight.Text = thuNight.Checked ? "Disponível" : "Indisponível";

                        friMorning.Checked = shooter.friMorning;
                        friMorning.Text = friMorning.Checked ? "Disponível" : "Indisponível";
                        friNight.Checked = shooter.friNight;
                        friNight.Text = friNight.Checked ? "Disponível" : "Indisponível";
                        satMorning.Checked = shooter.satMorning;
                        satMorning.Text = satMorning.Checked ? "Disponível" : "Indisponível";
                        satNight.Checked = shooter.satNight;
                        satNight.Text = satNight.Checked ? "Disponível" : "Indisponível";
                    }
                }
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (shooter == null)
            {
                MessageBox.Show("Sem atirador informado para atualizar os dados.");
            }

            else
            {
                using (var db = new ServiceContext())
                {
                    int numAtr = 0;
                    if (numAtrUpBox.Text != "")
                    {
                        numAtr = int.Parse(numAtrUpBox.Text);
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
                    else if (db.Shooters.Where(s => s.warName == warNameBox.Text && warNameBox.Text != shooter.warName).ToList().Count > 0)
                    {
                        MessageBox.Show("Por favor, informe um nome para o atirador que ainda não foi cadastrado no sistema em outro atirador.");
                    }
                    else if ((db.Shooters.Where(s => s.numAtr == numAtr && numAtr != shooter.numAtr).ToList().Count > 0))
                    {
                        MessageBox.Show("Por favor, informe um número para o atirador que ainda não foi cadastrado no sistema.");
                    }
                    else if (numAtr != shooter.numAtr)
                    {
                        MessageBox.Show("Não é possível mudar o número do atirador uma vez cadastrado, se deseja isso favor remover o cadastro do atirador e criar um novo.");
                    }
                    else if (warNameBox.Text != "" && numAtrUpBox.Text != "" && (checkIsCfc.Checked || checkIsNotCfc.Checked) && numServiceBox.Text != "")
                    {
                        bool cfc = false;
                        if (checkIsCfc.Checked)
                        {
                            cfc = true;
                        }

                        shooter.ChangeWarName(warNameBox.Text.Trim());
                        shooter.ChangeIsCfc(cfc);
                        shooter.ChanceNumService(int.Parse(numServiceBox.Text));
                        shooter.sunMorning = sunMorning.Checked;
                        shooter.sunNight = sunNight.Checked;
                        shooter.monMorning = monMorning.Checked;
                        shooter.monNight = monNight.Checked;
                        shooter.tueMorning = tueMorning.Checked;
                        shooter.tueNight = tueNight.Checked;
                        shooter.wedMorning = wedMorning.Checked;
                        shooter.wedNight = wedNight.Checked;
                        shooter.thuMorning = thuMorning.Checked;
                        shooter.thuNight = thuNight.Checked;
                        shooter.friMorning = friMorning.Checked;
                        shooter.friNight = friNight.Checked;
                        shooter.satMorning = satMorning.Checked;
                        shooter.satNight = satNight.Checked;

                        db.Shooters
            .Where(s => s.numAtr == numAtr)
            .ExecuteUpdate(setters => setters
                .SetProperty(s => s.warName, warNameBox.Text.Trim())
                .SetProperty(s => s.isCfc, cfc)
                .SetProperty(s => s.numOfService, int.Parse(numServiceBox.Text))
                .SetProperty(s => s.numServiceExtra, 0)
                .SetProperty(s => s.sunMorning, sunMorning.Checked)
                .SetProperty(s => s.sunNight, sunNight.Checked)
                .SetProperty(s => s.monMorning, monMorning.Checked)
                .SetProperty(s => s.monNight, monNight.Checked)
                .SetProperty(s => s.tueMorning, tueMorning.Checked)
                .SetProperty(s => s.tueNight, tueNight.Checked)
                .SetProperty(s => s.wedMorning, wedMorning.Checked)
                .SetProperty(s => s.wedNight, wedNight.Checked)
                .SetProperty(s => s.thuMorning, thuMorning.Checked)
                .SetProperty(s => s.thuNight, thuNight.Checked)
                .SetProperty(s => s.friMorning, friMorning.Checked)
                .SetProperty(s => s.friNight, friNight.Checked)
                .SetProperty(s => s.satMorning, satMorning.Checked)
                .SetProperty(s => s.satNight, satNight.Checked));

                        db.SaveChanges();

                        if (shooter != null)
                        {
                            table.DataSource = new List<ShooterDT> { new ShooterDT(shooter) };
                        }
                        MessageBox.Show("Os dados do atirador foram atualizados");
                        infoLabel.Text = "Este é o atirador com os dados atualizados";
                        shooter = null;
                        btCadastrar.Visible = false;
                        warNameBox.Visible = false;
                        numAtrUpBox.Visible = false;
                        numServiceBox.Visible = false;
                        isCfcLabel.Visible = false;
                        warNameLabel.Visible = false;
                        numAtrLabel.Visible = false;
                        numServiceLabel.Visible = false;
                        isCfcLabel.Visible = false;
                        checkIsNotCfc.Visible = false;
                        checkIsCfc.Visible = false;

                        disponibleLabel.Visible = false;
                        permaLabel.Visible = false;
                        sentiLabel.Visible = false;
                        sunLabel.Visible = false;
                        sunMorning.Visible = false;
                        sunNight.Visible = false;
                        monLabel.Visible = false;
                        monMorning.Visible = false;
                        monNight.Visible = false;
                        tueLabel.Visible = false;
                        tueMorning.Visible = false;
                        tueNight.Visible = false;

                        wedLabel.Visible = false;
                        wedMorning.Visible = false;
                        wedNight.Visible = false;
                        thuLabel.Visible = false;
                        thuMorning.Visible = false;
                        thuNight.Visible = false;

                        friLabel.Visible = false;
                        friMorning.Visible = false;
                        friNight.Visible = false;
                        satLabel.Visible = false;
                        satMorning.Visible = false;
                        satNight.Visible = false;
                    }
                    else if (warNameBox.Text != "" && numAtrUpBox.Text != "" && (checkIsCfc.Checked || checkIsNotCfc.Checked) && numServiceBox.Text == "")
                    {
                        bool cfc = false;
                        if (checkIsCfc.Checked)
                        {
                            cfc = true;
                        }
                        shooter.ChangeWarName(warNameBox.Text.Trim());
                        shooter.ChangeIsCfc(cfc);
                        shooter.sunMorning = sunMorning.Checked;
                        shooter.sunNight = sunNight.Checked;
                        shooter.monMorning = monMorning.Checked;
                        shooter.monNight = monNight.Checked;
                        shooter.tueMorning = tueMorning.Checked;
                        shooter.tueNight = tueNight.Checked;
                        shooter.wedMorning = wedMorning.Checked;
                        shooter.wedNight = wedNight.Checked;
                        shooter.thuMorning = thuMorning.Checked;
                        shooter.thuNight = thuNight.Checked;
                        shooter.friMorning = friMorning.Checked;
                        shooter.friNight = friNight.Checked;
                        shooter.satMorning = satMorning.Checked;
                        shooter.satNight = satNight.Checked;
                        db.Shooters
            .Where(s => s.numAtr == numAtr)
            .ExecuteUpdate(setters => setters
                .SetProperty(s => s.warName, warNameBox.Text.Trim())
                .SetProperty(s => s.isCfc, cfc)
                .SetProperty(s => s.sunMorning, sunMorning.Checked)
                .SetProperty(s => s.sunNight, sunNight.Checked)
                .SetProperty(s => s.monMorning, monMorning.Checked)
                .SetProperty(s => s.monNight, monNight.Checked)
                .SetProperty(s => s.tueMorning, tueMorning.Checked)
                .SetProperty(s => s.tueNight, tueNight.Checked)
                .SetProperty(s => s.wedMorning, wedMorning.Checked)
                .SetProperty(s => s.wedNight, wedNight.Checked)
                .SetProperty(s => s.thuMorning, thuMorning.Checked)
                .SetProperty(s => s.thuNight, thuNight.Checked)
                .SetProperty(s => s.friMorning, friMorning.Checked)
                .SetProperty(s => s.friNight, friNight.Checked)
                .SetProperty(s => s.satMorning, satMorning.Checked)
                .SetProperty(s => s.satNight, satNight.Checked));

                        db.SaveChanges();
                        if (shooter != null)
                        {
                            table.DataSource = new List<ShooterDT> { new ShooterDT(shooter) };
                        }
                        MessageBox.Show("Os dados do atirador foram atualizados");
                        infoLabel.Text = "Este é o atirador com os dados atualizados";

                        shooter = null;
                        btCadastrar.Visible = false;
                        warNameBox.Visible = false;
                        numAtrUpBox.Visible = false;
                        numServiceBox.Visible = false;
                        isCfcLabel.Visible = false;
                        warNameLabel.Visible = false;
                        numAtrLabel.Visible = false;
                        numServiceLabel.Visible = false;
                        isCfcLabel.Visible = false;
                        checkIsNotCfc.Visible = false;
                        checkIsCfc.Visible = false;

                        disponibleLabel.Visible = false;
                        permaLabel.Visible = false;
                        sentiLabel.Visible = false;
                        sunLabel.Visible = false;
                        sunMorning.Visible = false;
                        sunNight.Visible = false;
                        monLabel.Visible = false;
                        monMorning.Visible = false;
                        monNight.Visible = false;
                        tueLabel.Visible = false;
                        tueMorning.Visible = false;
                        tueNight.Visible = false;

                        wedLabel.Visible = false;
                        wedMorning.Visible = false;
                        wedNight.Visible = false;
                        thuLabel.Visible = false;
                        thuMorning.Visible = false;
                        thuNight.Visible = false;

                        friLabel.Visible = false;
                        friMorning.Visible = false;
                        friNight.Visible = false;
                        satLabel.Visible = false;
                        satMorning.Visible = false;
                        satNight.Visible = false;

                    }
                }
            }
        }
    }
}
