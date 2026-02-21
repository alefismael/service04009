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
            friMorning = new CheckBox();
            thuMorning = new CheckBox();
            thuNight = new CheckBox();
            wedNight = new CheckBox();
            wedMorning = new CheckBox();
            tueMorning = new CheckBox();
            tueNight = new CheckBox();
            monNight = new CheckBox();
            monMorning = new CheckBox();
            sunNight = new CheckBox();
            satMorning = new CheckBox();
            satNight = new CheckBox();
            friNight = new CheckBox();
            table = new DataGridView();
            label6 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1 — Título
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 15);
            label1.Name = "label1";
            label1.Text = "Cadastrar Atirador";
            label1.TabIndex = 0;
            // 
            // label2 — Nome de Guerra
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Text = "Nome de Guerra";
            label2.TabIndex = 1;
            // 
            // warNameBox
            // 
            warNameBox.Location = new Point(25, 90);
            warNameBox.MaxLength = 20;
            warNameBox.Name = "warNameBox";
            warNameBox.PlaceholderText = "Digite aqui";
            warNameBox.Size = new Size(240, 25);
            warNameBox.TabIndex = 2;
            warNameBox.WordWrap = false;
            warNameBox.KeyPress += warNameBox_KeyPress;
            // 
            // label3 — Número do atirador
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 127);
            label3.Name = "label3";
            label3.Text = "Número do atirador";
            label3.TabIndex = 3;
            // 
            // numAtrBox
            // 
            numAtrBox.Location = new Point(25, 152);
            numAtrBox.MaxLength = 4;
            numAtrBox.Name = "numAtrBox";
            numAtrBox.PlaceholderText = "Digite aqui";
            numAtrBox.Size = new Size(160, 25);
            numAtrBox.TabIndex = 4;
            numAtrBox.KeyPress += numAtrBox_KeyPress;
            // 
            // label4 — Número de serviços tirados
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 189);
            label4.Name = "label4";
            label4.Text = "Número de serviços tirados";
            label4.TabIndex = 5;
            // 
            // numServiceBox
            // 
            numServiceBox.Location = new Point(25, 214);
            numServiceBox.MaxLength = 4;
            numServiceBox.Name = "numServiceBox";
            numServiceBox.PlaceholderText = "Digite aqui (opcional)";
            numServiceBox.Size = new Size(200, 25);
            numServiceBox.TabIndex = 6;
            numServiceBox.KeyPress += numServiceBox_KeyPress;
            // 
            // label5 — Faz CFC
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 253);
            label5.Name = "label5";
            label5.Text = "Faz CFC";
            label5.TabIndex = 7;
            // 
            // checkIsNotCfc
            // 
            checkIsNotCfc.Appearance = Appearance.Button;
            checkIsNotCfc.FlatStyle = FlatStyle.Flat;
            checkIsNotCfc.Location = new Point(25, 278);
            checkIsNotCfc.Name = "checkIsNotCfc";
            checkIsNotCfc.Size = new Size(55, 28);
            checkIsNotCfc.Text = "NÃO";
            checkIsNotCfc.TextAlign = ContentAlignment.MiddleCenter;
            checkIsNotCfc.TabIndex = 8;
            checkIsNotCfc.UseVisualStyleBackColor = false;
            checkIsNotCfc.CheckedChanged += checkIsNotCfc_CheckedChanged;
            // 
            // checkIsCfc
            // 
            checkIsCfc.Appearance = Appearance.Button;
            checkIsCfc.FlatStyle = FlatStyle.Flat;
            checkIsCfc.Location = new Point(90, 278);
            checkIsCfc.Name = "checkIsCfc";
            checkIsCfc.Size = new Size(55, 28);
            checkIsCfc.Text = "SIM";
            checkIsCfc.TextAlign = ContentAlignment.MiddleCenter;
            checkIsCfc.TabIndex = 9;
            checkIsCfc.UseVisualStyleBackColor = false;
            checkIsCfc.CheckedChanged += checkIsCfc_CheckedChanged;
            // 
            // label16 — Todos atiradores cadastrados
            // 
            label16.AutoSize = true;
            label16.Location = new Point(310, 65);
            label16.Name = "label16";
            label16.Text = "Todos atiradores cadastrados";
            label16.TabIndex = 10;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeRows = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.EnableHeadersVisualStyles = false;
            table.Location = new Point(310, 90);
            table.MultiSelect = false;
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersVisible = false;
            table.ScrollBars = ScrollBars.Both;
            table.Size = new Size(910, 260);
            table.TabIndex = 11;
            // 
            // label6 — Disponibilidade
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 325);
            label6.Name = "label6";
            label6.Text = "Disponibilidade";
            label6.TabIndex = 12;
            // 
            // label12 — Domingo
            // 
            label12.AutoSize = true;
            label12.Location = new Point(148, 350);
            label12.Name = "label12";
            label12.Text = "Domingo";
            label12.TabIndex = 13;
            // 
            // label13 — Segunda
            // 
            label13.AutoSize = true;
            label13.Location = new Point(263, 350);
            label13.Name = "label13";
            label13.Text = "Segunda";
            label13.TabIndex = 14;
            // 
            // label11 — Terça
            // 
            label11.AutoSize = true;
            label11.Location = new Point(393, 350);
            label11.Name = "label11";
            label11.Text = "Terça";
            label11.TabIndex = 15;
            // 
            // label9 — Quarta
            // 
            label9.AutoSize = true;
            label9.Location = new Point(503, 350);
            label9.Name = "label9";
            label9.Text = "Quarta";
            label9.TabIndex = 16;
            // 
            // label10 — Quinta
            // 
            label10.AutoSize = true;
            label10.Location = new Point(618, 350);
            label10.Name = "label10";
            label10.Text = "Quinta";
            label10.TabIndex = 17;
            // 
            // label15 — Sexta
            // 
            label15.AutoSize = true;
            label15.Location = new Point(738, 350);
            label15.Name = "label15";
            label15.Text = "Sexta";
            label15.TabIndex = 18;
            // 
            // label14 — Sábado
            // 
            label14.AutoSize = true;
            label14.Location = new Point(848, 350);
            label14.Name = "label14";
            label14.Text = "Sábado";
            label14.TabIndex = 19;
            // 
            // label7 — Permanência
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 378);
            label7.Name = "label7";
            label7.Text = "Permanência";
            label7.TabIndex = 20;
            // 
            // sunMorning
            // 
            sunMorning.Appearance = Appearance.Button;
            sunMorning.Checked = true;
            sunMorning.CheckState = CheckState.Checked;
            sunMorning.FlatStyle = FlatStyle.Flat;
            sunMorning.Location = new Point(140, 374);
            sunMorning.Name = "sunMorning";
            sunMorning.Size = new Size(105, 26);
            sunMorning.Text = "Disponível";
            sunMorning.TextAlign = ContentAlignment.MiddleCenter;
            sunMorning.TabIndex = 21;
            sunMorning.UseVisualStyleBackColor = true;
            sunMorning.CheckedChanged += sunMorning_CheckedChanged;
            // 
            // monMorning
            // 
            monMorning.Appearance = Appearance.Button;
            monMorning.Checked = true;
            monMorning.CheckState = CheckState.Checked;
            monMorning.FlatStyle = FlatStyle.Flat;
            monMorning.Location = new Point(255, 374);
            monMorning.Name = "monMorning";
            monMorning.Size = new Size(105, 26);
            monMorning.Text = "Disponível";
            monMorning.TextAlign = ContentAlignment.MiddleCenter;
            monMorning.TabIndex = 22;
            monMorning.UseVisualStyleBackColor = true;
            monMorning.CheckedChanged += monMorning_CheckedChanged;
            // 
            // tueMorning
            // 
            tueMorning.Appearance = Appearance.Button;
            tueMorning.Checked = true;
            tueMorning.CheckState = CheckState.Checked;
            tueMorning.FlatStyle = FlatStyle.Flat;
            tueMorning.Location = new Point(370, 374);
            tueMorning.Name = "tueMorning";
            tueMorning.Size = new Size(105, 26);
            tueMorning.Text = "Disponível";
            tueMorning.TextAlign = ContentAlignment.MiddleCenter;
            tueMorning.TabIndex = 23;
            tueMorning.UseVisualStyleBackColor = true;
            tueMorning.CheckedChanged += tueMorning_CheckedChanged;
            // 
            // wedMorning
            // 
            wedMorning.Appearance = Appearance.Button;
            wedMorning.Checked = true;
            wedMorning.CheckState = CheckState.Checked;
            wedMorning.FlatStyle = FlatStyle.Flat;
            wedMorning.Location = new Point(485, 374);
            wedMorning.Name = "wedMorning";
            wedMorning.Size = new Size(105, 26);
            wedMorning.Text = "Disponível";
            wedMorning.TextAlign = ContentAlignment.MiddleCenter;
            wedMorning.TabIndex = 24;
            wedMorning.UseVisualStyleBackColor = true;
            wedMorning.CheckedChanged += wedMorning_CheckedChanged;
            // 
            // thuMorning
            // 
            thuMorning.Appearance = Appearance.Button;
            thuMorning.Checked = true;
            thuMorning.CheckState = CheckState.Checked;
            thuMorning.FlatStyle = FlatStyle.Flat;
            thuMorning.Location = new Point(600, 374);
            thuMorning.Name = "thuMorning";
            thuMorning.Size = new Size(105, 26);
            thuMorning.Text = "Disponível";
            thuMorning.TextAlign = ContentAlignment.MiddleCenter;
            thuMorning.TabIndex = 25;
            thuMorning.UseVisualStyleBackColor = true;
            thuMorning.CheckedChanged += thuMorning_CheckedChanged;
            // 
            // friMorning
            // 
            friMorning.Appearance = Appearance.Button;
            friMorning.Checked = true;
            friMorning.CheckState = CheckState.Checked;
            friMorning.FlatStyle = FlatStyle.Flat;
            friMorning.Location = new Point(715, 374);
            friMorning.Name = "friMorning";
            friMorning.Size = new Size(105, 26);
            friMorning.Text = "Disponível";
            friMorning.TextAlign = ContentAlignment.MiddleCenter;
            friMorning.TabIndex = 26;
            friMorning.UseVisualStyleBackColor = true;
            friMorning.CheckedChanged += friMorning_CheckedChanged;
            // 
            // satMorning
            // 
            satMorning.Appearance = Appearance.Button;
            satMorning.Checked = true;
            satMorning.CheckState = CheckState.Checked;
            satMorning.FlatStyle = FlatStyle.Flat;
            satMorning.Location = new Point(830, 374);
            satMorning.Name = "satMorning";
            satMorning.Size = new Size(105, 26);
            satMorning.Text = "Disponível";
            satMorning.TextAlign = ContentAlignment.MiddleCenter;
            satMorning.TabIndex = 27;
            satMorning.UseVisualStyleBackColor = true;
            satMorning.CheckedChanged += satMorning_CheckedChanged;
            // 
            // label8 — Sentinela
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 412);
            label8.Name = "label8";
            label8.Text = "Sentinela";
            label8.TabIndex = 28;
            // 
            // sunNight
            // 
            sunNight.Appearance = Appearance.Button;
            sunNight.Checked = true;
            sunNight.CheckState = CheckState.Checked;
            sunNight.FlatStyle = FlatStyle.Flat;
            sunNight.Location = new Point(140, 408);
            sunNight.Name = "sunNight";
            sunNight.Size = new Size(105, 26);
            sunNight.Text = "Disponível";
            sunNight.TextAlign = ContentAlignment.MiddleCenter;
            sunNight.TabIndex = 29;
            sunNight.UseVisualStyleBackColor = true;
            sunNight.CheckedChanged += sunNight_CheckedChanged;
            // 
            // monNight
            // 
            monNight.Appearance = Appearance.Button;
            monNight.Checked = true;
            monNight.CheckState = CheckState.Checked;
            monNight.FlatStyle = FlatStyle.Flat;
            monNight.Location = new Point(255, 408);
            monNight.Name = "monNight";
            monNight.Size = new Size(105, 26);
            monNight.Text = "Disponível";
            monNight.TextAlign = ContentAlignment.MiddleCenter;
            monNight.TabIndex = 30;
            monNight.UseVisualStyleBackColor = true;
            monNight.CheckedChanged += monNight_CheckedChanged;
            // 
            // tueNight
            // 
            tueNight.Appearance = Appearance.Button;
            tueNight.Checked = true;
            tueNight.CheckState = CheckState.Checked;
            tueNight.FlatStyle = FlatStyle.Flat;
            tueNight.Location = new Point(370, 408);
            tueNight.Name = "tueNight";
            tueNight.Size = new Size(105, 26);
            tueNight.Text = "Disponível";
            tueNight.TextAlign = ContentAlignment.MiddleCenter;
            tueNight.TabIndex = 31;
            tueNight.UseVisualStyleBackColor = true;
            tueNight.CheckedChanged += tueNight_CheckedChanged;
            // 
            // wedNight
            // 
            wedNight.Appearance = Appearance.Button;
            wedNight.Checked = true;
            wedNight.CheckState = CheckState.Checked;
            wedNight.FlatStyle = FlatStyle.Flat;
            wedNight.Location = new Point(485, 408);
            wedNight.Name = "wedNight";
            wedNight.Size = new Size(105, 26);
            wedNight.Text = "Disponível";
            wedNight.TextAlign = ContentAlignment.MiddleCenter;
            wedNight.TabIndex = 32;
            wedNight.UseVisualStyleBackColor = true;
            wedNight.CheckedChanged += wedNight_CheckedChanged;
            // 
            // thuNight
            // 
            thuNight.Appearance = Appearance.Button;
            thuNight.Checked = true;
            thuNight.CheckState = CheckState.Checked;
            thuNight.FlatStyle = FlatStyle.Flat;
            thuNight.Location = new Point(600, 408);
            thuNight.Name = "thuNight";
            thuNight.Size = new Size(105, 26);
            thuNight.Text = "Disponível";
            thuNight.TextAlign = ContentAlignment.MiddleCenter;
            thuNight.TabIndex = 33;
            thuNight.UseVisualStyleBackColor = true;
            thuNight.CheckedChanged += thuNight_CheckedChanged;
            // 
            // friNight
            // 
            friNight.Appearance = Appearance.Button;
            friNight.Checked = true;
            friNight.CheckState = CheckState.Checked;
            friNight.FlatStyle = FlatStyle.Flat;
            friNight.Location = new Point(715, 408);
            friNight.Name = "friNight";
            friNight.Size = new Size(105, 26);
            friNight.Text = "Disponível";
            friNight.TextAlign = ContentAlignment.MiddleCenter;
            friNight.TabIndex = 34;
            friNight.UseVisualStyleBackColor = true;
            friNight.CheckedChanged += friNight_CheckedChanged;
            // 
            // satNight
            // 
            satNight.Appearance = Appearance.Button;
            satNight.Checked = true;
            satNight.CheckState = CheckState.Checked;
            satNight.FlatStyle = FlatStyle.Flat;
            satNight.Location = new Point(830, 408);
            satNight.Name = "satNight";
            satNight.Size = new Size(105, 26);
            satNight.Text = "Disponível";
            satNight.TextAlign = ContentAlignment.MiddleCenter;
            satNight.TabIndex = 35;
            satNight.UseVisualStyleBackColor = true;
            satNight.CheckedChanged += satNight_CheckedChanged;
            // 
            // btCadastrar
            // 
            btCadastrar.FlatStyle = FlatStyle.Flat;
            btCadastrar.Location = new Point(25, 455);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(420, 50);
            btCadastrar.Text = "Clique aqui para cadastrar";
            btCadastrar.TabIndex = 36;
            btCadastrar.UseVisualStyleBackColor = false;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // FormAddAtirador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 530);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(warNameBox);
            Controls.Add(label3);
            Controls.Add(numAtrBox);
            Controls.Add(label4);
            Controls.Add(numServiceBox);
            Controls.Add(label5);
            Controls.Add(checkIsNotCfc);
            Controls.Add(checkIsCfc);
            Controls.Add(label16);
            Controls.Add(table);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(sunMorning);
            Controls.Add(monMorning);
            Controls.Add(tueMorning);
            Controls.Add(wedMorning);
            Controls.Add(thuMorning);
            Controls.Add(friMorning);
            Controls.Add(satMorning);
            Controls.Add(label8);
            Controls.Add(sunNight);
            Controls.Add(monNight);
            Controls.Add(tueNight);
            Controls.Add(wedNight);
            Controls.Add(thuNight);
            Controls.Add(friNight);
            Controls.Add(satNight);
            Controls.Add(btCadastrar);
            Name = "FormAddAtirador";
            Text = "FormAddAtirador";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
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
        private CheckBox friMorning;
        private CheckBox thuMorning;
        private CheckBox thuNight;
        private CheckBox wedNight;
        private CheckBox wedMorning;
        private CheckBox tueMorning;
        private CheckBox tueNight;
        private CheckBox monNight;
        private CheckBox monMorning;
        private CheckBox sunNight;
        private CheckBox satMorning;
        private CheckBox satNight;
        private CheckBox friNight;
        private DataGridView table;
        private Label label6;
        private Label label16;
    }
}
