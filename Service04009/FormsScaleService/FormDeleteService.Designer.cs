namespace Service04009.FormsScaleService
{
    partial class FormDeleteService
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
            label16 = new Label();
            dateTime = new DateTimePicker();
            btQuery = new Button();
            infoLabel = new Label();
            table = new DataGridView();
            lblSelecione = new Label();
            btRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Text = "Excluir Serviço de uma Escala";
            //
            // label16
            //
            label16.AutoSize = true;
            label16.Location = new Point(30, 60);
            label16.Name = "label16";
            label16.Text = "Informe uma data que pertença à escala:";
            //
            // dateTime
            //
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(30, 88);
            dateTime.Size = new Size(300, 26);
            dateTime.Name = "dateTime";
            //
            // btQuery
            //
            btQuery.Location = new Point(350, 85);
            btQuery.Size = new Size(380, 30);
            btQuery.Name = "btQuery";
            btQuery.Text = "Buscar escala e listar serviços";
            btQuery.UseVisualStyleBackColor = true;
            btQuery.Click += btQuery_Click;
            //
            // infoLabel
            //
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(30, 130);
            infoLabel.Name = "infoLabel";
            infoLabel.Padding = new Padding(10, 4, 10, 4);
            infoLabel.Visible = false;
            //
            // table
            //
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.ReadOnly = true;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.MultiSelect = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.Location = new Point(30, 175);
            table.Size = new Size(1185, 250);
            table.Name = "table";
            table.Visible = false;
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            //
            // lblSelecione
            //
            lblSelecione.AutoSize = true;
            lblSelecione.Location = new Point(30, 440);
            lblSelecione.Name = "lblSelecione";
            lblSelecione.Text = "Selecione um serviço na tabela acima e clique no botão abaixo para excluí-lo.";
            lblSelecione.Visible = false;
            //
            // btRemover
            //
            btRemover.Location = new Point(300, 470);
            btRemover.Size = new Size(600, 48);
            btRemover.Name = "btRemover";
            btRemover.Text = "Excluir serviço selecionado";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Visible = false;
            btRemover.Click += btRemover_Click;
            //
            // FormDeleteService
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 550);
            Controls.Add(label1);
            Controls.Add(label16);
            Controls.Add(dateTime);
            Controls.Add(btQuery);
            Controls.Add(infoLabel);
            Controls.Add(table);
            Controls.Add(lblSelecione);
            Controls.Add(btRemover);
            Name = "FormDeleteService";
            Text = "Excluir Serviço";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label16;
        private DateTimePicker dateTime;
        private Button btQuery;
        private Label infoLabel;
        private DataGridView table;
        private Label lblSelecione;
        private Button btRemover;
    }
}
