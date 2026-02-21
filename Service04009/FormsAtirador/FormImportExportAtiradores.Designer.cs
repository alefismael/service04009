namespace Service04009.FormsAtirador
{
    partial class FormImportExportAtiradores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            lblDesc = new Label();
            linkTemplate = new LinkLabel();
            linkImportar = new LinkLabel();
            lblResultado = new Label();
            table = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Text = "Importar / Exportar Atiradores";
            //
            // lblDesc
            //
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(25, 55);
            lblDesc.Name = "lblDesc";
            lblDesc.MaximumSize = new Size(1100, 0);
            lblDesc.Text = "Utilize os links abaixo para gerar um template Excel de cadastro de atiradores, ou para importar atiradores a partir de uma planilha preenchida.";
            //
            // linkTemplate
            //
            linkTemplate.AutoSize = true;
            linkTemplate.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            linkTemplate.Location = new Point(30, 100);
            linkTemplate.Name = "linkTemplate";
            linkTemplate.Text = "📥  Baixar template Excel para cadastro";
            linkTemplate.LinkClicked += linkTemplate_LinkClicked;
            //
            // linkImportar
            //
            linkImportar.AutoSize = true;
            linkImportar.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            linkImportar.Location = new Point(30, 135);
            linkImportar.Name = "linkImportar";
            linkImportar.Text = "📤  Importar atiradores de planilha Excel";
            linkImportar.LinkClicked += linkImportar_LinkClicked;
            //
            // lblResultado
            //
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 180);
            lblResultado.Name = "lblResultado";
            lblResultado.Text = "";
            lblResultado.MaximumSize = new Size(1100, 0);
            lblResultado.Visible = false;
            //
            // table
            //
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.ReadOnly = true;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.Location = new Point(30, 215);
            table.Size = new Size(1185, 350);
            table.Name = "table";
            table.Visible = false;
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            //
            // FormImportExportAtiradores
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 600);
            Controls.Add(label1);
            Controls.Add(lblDesc);
            Controls.Add(linkTemplate);
            Controls.Add(linkImportar);
            Controls.Add(lblResultado);
            Controls.Add(table);
            Name = "FormImportExportAtiradores";
            Text = "Importar / Exportar Atiradores";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label lblDesc;
        private LinkLabel linkTemplate;
        private LinkLabel linkImportar;
        private Label lblResultado;
        private DataGridView table;
    }
}
