namespace Service04009.FormsScaleService
{
    partial class FormOpcoes
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
            panelGrid = new Panel();
            dgvConfig = new DataGridView();
            colDia = new DataGridViewTextBoxColumn();
            colPermanencias = new DataGridViewTextBoxColumn();
            colSentinelas = new DataGridViewTextBoxColumn();
            colComandantes = new DataGridViewTextBoxColumn();
            colCfcObrigatorio = new DataGridViewCheckBoxColumn();
            btnSalvar = new Button();
            btnResetar = new Button();
            lblInfo = new Label();

            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfig).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(350, 30);
            lblTitle.Text = "Configuração do Serviço";

            // lblInfo
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(30, 60);
            lblInfo.MaximumSize = new Size(1180, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(900, 20);
            lblInfo.Text = "Defina a quantidade de atiradores por função para cada dia da semana. Marque a coluna CFC se o comandante deve ser obrigatoriamente CFC.";

            // panelGrid
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            panelGrid.Location = new Point(30, 95);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1188, 380);
            panelGrid.Controls.Add(dgvConfig);

            // dgvConfig
            dgvConfig.Dock = DockStyle.Fill;
            dgvConfig.AllowUserToAddRows = false;
            dgvConfig.AllowUserToDeleteRows = false;
            dgvConfig.AllowUserToResizeRows = false;
            dgvConfig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConfig.RowHeadersVisible = false;
            dgvConfig.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvConfig.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvConfig.ReadOnly = false;
            dgvConfig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConfig.Columns.AddRange(new DataGridViewColumn[] { colDia, colPermanencias, colSentinelas, colComandantes, colCfcObrigatorio });
            dgvConfig.Name = "dgvConfig";

            // colDia
            colDia.HeaderText = "Dia da Semana";
            colDia.Name = "colDia";
            colDia.ReadOnly = true;
            colDia.FillWeight = 30;

            // colPermanencias
            colPermanencias.HeaderText = "Permanências";
            colPermanencias.Name = "colPermanencias";
            colPermanencias.FillWeight = 20;

            // colSentinelas
            colSentinelas.HeaderText = "Sentinelas";
            colSentinelas.Name = "colSentinelas";
            colSentinelas.FillWeight = 20;

            // colComandantes
            colComandantes.HeaderText = "Comandantes";
            colComandantes.Name = "colComandantes";
            colComandantes.FillWeight = 20;

            // colCfcObrigatorio
            colCfcObrigatorio.HeaderText = "CFC Obrigatório";
            colCfcObrigatorio.Name = "colCfcObrigatorio";
            colCfcObrigatorio.FillWeight = 15;

            // btnSalvar
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Location = new Point(1038, 490);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 45);
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;

            // btnResetar
            btnResetar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetar.Location = new Point(840, 490);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(180, 45);
            btnResetar.Text = "Resetar Padrão";
            btnResetar.UseVisualStyleBackColor = false;
            btnResetar.Click += btnResetar_Click;

            // FormOpcoes
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 560);
            Controls.Add(lblTitle);
            Controls.Add(lblInfo);
            Controls.Add(panelGrid);
            Controls.Add(btnSalvar);
            Controls.Add(btnResetar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOpcoes";
            Text = "Opções de Serviço";

            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConfig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInfo;
        private Panel panelGrid;
        private DataGridView dgvConfig;
        private DataGridViewTextBoxColumn colDia;
        private DataGridViewTextBoxColumn colPermanencias;
        private DataGridViewTextBoxColumn colSentinelas;
        private DataGridViewTextBoxColumn colComandantes;
        private DataGridViewCheckBoxColumn colCfcObrigatorio;
        private Button btnSalvar;
        private Button btnResetar;
    }
}
