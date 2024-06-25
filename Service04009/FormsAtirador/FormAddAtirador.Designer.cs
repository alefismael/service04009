namespace Service04009.FormsAtirador
{
    partial class FormAddAtirador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btCadastrar = new Button();
            checkIsCfc = new CheckBox();
            checkIsNotCfc = new CheckBox();
            label5 = new Label();
            numServiceBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            numAtrBox = new TextBox();
            label2 = new Label();
            warNameBox = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            sunMorning = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(425, 36);
            label1.Name = "label1";
            label1.Size = new Size(343, 39);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar Atirador";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(25, 519);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(122, 42);
            btCadastrar.TabIndex = 23;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            // 
            // checkIsCfc
            // 
            checkIsCfc.Appearance = Appearance.Button;
            checkIsCfc.AutoSize = true;
            checkIsCfc.BackColor = Color.White;
            checkIsCfc.FlatAppearance.BorderColor = Color.Black;
            checkIsCfc.FlatAppearance.CheckedBackColor = Color.DarkGreen;
            checkIsCfc.FlatStyle = FlatStyle.Flat;
            checkIsCfc.Location = new Point(110, 298);
            checkIsCfc.Name = "checkIsCfc";
            checkIsCfc.Size = new Size(37, 25);
            checkIsCfc.TabIndex = 22;
            checkIsCfc.Text = "SIM";
            checkIsCfc.UseVisualStyleBackColor = false;
            checkIsCfc.CheckedChanged += checkIsCfc_CheckedChanged;
            // 
            // checkIsNotCfc
            // 
            checkIsNotCfc.Appearance = Appearance.Button;
            checkIsNotCfc.AutoSize = true;
            checkIsNotCfc.BackColor = Color.White;
            checkIsNotCfc.FlatAppearance.BorderColor = Color.Black;
            checkIsNotCfc.FlatAppearance.CheckedBackColor = Color.DarkGreen;
            checkIsNotCfc.FlatStyle = FlatStyle.Flat;
            checkIsNotCfc.Location = new Point(25, 298);
            checkIsNotCfc.Name = "checkIsNotCfc";
            checkIsNotCfc.Size = new Size(43, 25);
            checkIsNotCfc.TabIndex = 21;
            checkIsNotCfc.Text = "NÃO";
            checkIsNotCfc.UseVisualStyleBackColor = false;
            checkIsNotCfc.CheckedChanged += checkIsNotCfc_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGreen;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label5.Location = new Point(25, 276);
            label5.Name = "label5";
            label5.Padding = new Padding(25, 0, 25, 0);
            label5.Size = new Size(122, 19);
            label5.TabIndex = 20;
            label5.Text = "Faz CFC";
            // 
            // numServiceBox
            // 
            numServiceBox.Location = new Point(25, 238);
            numServiceBox.MaxLength = 4;
            numServiceBox.Name = "numServiceBox";
            numServiceBox.PlaceholderText = "Digite aqui";
            numServiceBox.Size = new Size(152, 23);
            numServiceBox.TabIndex = 19;
            numServiceBox.KeyPress += numServiceBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 216);
            label4.Name = "label4";
            label4.Size = new Size(243, 19);
            label4.TabIndex = 18;
            label4.Text = "Número de serviços tirados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 159);
            label3.Name = "label3";
            label3.Size = new Size(171, 19);
            label3.TabIndex = 17;
            label3.Text = "Número do atirador";
            // 
            // numAtrBox
            // 
            numAtrBox.Location = new Point(25, 181);
            numAtrBox.MaxLength = 4;
            numAtrBox.Name = "numAtrBox";
            numAtrBox.PlaceholderText = "Digite aqui";
            numAtrBox.Size = new Size(112, 23);
            numAtrBox.TabIndex = 16;
            numAtrBox.KeyPress += numAtrBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 97);
            label2.Name = "label2";
            label2.Padding = new Padding(28, 0, 28, 0);
            label2.Size = new Size(191, 19);
            label2.TabIndex = 15;
            label2.Text = "Nome de Guerra";
            // 
            // warNameBox
            // 
            warNameBox.Location = new Point(25, 119);
            warNameBox.MaxLength = 20;
            warNameBox.Name = "warNameBox";
            warNameBox.PlaceholderText = "Digite aqui";
            warNameBox.Size = new Size(191, 23);
            warNameBox.TabIndex = 14;
            warNameBox.WordWrap = false;
            warNameBox.KeyPress += warNameBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGreen;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label6.Location = new Point(25, 345);
            label6.Name = "label6";
            label6.Padding = new Padding(25, 0, 25, 0);
            label6.Size = new Size(194, 19);
            label6.TabIndex = 24;
            label6.Text = "Disponibilidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label8.Location = new Point(25, 435);
            label8.Name = "label8";
            label8.Padding = new Padding(25, 0, 25, 0);
            label8.Size = new Size(140, 19);
            label8.TabIndex = 26;
            label8.Text = "Sentinela";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label7.Location = new Point(25, 405);
            label7.Name = "label7";
            label7.Padding = new Padding(25, 0, 5, 0);
            label7.Size = new Size(138, 19);
            label7.TabIndex = 25;
            label7.Text = "Permanência";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 255, 192);
            label9.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label9.Location = new Point(588, 377);
            label9.Name = "label9";
            label9.Padding = new Padding(25, 0, 25, 0);
            label9.Size = new Size(113, 19);
            label9.TabIndex = 27;
            label9.Text = "Quarta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(192, 255, 192);
            label10.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label10.Location = new Point(725, 377);
            label10.Name = "label10";
            label10.Padding = new Padding(25, 0, 25, 0);
            label10.Size = new Size(113, 19);
            label10.TabIndex = 28;
            label10.Text = "Quinta";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 255, 192);
            label11.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label11.Location = new Point(444, 377);
            label11.Name = "label11";
            label11.Padding = new Padding(25, 0, 25, 0);
            label11.Size = new Size(104, 19);
            label11.TabIndex = 29;
            label11.Text = "Terça";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(192, 255, 192);
            label12.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label12.Location = new Point(185, 377);
            label12.Name = "label12";
            label12.Padding = new Padding(25, 0, 25, 0);
            label12.Size = new Size(122, 19);
            label12.TabIndex = 30;
            label12.Text = "Domingo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 192);
            label13.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label13.Location = new Point(310, 377);
            label13.Name = "label13";
            label13.Padding = new Padding(25, 0, 25, 0);
            label13.Size = new Size(122, 19);
            label13.TabIndex = 31;
            label13.Text = "Segunda";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(192, 255, 192);
            label14.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label14.Location = new Point(1014, 377);
            label14.Name = "label14";
            label14.Padding = new Padding(25, 0, 25, 0);
            label14.Size = new Size(113, 19);
            label14.TabIndex = 32;
            label14.Text = "Sábado";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(192, 255, 192);
            label15.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label15.Location = new Point(880, 377);
            label15.Name = "label15";
            label15.Padding = new Padding(25, 0, 25, 0);
            label15.Size = new Size(104, 19);
            label15.TabIndex = 33;
            label15.Text = "Sexta";
            // 
            // sunMorning
            // 
            sunMorning.Appearance = Appearance.Button;
            sunMorning.Checked = true;
            sunMorning.CheckState = CheckState.Checked;
            sunMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            sunMorning.FlatStyle = FlatStyle.Flat;
            sunMorning.Location = new Point(185, 405);
            sunMorning.Name = "sunMorning";
            sunMorning.Size = new Size(104, 23);
            sunMorning.TabIndex = 34;
            sunMorning.Text = "Disponível";
            sunMorning.UseVisualStyleBackColor = true;
            sunMorning.CheckedChanged += sunMorning_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.Appearance = Appearance.Button;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox2.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Location = new Point(880, 405);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 23);
            checkBox2.TabIndex = 35;
            checkBox2.Text = "Disponível";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Appearance = Appearance.Button;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox3.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Location = new Point(725, 405);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(104, 23);
            checkBox3.TabIndex = 36;
            checkBox3.Text = "Disponível";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.Appearance = Appearance.Button;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox4.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Location = new Point(725, 430);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(104, 23);
            checkBox4.TabIndex = 37;
            checkBox4.Text = "Disponível";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.Appearance = Appearance.Button;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox5.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.Location = new Point(588, 430);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(104, 23);
            checkBox5.TabIndex = 38;
            checkBox5.Text = "Disponível";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.Appearance = Appearance.Button;
            checkBox6.Checked = true;
            checkBox6.CheckState = CheckState.Checked;
            checkBox6.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox6.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox6.FlatStyle = FlatStyle.Flat;
            checkBox6.Location = new Point(588, 405);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(104, 23);
            checkBox6.TabIndex = 39;
            checkBox6.Text = "Disponível";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.Appearance = Appearance.Button;
            checkBox7.Checked = true;
            checkBox7.CheckState = CheckState.Checked;
            checkBox7.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox7.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox7.FlatStyle = FlatStyle.Flat;
            checkBox7.Location = new Point(444, 405);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(104, 23);
            checkBox7.TabIndex = 40;
            checkBox7.Text = "Disponível";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.Appearance = Appearance.Button;
            checkBox8.Checked = true;
            checkBox8.CheckState = CheckState.Checked;
            checkBox8.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox8.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox8.FlatStyle = FlatStyle.Flat;
            checkBox8.Location = new Point(444, 431);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(104, 23);
            checkBox8.TabIndex = 41;
            checkBox8.Text = "Disponível";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.Appearance = Appearance.Button;
            checkBox9.Checked = true;
            checkBox9.CheckState = CheckState.Checked;
            checkBox9.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox9.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox9.FlatStyle = FlatStyle.Flat;
            checkBox9.Location = new Point(310, 431);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(104, 23);
            checkBox9.TabIndex = 42;
            checkBox9.Text = "Disponível";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.Appearance = Appearance.Button;
            checkBox10.Checked = true;
            checkBox10.CheckState = CheckState.Checked;
            checkBox10.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox10.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox10.FlatStyle = FlatStyle.Flat;
            checkBox10.Location = new Point(310, 405);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(104, 23);
            checkBox10.TabIndex = 43;
            checkBox10.Text = "Disponível";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.Appearance = Appearance.Button;
            checkBox11.Checked = true;
            checkBox11.CheckState = CheckState.Checked;
            checkBox11.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox11.FlatStyle = FlatStyle.Flat;
            checkBox11.Location = new Point(185, 430);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(104, 23);
            checkBox11.TabIndex = 44;
            checkBox11.Text = "Disponível";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.Appearance = Appearance.Button;
            checkBox12.Checked = true;
            checkBox12.CheckState = CheckState.Checked;
            checkBox12.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox12.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox12.FlatStyle = FlatStyle.Flat;
            checkBox12.Location = new Point(1014, 405);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(104, 23);
            checkBox12.TabIndex = 45;
            checkBox12.Text = "Disponível";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.Appearance = Appearance.Button;
            checkBox13.Checked = true;
            checkBox13.CheckState = CheckState.Checked;
            checkBox13.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox13.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox13.FlatStyle = FlatStyle.Flat;
            checkBox13.Location = new Point(1014, 430);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(104, 23);
            checkBox13.TabIndex = 46;
            checkBox13.Text = "Disponível";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.Appearance = Appearance.Button;
            checkBox14.Checked = true;
            checkBox14.CheckState = CheckState.Checked;
            checkBox14.FlatAppearance.BorderColor = Color.DarkGreen;
            checkBox14.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            checkBox14.FlatStyle = FlatStyle.Flat;
            checkBox14.Location = new Point(880, 430);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(104, 23);
            checkBox14.TabIndex = 47;
            checkBox14.Text = "Disponível";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // FormAddAtirador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_fundo_service_04009;
            ClientSize = new Size(1248, 610);
            Controls.Add(checkBox14);
            Controls.Add(checkBox13);
            Controls.Add(checkBox12);
            Controls.Add(checkBox11);
            Controls.Add(checkBox10);
            Controls.Add(checkBox9);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(sunMorning);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label6);
            Controls.Add(btCadastrar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkIsCfc);
            Controls.Add(checkIsNotCfc);
            Controls.Add(label5);
            Controls.Add(numServiceBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numAtrBox);
            Controls.Add(label2);
            Controls.Add(warNameBox);
            Controls.Add(label1);
            Name = "FormAddAtirador";
            Text = "FormAddAtirador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btCadastrar;
        private CheckBox checkIsCfc;
        private CheckBox checkIsNotCfc;
        private Label label5;
        private TextBox numServiceBox;
        private Label label4;
        private Label label3;
        private TextBox numAtrBox;
        private Label label2;
        private TextBox warNameBox;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private CheckBox sunMorning;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
    }
}