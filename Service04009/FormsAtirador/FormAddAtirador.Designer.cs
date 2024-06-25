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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(415, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 43);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar Atirador";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btCadastrar
            // 
            btCadastrar.AutoSize = true;
            btCadastrar.BackColor = Color.MediumSeaGreen;
            btCadastrar.FlatStyle = FlatStyle.Flat;
            btCadastrar.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrar.Location = new Point(22, 541);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(416, 57);
            btCadastrar.TabIndex = 23;
            btCadastrar.Text = "Clique aqui para cadastrar";
            btCadastrar.UseVisualStyleBackColor = false;
            btCadastrar.Click += btCadastrar_Click;
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
            numServiceBox.PlaceholderText = "Digite aqui (opcional)";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label8.Location = new Point(21, 505);
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
            label7.Location = new Point(23, 469);
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
            label9.Location = new Point(577, 435);
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
            label10.Location = new Point(713, 435);
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
            label11.Location = new Point(444, 435);
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
            label12.Location = new Point(182, 435);
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
            label13.Location = new Point(310, 435);
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
            label14.Location = new Point(988, 435);
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
            label15.Location = new Point(848, 435);
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
            sunMorning.Font = new Font("Segoe UI", 9F);
            sunMorning.Location = new Point(182, 468);
            sunMorning.Name = "sunMorning";
            sunMorning.Size = new Size(104, 23);
            sunMorning.TabIndex = 34;
            sunMorning.Text = "Disponível";
            sunMorning.TextAlign = ContentAlignment.MiddleCenter;
            sunMorning.UseVisualStyleBackColor = true;
            sunMorning.CheckedChanged += sunMorning_CheckedChanged;
            // 
            // friMorning
            // 
            friMorning.Appearance = Appearance.Button;
            friMorning.Checked = true;
            friMorning.CheckState = CheckState.Checked;
            friMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            friMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            friMorning.FlatStyle = FlatStyle.Flat;
            friMorning.Location = new Point(848, 468);
            friMorning.Name = "friMorning";
            friMorning.Size = new Size(104, 23);
            friMorning.TabIndex = 35;
            friMorning.Text = "Disponível";
            friMorning.TextAlign = ContentAlignment.MiddleCenter;
            friMorning.UseVisualStyleBackColor = true;
            friMorning.CheckedChanged += friMorning_CheckedChanged;
            // 
            // thuMorning
            // 
            thuMorning.Appearance = Appearance.Button;
            thuMorning.Checked = true;
            thuMorning.CheckState = CheckState.Checked;
            thuMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            thuMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            thuMorning.FlatStyle = FlatStyle.Flat;
            thuMorning.Location = new Point(713, 468);
            thuMorning.Name = "thuMorning";
            thuMorning.Size = new Size(104, 23);
            thuMorning.TabIndex = 36;
            thuMorning.Text = "Disponível";
            thuMorning.TextAlign = ContentAlignment.MiddleCenter;
            thuMorning.UseVisualStyleBackColor = true;
            thuMorning.CheckedChanged += thuMorning_CheckedChanged;
            // 
            // thuNight
            // 
            thuNight.Appearance = Appearance.Button;
            thuNight.CheckAlign = ContentAlignment.MiddleCenter;
            thuNight.Checked = true;
            thuNight.CheckState = CheckState.Checked;
            thuNight.FlatAppearance.BorderColor = Color.DarkGreen;
            thuNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            thuNight.FlatStyle = FlatStyle.Flat;
            thuNight.Location = new Point(713, 498);
            thuNight.Name = "thuNight";
            thuNight.Size = new Size(104, 23);
            thuNight.TabIndex = 37;
            thuNight.Text = "Disponível";
            thuNight.TextAlign = ContentAlignment.MiddleCenter;
            thuNight.UseVisualStyleBackColor = true;
            thuNight.CheckedChanged += thuNight_CheckedChanged;
            // 
            // wedNight
            // 
            wedNight.Appearance = Appearance.Button;
            wedNight.CheckAlign = ContentAlignment.MiddleCenter;
            wedNight.Checked = true;
            wedNight.CheckState = CheckState.Checked;
            wedNight.FlatAppearance.BorderColor = Color.DarkGreen;
            wedNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            wedNight.FlatStyle = FlatStyle.Flat;
            wedNight.Location = new Point(577, 498);
            wedNight.Name = "wedNight";
            wedNight.Size = new Size(104, 23);
            wedNight.TabIndex = 38;
            wedNight.Text = "Disponível";
            wedNight.TextAlign = ContentAlignment.MiddleCenter;
            wedNight.UseVisualStyleBackColor = true;
            wedNight.CheckedChanged += wedNight_CheckedChanged;
            // 
            // wedMorning
            // 
            wedMorning.Appearance = Appearance.Button;
            wedMorning.CheckAlign = ContentAlignment.MiddleCenter;
            wedMorning.Checked = true;
            wedMorning.CheckState = CheckState.Checked;
            wedMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            wedMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            wedMorning.FlatStyle = FlatStyle.Flat;
            wedMorning.Location = new Point(577, 469);
            wedMorning.Name = "wedMorning";
            wedMorning.Size = new Size(104, 23);
            wedMorning.TabIndex = 39;
            wedMorning.Text = "Disponível";
            wedMorning.TextAlign = ContentAlignment.MiddleCenter;
            wedMorning.UseVisualStyleBackColor = true;
            wedMorning.CheckedChanged += wedMorning_CheckedChanged;
            // 
            // tueMorning
            // 
            tueMorning.Appearance = Appearance.Button;
            tueMorning.CheckAlign = ContentAlignment.MiddleCenter;
            tueMorning.Checked = true;
            tueMorning.CheckState = CheckState.Checked;
            tueMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            tueMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            tueMorning.FlatStyle = FlatStyle.Flat;
            tueMorning.Location = new Point(444, 468);
            tueMorning.Name = "tueMorning";
            tueMorning.Size = new Size(104, 23);
            tueMorning.TabIndex = 40;
            tueMorning.Text = "Disponível";
            tueMorning.TextAlign = ContentAlignment.MiddleCenter;
            tueMorning.UseVisualStyleBackColor = true;
            tueMorning.CheckedChanged += tueMorning_CheckedChanged;
            // 
            // tueNight
            // 
            tueNight.Appearance = Appearance.Button;
            tueNight.CheckAlign = ContentAlignment.MiddleCenter;
            tueNight.Checked = true;
            tueNight.CheckState = CheckState.Checked;
            tueNight.FlatAppearance.BorderColor = Color.DarkGreen;
            tueNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            tueNight.FlatStyle = FlatStyle.Flat;
            tueNight.Location = new Point(444, 501);
            tueNight.Name = "tueNight";
            tueNight.Size = new Size(104, 23);
            tueNight.TabIndex = 41;
            tueNight.Text = "Disponível";
            tueNight.TextAlign = ContentAlignment.MiddleCenter;
            tueNight.UseVisualStyleBackColor = true;
            tueNight.CheckedChanged += tueNight_CheckedChanged;
            // 
            // monNight
            // 
            monNight.Appearance = Appearance.Button;
            monNight.Checked = true;
            monNight.CheckState = CheckState.Checked;
            monNight.FlatAppearance.BorderColor = Color.DarkGreen;
            monNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            monNight.FlatStyle = FlatStyle.Flat;
            monNight.Location = new Point(310, 501);
            monNight.Name = "monNight";
            monNight.Size = new Size(104, 23);
            monNight.TabIndex = 42;
            monNight.Text = "Disponível";
            monNight.TextAlign = ContentAlignment.MiddleCenter;
            monNight.UseVisualStyleBackColor = true;
            monNight.CheckedChanged += monNight_CheckedChanged;
            // 
            // monMorning
            // 
            monMorning.Appearance = Appearance.Button;
            monMorning.Checked = true;
            monMorning.CheckState = CheckState.Checked;
            monMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            monMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            monMorning.FlatStyle = FlatStyle.Flat;
            monMorning.Location = new Point(310, 468);
            monMorning.Name = "monMorning";
            monMorning.Size = new Size(104, 23);
            monMorning.TabIndex = 43;
            monMorning.Text = "Disponível";
            monMorning.TextAlign = ContentAlignment.MiddleCenter;
            monMorning.UseVisualStyleBackColor = true;
            monMorning.CheckedChanged += monMorning_CheckedChanged;
            // 
            // sunNight
            // 
            sunNight.Appearance = Appearance.Button;
            sunNight.Checked = true;
            sunNight.CheckState = CheckState.Checked;
            sunNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            sunNight.FlatStyle = FlatStyle.Flat;
            sunNight.Location = new Point(182, 501);
            sunNight.Name = "sunNight";
            sunNight.Size = new Size(104, 23);
            sunNight.TabIndex = 44;
            sunNight.Text = "Disponível";
            sunNight.TextAlign = ContentAlignment.MiddleCenter;
            sunNight.UseVisualStyleBackColor = true;
            sunNight.CheckedChanged += sunNight_CheckedChanged;
            // 
            // satMorning
            // 
            satMorning.Appearance = Appearance.Button;
            satMorning.Checked = true;
            satMorning.CheckState = CheckState.Checked;
            satMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            satMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            satMorning.FlatStyle = FlatStyle.Flat;
            satMorning.Location = new Point(988, 469);
            satMorning.Name = "satMorning";
            satMorning.Size = new Size(104, 23);
            satMorning.TabIndex = 45;
            satMorning.Text = "Disponível";
            satMorning.TextAlign = ContentAlignment.MiddleCenter;
            satMorning.UseVisualStyleBackColor = true;
            satMorning.CheckedChanged += satMorning_CheckedChanged;
            // 
            // satNight
            // 
            satNight.Appearance = Appearance.Button;
            satNight.Checked = true;
            satNight.CheckState = CheckState.Checked;
            satNight.FlatAppearance.BorderColor = Color.DarkGreen;
            satNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            satNight.FlatStyle = FlatStyle.Flat;
            satNight.Location = new Point(988, 498);
            satNight.Name = "satNight";
            satNight.Size = new Size(104, 23);
            satNight.TabIndex = 46;
            satNight.Text = "Disponível";
            satNight.TextAlign = ContentAlignment.MiddleCenter;
            satNight.UseVisualStyleBackColor = true;
            satNight.CheckedChanged += satNight_CheckedChanged;
            // 
            // friNight
            // 
            friNight.Appearance = Appearance.Button;
            friNight.Checked = true;
            friNight.CheckState = CheckState.Checked;
            friNight.FlatAppearance.BorderColor = Color.DarkGreen;
            friNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            friNight.FlatStyle = FlatStyle.Flat;
            friNight.Location = new Point(848, 498);
            friNight.Name = "friNight";
            friNight.Size = new Size(104, 23);
            friNight.TabIndex = 47;
            friNight.Text = "Disponível";
            friNight.TextAlign = ContentAlignment.MiddleCenter;
            friNight.UseVisualStyleBackColor = true;
            friNight.CheckedChanged += friNight_CheckedChanged;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeColumns = false;
            table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            table.Anchor = AnchorStyles.None;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            table.BackgroundColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            table.DefaultCellStyle = dataGridViewCellStyle3;
            table.EnableHeadersVisualStyles = false;
            table.GridColor = Color.DarkGreen;
            table.Location = new Point(320, 135);
            table.MultiSelect = false;
            table.Name = "table";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            table.RowHeadersVisible = false;
            table.Size = new Size(781, 263);
            table.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGreen;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label6.Location = new Point(22, 405);
            label6.Name = "label6";
            label6.Padding = new Padding(25, 0, 25, 0);
            label6.Size = new Size(194, 19);
            label6.TabIndex = 24;
            label6.Text = "Disponibilidade";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkGreen;
            label16.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(705, 97);
            label16.Name = "label16";
            label16.Padding = new Padding(25, 0, 25, 0);
            label16.Size = new Size(396, 24);
            label16.TabIndex = 49;
            label16.Text = "Todos atiradores cadastrados";
            // 
            // FormAddAtirador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_fundo_service_04009;
            ClientSize = new Size(1248, 610);
            Controls.Add(label16);
            Controls.Add(table);
            Controls.Add(friNight);
            Controls.Add(satNight);
            Controls.Add(satMorning);
            Controls.Add(sunNight);
            Controls.Add(monMorning);
            Controls.Add(monNight);
            Controls.Add(tueNight);
            Controls.Add(tueMorning);
            Controls.Add(wedMorning);
            Controls.Add(wedNight);
            Controls.Add(thuNight);
            Controls.Add(thuMorning);
            Controls.Add(friMorning);
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