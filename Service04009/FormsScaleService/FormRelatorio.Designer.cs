namespace Service04009.FormsScaleService
{
    partial class FormRelatorio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDesc = new Label();
            lblInicio = new Label();
            lblFim = new Label();
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            rbPeriodo = new RadioButton();
            rbEscalaCompleta = new RadioButton();
            lblEscala = new Label();
            cmbEscalas = new ComboBox();
            btnGerar = new Button();
            table = new DataGridView();
            lblFormato = new Label();
            cmbFormato = new ComboBox();
            btnExportar = new Button();
            lblStatus = new Label();
            panelPeriodo = new Panel();
            panelEscala = new Panel();

            panelPeriodo.SuspendLayout();
            panelEscala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "label1";
            lblTitle.Text = "Relatório de Escala de Serviço";

            // lblDesc
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(30, 55);
            lblDesc.MaximumSize = new Size(1180, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Text = "Visualize a escala de serviço antes de exportar. Permanências, sentinelas e comandantes por dia.";

            // rbPeriodo
            rbPeriodo.AutoSize = true;
            rbPeriodo.Checked = true;
            rbPeriodo.Location = new Point(30, 90);
            rbPeriodo.Name = "rbPeriodo";
            rbPeriodo.Size = new Size(200, 22);
            rbPeriodo.Text = "Por Período";
            rbPeriodo.CheckedChanged += rbPeriodo_CheckedChanged;

            // rbEscalaCompleta
            rbEscalaCompleta.AutoSize = true;
            rbEscalaCompleta.Location = new Point(200, 90);
            rbEscalaCompleta.Name = "rbEscalaCompleta";
            rbEscalaCompleta.Size = new Size(200, 22);
            rbEscalaCompleta.Text = "Por Escala Completa";
            rbEscalaCompleta.CheckedChanged += rbEscalaCompleta_CheckedChanged;

            // panelPeriodo
            panelPeriodo.Location = new Point(30, 118);
            panelPeriodo.Name = "panelPeriodo";
            panelPeriodo.Size = new Size(600, 35);

            // lblInicio
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(0, 7);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(70, 20);
            lblInicio.Text = "Data Início:";

            // dtpInicio
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(85, 4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(170, 27);

            // lblFim
            lblFim.AutoSize = true;
            lblFim.Location = new Point(275, 7);
            lblFim.Name = "lblFim";
            lblFim.Size = new Size(60, 20);
            lblFim.Text = "Data Fim:";

            // dtpFim
            dtpFim.Format = DateTimePickerFormat.Short;
            dtpFim.Location = new Point(345, 4);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(170, 27);

            panelPeriodo.Controls.Add(lblInicio);
            panelPeriodo.Controls.Add(dtpInicio);
            panelPeriodo.Controls.Add(lblFim);
            panelPeriodo.Controls.Add(dtpFim);

            // panelEscala
            panelEscala.Location = new Point(30, 118);
            panelEscala.Name = "panelEscala";
            panelEscala.Size = new Size(600, 35);
            panelEscala.Visible = false;

            // lblEscala
            lblEscala.AutoSize = true;
            lblEscala.Location = new Point(0, 7);
            lblEscala.Name = "lblEscala";
            lblEscala.Size = new Size(130, 20);
            lblEscala.Text = "Selecione a escala:";

            // cmbEscalas
            cmbEscalas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEscalas.Location = new Point(135, 4);
            cmbEscalas.Name = "cmbEscalas";
            cmbEscalas.Size = new Size(400, 27);

            panelEscala.Controls.Add(lblEscala);
            panelEscala.Controls.Add(cmbEscalas);

            // btnGerar
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Location = new Point(650, 118);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(200, 32);
            btnGerar.Text = "Gerar Relatório";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;

            // table
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeRows = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.EnableHeadersVisualStyles = false;
            table.Location = new Point(30, 165);
            table.MultiSelect = false;
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersVisible = false;
            table.Size = new Size(1185, 340);
            table.TabIndex = 20;
            table.Visible = false;

            // lblFormato
            lblFormato.AutoSize = true;
            lblFormato.Location = new Point(30, 520);
            lblFormato.Name = "lblFormato";
            lblFormato.Text = "Formato:";
            lblFormato.Visible = false;

            // cmbFormato
            cmbFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormato.Location = new Point(100, 517);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(170, 27);
            cmbFormato.Visible = false;

            // btnExportar
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Location = new Point(290, 513);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(200, 36);
            btnExportar.Text = "Exportar Relatório";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Visible = false;
            btnExportar.Click += btnExportar_Click;

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(510, 524);
            lblStatus.MaximumSize = new Size(700, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.Text = "";

            // FormRelatorio
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 570);
            Controls.Add(lblTitle);
            Controls.Add(lblDesc);
            Controls.Add(rbPeriodo);
            Controls.Add(rbEscalaCompleta);
            Controls.Add(btnGerar);
            Controls.Add(panelPeriodo);
            Controls.Add(panelEscala);
            Controls.Add(table);
            Controls.Add(lblFormato);
            Controls.Add(cmbFormato);
            Controls.Add(btnExportar);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRelatorio";
            Text = "Relatórios";

            panelPeriodo.ResumeLayout(false);
            panelPeriodo.PerformLayout();
            panelEscala.ResumeLayout(false);
            panelEscala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDesc;
        private RadioButton rbPeriodo;
        private RadioButton rbEscalaCompleta;
        private Panel panelPeriodo;
        private Label lblInicio;
        private DateTimePicker dtpInicio;
        private Label lblFim;
        private DateTimePicker dtpFim;
        private Panel panelEscala;
        private Label lblEscala;
        private ComboBox cmbEscalas;
        private Button btnGerar;
        private DataGridView table;
        private Label lblFormato;
        private ComboBox cmbFormato;
        private Button btnExportar;
        private Label lblStatus;
    }
}
