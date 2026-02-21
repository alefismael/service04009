namespace Service04009.FormsAtirador
{
    partial class FormUpdateByName
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
            table = new DataGridView();
            infoLabel = new Label();
            label3 = new Label();
            nameQueryBox = new TextBox();
            btCadastrar = new Button();
            warNameLabel = new Label();
            warNameBox = new TextBox();
            numAtrLabel = new Label();
            numAtrUpBox = new TextBox();
            numServiceLabel = new Label();
            numServiceBox = new TextBox();
            isCfcLabel = new Label();
            checkIsNotCfc = new CheckBox();
            checkIsCfc = new CheckBox();
            disponibleLabel = new Label();
            permaLabel = new Label();
            sentiLabel = new Label();
            sunLabel = new Label();
            monLabel = new Label();
            tueLabel = new Label();
            wedLabel = new Label();
            thuLabel = new Label();
            friLabel = new Label();
            satLabel = new Label();
            sunMorning = new CheckBox();
            sunNight = new CheckBox();
            monMorning = new CheckBox();
            monNight = new CheckBox();
            tueMorning = new CheckBox();
            tueNight = new CheckBox();
            wedMorning = new CheckBox();
            wedNight = new CheckBox();
            thuMorning = new CheckBox();
            thuNight = new CheckBox();
            friMorning = new CheckBox();
            friNight = new CheckBox();
            satMorning = new CheckBox();
            satNight = new CheckBox();
            btQuery = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 45);
            label1.Name = "label1";
            label1.Size = new Size(894, 43);
            label1.TabIndex = 2;
            label1.Text = "Atualizar dados do atirador por nome de guerra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            table.Location = new Point(487, 164);
            table.Margin = new Padding(3, 0, 3, 3);
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
            table.Size = new Size(715, 67);
            table.TabIndex = 49;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = Color.Red;
            infoLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoLabel.Location = new Point(523, 140);
            infoLabel.Name = "infoLabel";
            infoLabel.Padding = new Padding(25, 0, 25, 0);
            infoLabel.Size = new Size(612, 24);
            infoLabel.TabIndex = 50;
            infoLabel.Text = "Sem atirador informado para atualizar os dados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(31, 148);
            label3.Name = "label3";
            label3.Size = new Size(288, 19);
            label3.TabIndex = 51;
            label3.Text = "Nome do atirador para atualizar";
            // 
            // nameQueryBox
            // 
            nameQueryBox.Location = new Point(31, 181);
            nameQueryBox.MaxLength = 20;
            nameQueryBox.Name = "nameQueryBox";
            nameQueryBox.PlaceholderText = "Digite aqui o número do atirador para atualizar dados";
            nameQueryBox.Size = new Size(337, 23);
            nameQueryBox.TabIndex = 52;
            nameQueryBox.KeyPress += nameQueryBox_KeyPress;
            // 
            // btCadastrar
            // 
            btCadastrar.AutoSize = true;
            btCadastrar.BackColor = Color.MediumSeaGreen;
            btCadastrar.FlatStyle = FlatStyle.Flat;
            btCadastrar.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrar.Location = new Point(293, 522);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(731, 57);
            btCadastrar.TabIndex = 53;
            btCadastrar.Text = "Clique aqui para atualizar os dados do atirador";
            btCadastrar.UseVisualStyleBackColor = false;
            btCadastrar.Visible = false;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // warNameLabel
            // 
            warNameLabel.AutoSize = true;
            warNameLabel.BackColor = Color.DarkGreen;
            warNameLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            warNameLabel.Location = new Point(31, 302);
            warNameLabel.Name = "warNameLabel";
            warNameLabel.Padding = new Padding(28, 0, 28, 0);
            warNameLabel.Size = new Size(191, 19);
            warNameLabel.TabIndex = 54;
            warNameLabel.Text = "Nome de Guerra";
            warNameLabel.Visible = false;
            // 
            // warNameBox
            // 
            warNameBox.Location = new Point(31, 324);
            warNameBox.MaxLength = 20;
            warNameBox.Name = "warNameBox";
            warNameBox.PlaceholderText = "Digite aqui";
            warNameBox.Size = new Size(191, 23);
            warNameBox.TabIndex = 55;
            warNameBox.Visible = false;
            warNameBox.WordWrap = false;
            warNameBox.KeyPress += warNameBox_KeyPress;
            // 
            // numAtrLabel
            // 
            numAtrLabel.AutoSize = true;
            numAtrLabel.BackColor = Color.DarkGreen;
            numAtrLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            numAtrLabel.Location = new Point(304, 302);
            numAtrLabel.Name = "numAtrLabel";
            numAtrLabel.Size = new Size(171, 19);
            numAtrLabel.TabIndex = 56;
            numAtrLabel.Text = "Número do atirador";
            numAtrLabel.Visible = false;
            // 
            // numAtrUpBox
            // 
            numAtrUpBox.Location = new Point(304, 324);
            numAtrUpBox.MaxLength = 4;
            numAtrUpBox.Name = "numAtrUpBox";
            numAtrUpBox.PlaceholderText = "Digite aqui";
            numAtrUpBox.Size = new Size(112, 23);
            numAtrUpBox.TabIndex = 57;
            numAtrUpBox.Visible = false;
            numAtrUpBox.KeyPress += numAtrUpBox_KeyPress;
            // 
            // numServiceLabel
            // 
            numServiceLabel.AutoSize = true;
            numServiceLabel.BackColor = Color.DarkGreen;
            numServiceLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            numServiceLabel.Location = new Point(596, 302);
            numServiceLabel.Name = "numServiceLabel";
            numServiceLabel.Size = new Size(243, 19);
            numServiceLabel.TabIndex = 58;
            numServiceLabel.Text = "Número de serviços tirados";
            numServiceLabel.Visible = false;
            // 
            // numServiceBox
            // 
            numServiceBox.Location = new Point(596, 324);
            numServiceBox.MaxLength = 4;
            numServiceBox.Name = "numServiceBox";
            numServiceBox.PlaceholderText = "Digite aqui (opcional)";
            numServiceBox.Size = new Size(152, 23);
            numServiceBox.TabIndex = 59;
            numServiceBox.Visible = false;
            numServiceBox.KeyPress += numServiceBox_KeyPress;
            // 
            // isCfcLabel
            // 
            isCfcLabel.AutoSize = true;
            isCfcLabel.BackColor = Color.DarkGreen;
            isCfcLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            isCfcLabel.Location = new Point(967, 300);
            isCfcLabel.Name = "isCfcLabel";
            isCfcLabel.Padding = new Padding(25, 0, 25, 0);
            isCfcLabel.Size = new Size(122, 19);
            isCfcLabel.TabIndex = 60;
            isCfcLabel.Text = "Faz CFC";
            isCfcLabel.Visible = false;
            // 
            // checkIsNotCfc
            // 
            checkIsNotCfc.Appearance = Appearance.Button;
            checkIsNotCfc.AutoSize = true;
            checkIsNotCfc.BackColor = Color.White;
            checkIsNotCfc.FlatAppearance.BorderColor = Color.Black;
            checkIsNotCfc.FlatAppearance.CheckedBackColor = Color.DarkGreen;
            checkIsNotCfc.FlatStyle = FlatStyle.Flat;
            checkIsNotCfc.Location = new Point(969, 324);
            checkIsNotCfc.Name = "checkIsNotCfc";
            checkIsNotCfc.Size = new Size(43, 25);
            checkIsNotCfc.TabIndex = 61;
            checkIsNotCfc.Text = "NÃO";
            checkIsNotCfc.UseVisualStyleBackColor = false;
            checkIsNotCfc.Visible = false;
            checkIsNotCfc.CheckedChanged += checkIsNotCfc_CheckedChanged;
            // 
            // checkIsCfc
            // 
            checkIsCfc.Appearance = Appearance.Button;
            checkIsCfc.AutoSize = true;
            checkIsCfc.BackColor = Color.White;
            checkIsCfc.FlatAppearance.BorderColor = Color.Black;
            checkIsCfc.FlatAppearance.CheckedBackColor = Color.DarkGreen;
            checkIsCfc.FlatStyle = FlatStyle.Flat;
            checkIsCfc.Location = new Point(1052, 322);
            checkIsCfc.Name = "checkIsCfc";
            checkIsCfc.Size = new Size(37, 25);
            checkIsCfc.TabIndex = 62;
            checkIsCfc.Text = "SIM";
            checkIsCfc.UseVisualStyleBackColor = false;
            checkIsCfc.Visible = false;
            checkIsCfc.CheckedChanged += checkIsCfc_CheckedChanged;
            // 
            // disponibleLabel
            // 
            disponibleLabel.AutoSize = true;
            disponibleLabel.BackColor = Color.DarkGreen;
            disponibleLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            disponibleLabel.Location = new Point(31, 376);
            disponibleLabel.Name = "disponibleLabel";
            disponibleLabel.Padding = new Padding(25, 0, 25, 0);
            disponibleLabel.Size = new Size(194, 19);
            disponibleLabel.TabIndex = 63;
            disponibleLabel.Text = "Disponibilidade";
            disponibleLabel.Visible = false;
            // 
            // permaLabel
            // 
            permaLabel.AutoSize = true;
            permaLabel.BackColor = Color.FromArgb(192, 255, 192);
            permaLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            permaLabel.Location = new Point(31, 435);
            permaLabel.Name = "permaLabel";
            permaLabel.Padding = new Padding(25, 0, 5, 0);
            permaLabel.Size = new Size(138, 19);
            permaLabel.TabIndex = 64;
            permaLabel.Text = "Permanência";
            permaLabel.Visible = false;
            // 
            // sentiLabel
            // 
            sentiLabel.AutoSize = true;
            sentiLabel.BackColor = Color.FromArgb(192, 255, 192);
            sentiLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            sentiLabel.Location = new Point(31, 469);
            sentiLabel.Name = "sentiLabel";
            sentiLabel.Padding = new Padding(25, 0, 25, 0);
            sentiLabel.Size = new Size(140, 19);
            sentiLabel.TabIndex = 65;
            sentiLabel.Text = "Sentinela";
            sentiLabel.Visible = false;
            // 
            // sunLabel
            // 
            sunLabel.AutoSize = true;
            sunLabel.BackColor = Color.FromArgb(192, 255, 192);
            sunLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            sunLabel.Location = new Point(191, 410);
            sunLabel.Name = "sunLabel";
            sunLabel.Padding = new Padding(25, 0, 25, 0);
            sunLabel.Size = new Size(122, 19);
            sunLabel.TabIndex = 66;
            sunLabel.Text = "Domingo";
            sunLabel.Visible = false;
            // 
            // monLabel
            // 
            monLabel.AutoSize = true;
            monLabel.BackColor = Color.FromArgb(192, 255, 192);
            monLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            monLabel.Location = new Point(342, 410);
            monLabel.Name = "monLabel";
            monLabel.Padding = new Padding(25, 0, 25, 0);
            monLabel.Size = new Size(122, 19);
            monLabel.TabIndex = 67;
            monLabel.Text = "Segunda";
            monLabel.Visible = false;
            // 
            // tueLabel
            // 
            tueLabel.AutoSize = true;
            tueLabel.BackColor = Color.FromArgb(192, 255, 192);
            tueLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            tueLabel.Location = new Point(487, 410);
            tueLabel.Name = "tueLabel";
            tueLabel.Padding = new Padding(25, 0, 25, 0);
            tueLabel.Size = new Size(104, 19);
            tueLabel.TabIndex = 68;
            tueLabel.Text = "Terça";
            tueLabel.Visible = false;
            // 
            // wedLabel
            // 
            wedLabel.AutoSize = true;
            wedLabel.BackColor = Color.FromArgb(192, 255, 192);
            wedLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            wedLabel.Location = new Point(617, 410);
            wedLabel.Name = "wedLabel";
            wedLabel.Padding = new Padding(25, 0, 25, 0);
            wedLabel.Size = new Size(113, 19);
            wedLabel.TabIndex = 69;
            wedLabel.Text = "Quarta";
            wedLabel.Visible = false;
            // 
            // thuLabel
            // 
            thuLabel.AutoSize = true;
            thuLabel.BackColor = Color.FromArgb(192, 255, 192);
            thuLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            thuLabel.Location = new Point(766, 410);
            thuLabel.Name = "thuLabel";
            thuLabel.Padding = new Padding(25, 0, 25, 0);
            thuLabel.Size = new Size(113, 19);
            thuLabel.TabIndex = 70;
            thuLabel.Text = "Quinta";
            thuLabel.Visible = false;
            // 
            // friLabel
            // 
            friLabel.AutoSize = true;
            friLabel.BackColor = Color.FromArgb(192, 255, 192);
            friLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            friLabel.Location = new Point(908, 410);
            friLabel.Name = "friLabel";
            friLabel.Padding = new Padding(25, 0, 25, 0);
            friLabel.Size = new Size(104, 19);
            friLabel.TabIndex = 71;
            friLabel.Text = "Sexta";
            friLabel.Visible = false;
            // 
            // satLabel
            // 
            satLabel.AutoSize = true;
            satLabel.BackColor = Color.FromArgb(192, 255, 192);
            satLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            satLabel.Location = new Point(1047, 410);
            satLabel.Name = "satLabel";
            satLabel.Padding = new Padding(25, 0, 25, 0);
            satLabel.Size = new Size(113, 19);
            satLabel.TabIndex = 72;
            satLabel.Text = "Sábado";
            satLabel.Visible = false;
            // 
            // sunMorning
            // 
            sunMorning.Appearance = Appearance.Button;
            sunMorning.Checked = true;
            sunMorning.CheckState = CheckState.Checked;
            sunMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            sunMorning.FlatStyle = FlatStyle.Flat;
            sunMorning.Font = new Font("Segoe UI", 9F);
            sunMorning.Location = new Point(191, 435);
            sunMorning.Name = "sunMorning";
            sunMorning.Size = new Size(104, 23);
            sunMorning.TabIndex = 73;
            sunMorning.Text = "Disponível";
            sunMorning.TextAlign = ContentAlignment.MiddleCenter;
            sunMorning.UseVisualStyleBackColor = true;
            sunMorning.Visible = false;
            sunMorning.CheckedChanged += sunMorning_CheckedChanged;
            // 
            // sunNight
            // 
            sunNight.Appearance = Appearance.Button;
            sunNight.Checked = true;
            sunNight.CheckState = CheckState.Checked;
            sunNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            sunNight.FlatStyle = FlatStyle.Flat;
            sunNight.Location = new Point(191, 464);
            sunNight.Name = "sunNight";
            sunNight.Size = new Size(104, 23);
            sunNight.TabIndex = 74;
            sunNight.Text = "Disponível";
            sunNight.TextAlign = ContentAlignment.MiddleCenter;
            sunNight.UseVisualStyleBackColor = true;
            sunNight.Visible = false;
            sunNight.CheckedChanged += sunNight_CheckedChanged;
            // 
            // monMorning
            // 
            monMorning.Appearance = Appearance.Button;
            monMorning.Checked = true;
            monMorning.CheckState = CheckState.Checked;
            monMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            monMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            monMorning.FlatStyle = FlatStyle.Flat;
            monMorning.Location = new Point(342, 435);
            monMorning.Name = "monMorning";
            monMorning.Size = new Size(104, 23);
            monMorning.TabIndex = 75;
            monMorning.Text = "Disponível";
            monMorning.TextAlign = ContentAlignment.MiddleCenter;
            monMorning.UseVisualStyleBackColor = true;
            monMorning.Visible = false;
            monMorning.CheckedChanged += monMorning_CheckedChanged;
            // 
            // monNight
            // 
            monNight.Appearance = Appearance.Button;
            monNight.Checked = true;
            monNight.CheckState = CheckState.Checked;
            monNight.FlatAppearance.BorderColor = Color.DarkGreen;
            monNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            monNight.FlatStyle = FlatStyle.Flat;
            monNight.Location = new Point(342, 464);
            monNight.Name = "monNight";
            monNight.Size = new Size(104, 23);
            monNight.TabIndex = 76;
            monNight.Text = "Disponível";
            monNight.TextAlign = ContentAlignment.MiddleCenter;
            monNight.UseVisualStyleBackColor = true;
            monNight.Visible = false;
            monNight.CheckedChanged += monNight_CheckedChanged;
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
            tueMorning.Location = new Point(487, 435);
            tueMorning.Name = "tueMorning";
            tueMorning.Size = new Size(104, 23);
            tueMorning.TabIndex = 77;
            tueMorning.Text = "Disponível";
            tueMorning.TextAlign = ContentAlignment.MiddleCenter;
            tueMorning.UseVisualStyleBackColor = true;
            tueMorning.Visible = false;
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
            tueNight.Location = new Point(487, 464);
            tueNight.Name = "tueNight";
            tueNight.Size = new Size(104, 23);
            tueNight.TabIndex = 78;
            tueNight.Text = "Disponível";
            tueNight.TextAlign = ContentAlignment.MiddleCenter;
            tueNight.UseVisualStyleBackColor = true;
            tueNight.Visible = false;
            tueNight.CheckedChanged += tueNight_CheckedChanged;
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
            wedMorning.Location = new Point(617, 435);
            wedMorning.Name = "wedMorning";
            wedMorning.Size = new Size(104, 23);
            wedMorning.TabIndex = 79;
            wedMorning.Text = "Disponível";
            wedMorning.TextAlign = ContentAlignment.MiddleCenter;
            wedMorning.UseVisualStyleBackColor = true;
            wedMorning.Visible = false;
            wedMorning.CheckedChanged += wedMorning_CheckedChanged;
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
            wedNight.Location = new Point(617, 464);
            wedNight.Name = "wedNight";
            wedNight.Size = new Size(104, 23);
            wedNight.TabIndex = 80;
            wedNight.Text = "Disponível";
            wedNight.TextAlign = ContentAlignment.MiddleCenter;
            wedNight.UseVisualStyleBackColor = true;
            wedNight.Visible = false;
            wedNight.CheckedChanged += wedNight_CheckedChanged;
            // 
            // thuMorning
            // 
            thuMorning.Appearance = Appearance.Button;
            thuMorning.Checked = true;
            thuMorning.CheckState = CheckState.Checked;
            thuMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            thuMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            thuMorning.FlatStyle = FlatStyle.Flat;
            thuMorning.Location = new Point(766, 435);
            thuMorning.Name = "thuMorning";
            thuMorning.Size = new Size(104, 23);
            thuMorning.TabIndex = 81;
            thuMorning.Text = "Disponível";
            thuMorning.TextAlign = ContentAlignment.MiddleCenter;
            thuMorning.UseVisualStyleBackColor = true;
            thuMorning.Visible = false;
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
            thuNight.Location = new Point(766, 465);
            thuNight.Name = "thuNight";
            thuNight.Size = new Size(104, 23);
            thuNight.TabIndex = 82;
            thuNight.Text = "Disponível";
            thuNight.TextAlign = ContentAlignment.MiddleCenter;
            thuNight.UseVisualStyleBackColor = true;
            thuNight.Visible = false;
            thuNight.CheckedChanged += thuNight_CheckedChanged;
            // 
            // friMorning
            // 
            friMorning.Appearance = Appearance.Button;
            friMorning.Checked = true;
            friMorning.CheckState = CheckState.Checked;
            friMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            friMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            friMorning.FlatStyle = FlatStyle.Flat;
            friMorning.Location = new Point(906, 435);
            friMorning.Name = "friMorning";
            friMorning.Size = new Size(104, 23);
            friMorning.TabIndex = 83;
            friMorning.Text = "Disponível";
            friMorning.TextAlign = ContentAlignment.MiddleCenter;
            friMorning.UseVisualStyleBackColor = true;
            friMorning.Visible = false;
            friMorning.CheckedChanged += friMorning_CheckedChanged;
            // 
            // friNight
            // 
            friNight.Appearance = Appearance.Button;
            friNight.Checked = true;
            friNight.CheckState = CheckState.Checked;
            friNight.FlatAppearance.BorderColor = Color.DarkGreen;
            friNight.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            friNight.FlatStyle = FlatStyle.Flat;
            friNight.Location = new Point(908, 464);
            friNight.Name = "friNight";
            friNight.Size = new Size(104, 23);
            friNight.TabIndex = 84;
            friNight.Text = "Disponível";
            friNight.TextAlign = ContentAlignment.MiddleCenter;
            friNight.UseVisualStyleBackColor = true;
            friNight.Visible = false;
            friNight.CheckedChanged += friNight_CheckedChanged;
            // 
            // satMorning
            // 
            satMorning.Appearance = Appearance.Button;
            satMorning.Checked = true;
            satMorning.CheckState = CheckState.Checked;
            satMorning.FlatAppearance.BorderColor = Color.DarkGreen;
            satMorning.FlatAppearance.CheckedBackColor = Color.LawnGreen;
            satMorning.FlatStyle = FlatStyle.Flat;
            satMorning.Location = new Point(1047, 435);
            satMorning.Name = "satMorning";
            satMorning.Size = new Size(104, 23);
            satMorning.TabIndex = 85;
            satMorning.Text = "Disponível";
            satMorning.TextAlign = ContentAlignment.MiddleCenter;
            satMorning.UseVisualStyleBackColor = true;
            satMorning.Visible = false;
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
            satNight.Location = new Point(1047, 464);
            satNight.Name = "satNight";
            satNight.Size = new Size(104, 23);
            satNight.TabIndex = 86;
            satNight.Text = "Disponível";
            satNight.TextAlign = ContentAlignment.MiddleCenter;
            satNight.UseVisualStyleBackColor = true;
            satNight.Visible = false;
            satNight.CheckedChanged += satNight_CheckedChanged;
            // 
            // btQuery
            // 
            btQuery.AutoSize = true;
            btQuery.BackColor = Color.MediumSeaGreen;
            btQuery.FlatStyle = FlatStyle.Flat;
            btQuery.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btQuery.Location = new Point(31, 221);
            btQuery.Name = "btQuery";
            btQuery.Size = new Size(403, 27);
            btQuery.TabIndex = 87;
            btQuery.Text = "Clique aqui para buscar o atirador que terá os dados atualizados";
            btQuery.UseVisualStyleBackColor = false;
            btQuery.Click += btQuery_Click;
            // 
            // FormUpdateByName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 610);
            Controls.Add(btQuery);
            Controls.Add(satNight);
            Controls.Add(satMorning);
            Controls.Add(friNight);
            Controls.Add(friMorning);
            Controls.Add(thuNight);
            Controls.Add(thuMorning);
            Controls.Add(wedNight);
            Controls.Add(wedMorning);
            Controls.Add(tueNight);
            Controls.Add(tueMorning);
            Controls.Add(monNight);
            Controls.Add(monMorning);
            Controls.Add(sunNight);
            Controls.Add(sunMorning);
            Controls.Add(satLabel);
            Controls.Add(friLabel);
            Controls.Add(thuLabel);
            Controls.Add(wedLabel);
            Controls.Add(tueLabel);
            Controls.Add(monLabel);
            Controls.Add(sunLabel);
            Controls.Add(sentiLabel);
            Controls.Add(permaLabel);
            Controls.Add(disponibleLabel);
            Controls.Add(checkIsCfc);
            Controls.Add(checkIsNotCfc);
            Controls.Add(isCfcLabel);
            Controls.Add(numServiceBox);
            Controls.Add(numServiceLabel);
            Controls.Add(numAtrUpBox);
            Controls.Add(numAtrLabel);
            Controls.Add(warNameBox);
            Controls.Add(warNameLabel);
            Controls.Add(btCadastrar);
            Controls.Add(nameQueryBox);
            Controls.Add(label3);
            Controls.Add(infoLabel);
            Controls.Add(table);
            Controls.Add(label1);
            Name = "FormUpdateByName";
            Text = "FormUpdateByName";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView table;
        private Label infoLabel;
        private Label label3;
        private TextBox nameQueryBox;
        private Button btCadastrar;
        private Label warNameLabel;
        private TextBox warNameBox;
        private Label numAtrLabel;
        private TextBox numAtrUpBox;
        private Label numServiceLabel;
        private TextBox numServiceBox;
        private Label isCfcLabel;
        private CheckBox checkIsNotCfc;
        private CheckBox checkIsCfc;
        private Label disponibleLabel;
        private Label permaLabel;
        private Label sentiLabel;
        private Label sunLabel;
        private Label monLabel;
        private Label tueLabel;
        private Label wedLabel;
        private Label thuLabel;
        private Label friLabel;
        private Label satLabel;
        private CheckBox sunMorning;
        private CheckBox sunNight;
        private CheckBox monMorning;
        private CheckBox monNight;
        private CheckBox tueMorning;
        private CheckBox tueNight;
        private CheckBox wedMorning;
        private CheckBox wedNight;
        private CheckBox thuMorning;
        private CheckBox thuNight;
        private CheckBox friMorning;
        private CheckBox friNight;
        private CheckBox satMorning;
        private CheckBox satNight;
        private Button btQuery;
    }
}