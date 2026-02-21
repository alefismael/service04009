namespace Service04009.FormsScaleService
{
    partial class FormRelatorioAtiradores
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
            label1 = new Label();
            lblDesc = new Label();
            rbTodos = new RadioButton();
            rbIndividual = new RadioButton();
            lblOrdenar = new Label();
            cmbOrdenacao = new ComboBox();
            lblAtirador = new Label();
            cmbAtiradores = new ComboBox();
            btnGerar = new Button();
            lblShooterInfo = new Label();
            table = new DataGridView();
            lblFormato = new Label();
            cmbFormato = new ComboBox();
            btnExportar = new Button();
            lblStatus = new Label();

            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();

            // label1 (title)
            label1.AutoSize = true;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Text = "Relatório de Atiradores";

            // lblDesc
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(30, 60);
            lblDesc.MaximumSize = new Size(1180, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Text = "Visualize todos os atiradores com contagem de serviços, ou consulte o histórico individual de um atirador.";

            // rbTodos
            rbTodos.AutoSize = true;
            rbTodos.Checked = true;
            rbTodos.Location = new Point(30, 95);
            rbTodos.Name = "rbTodos";
            rbTodos.Text = "Todos os Atiradores";
            rbTodos.CheckedChanged += rbTodos_CheckedChanged;

            // rbIndividual
            rbIndividual.AutoSize = true;
            rbIndividual.Location = new Point(220, 95);
            rbIndividual.Name = "rbIndividual";
            rbIndividual.Text = "Consulta Individual";
            rbIndividual.CheckedChanged += rbTodos_CheckedChanged;

            // lblOrdenar
            lblOrdenar.AutoSize = true;
            lblOrdenar.Location = new Point(420, 125);
            lblOrdenar.Name = "lblOrdenar";
            lblOrdenar.Text = "Ordenar por:";

            // cmbOrdenacao
            cmbOrdenacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdenacao.Location = new Point(510, 122);
            cmbOrdenacao.Name = "cmbOrdenacao";
            cmbOrdenacao.Size = new Size(270, 27);
            cmbOrdenacao.SelectedIndexChanged += cmbOrdenacao_SelectedIndexChanged;

            // lblAtirador
            lblAtirador.AutoSize = true;
            lblAtirador.Location = new Point(420, 125);
            lblAtirador.Name = "lblAtirador";
            lblAtirador.Text = "Atirador:";
            lblAtirador.Visible = false;

            // cmbAtiradores
            cmbAtiradores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtiradores.Location = new Point(490, 122);
            cmbAtiradores.Name = "cmbAtiradores";
            cmbAtiradores.Size = new Size(290, 27);
            cmbAtiradores.Visible = false;

            // btnGerar
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Location = new Point(810, 118);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(160, 32);
            btnGerar.Text = "Gerar Relatório";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;

            // lblShooterInfo
            lblShooterInfo.AutoSize = true;
            lblShooterInfo.Location = new Point(30, 160);
            lblShooterInfo.MaximumSize = new Size(1180, 0);
            lblShooterInfo.Name = "lblShooterInfo";
            lblShooterInfo.Text = "";
            lblShooterInfo.Visible = false;

            // table
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeRows = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.EnableHeadersVisualStyles = false;
            table.Location = new Point(30, 185);
            table.MultiSelect = false;
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersVisible = false;
            table.Size = new Size(1185, 320);
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
            btnExportar.Size = new Size(200, 40);
            btnExportar.Text = "Exportar Relatório";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Visible = false;
            btnExportar.Click += btnExportar_Click;

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(510, 522);
            lblStatus.MaximumSize = new Size(700, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "";

            // FormRelatorioAtiradores
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 570);
            Controls.Add(label1);
            Controls.Add(lblDesc);
            Controls.Add(rbTodos);
            Controls.Add(rbIndividual);
            Controls.Add(lblOrdenar);
            Controls.Add(cmbOrdenacao);
            Controls.Add(lblAtirador);
            Controls.Add(cmbAtiradores);
            Controls.Add(btnGerar);
            Controls.Add(lblShooterInfo);
            Controls.Add(table);
            Controls.Add(lblFormato);
            Controls.Add(cmbFormato);
            Controls.Add(btnExportar);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRelatorioAtiradores";
            Text = "Relatório de Atiradores";

            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDesc;
        private RadioButton rbTodos;
        private RadioButton rbIndividual;
        private Label lblOrdenar;
        private ComboBox cmbOrdenacao;
        private Label lblAtirador;
        private ComboBox cmbAtiradores;
        private Button btnGerar;
        private Label lblShooterInfo;
        private DataGridView table;
        private Label lblFormato;
        private ComboBox cmbFormato;
        private Button btnExportar;
        private Label lblStatus;
    }
}
