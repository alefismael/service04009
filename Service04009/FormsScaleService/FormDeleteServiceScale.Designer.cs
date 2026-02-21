namespace Service04009.FormsScaleService
{
    partial class FormDeleteServiceScale
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
            infoLabel = new Label();
            btQuery = new Button();
            label16 = new Label();
            dateTime = new DateTimePicker();
            btRemover = new Button();
            table = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 45);
            label1.Name = "label1";
            label1.Size = new Size(946, 34);
            label1.TabIndex = 16;
            label1.Text = "Pesquisar escala de serviço completa por uma data para remoção";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = Color.Firebrick;
            infoLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoLabel.Location = new Point(84, 255);
            infoLabel.Name = "infoLabel";
            infoLabel.Padding = new Padding(25, 0, 25, 0);
            infoLabel.Size = new Size(444, 24);
            infoLabel.TabIndex = 70;
            infoLabel.Text = "Informações da escala de serviço";
            infoLabel.Visible = false;
            // 
            // btQuery
            // 
            btQuery.AutoSize = true;
            btQuery.BackColor = Color.MediumSeaGreen;
            btQuery.FlatStyle = FlatStyle.Flat;
            btQuery.Font = new Font("Consolas", 15.25F, FontStyle.Bold);
            btQuery.Location = new Point(84, 199);
            btQuery.Name = "btQuery";
            btQuery.Size = new Size(538, 36);
            btQuery.TabIndex = 69;
            btQuery.Text = "Clique aqui para buscar a escala dessa data";
            btQuery.UseVisualStyleBackColor = false;
            btQuery.Click += btQuery_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkGreen;
            label16.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(84, 116);
            label16.Name = "label16";
            label16.Padding = new Padding(25, 0, 25, 0);
            label16.Size = new Size(600, 24);
            label16.TabIndex = 68;
            label16.Text = "Dia para buscar os dados da escala de serviço";
            // 
            // dateTime
            // 
            dateTime.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dateTime.CalendarTitleBackColor = Color.SpringGreen;
            dateTime.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(84, 154);
            dateTime.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(588, 26);
            dateTime.TabIndex = 67;
            // 
            // btRemover
            // 
            btRemover.AutoSize = true;
            btRemover.BackColor = Color.MediumSeaGreen;
            btRemover.FlatStyle = FlatStyle.Flat;
            btRemover.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRemover.Location = new Point(241, 541);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(731, 57);
            btRemover.TabIndex = 91;
            btRemover.Text = "Clique aqui para excluir a escala";
            btRemover.UseVisualStyleBackColor = false;
            btRemover.Visible = false;
            btRemover.Click += btRemover_Click;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeColumns = false;
            table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            table.Anchor = AnchorStyles.None;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.BackgroundColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Consolas", 8.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            table.DefaultCellStyle = dataGridViewCellStyle3;
            table.EnableHeadersVisualStyles = false;
            table.GridColor = Color.DarkGreen;
            table.Location = new Point(75, 307);
            table.Margin = new Padding(1, 1, 1, 1);
            table.MultiSelect = false;
            table.Name = "table";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Consolas", 8.25F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            table.RowHeadersVisible = false;
            table.Size = new Size(967, 190);
            table.TabIndex = 92;
            table.Visible = false;
            // 
            // FormDeleteServiceScale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 610);
            Controls.Add(table);
            Controls.Add(btRemover);
            Controls.Add(infoLabel);
            Controls.Add(btQuery);
            Controls.Add(label16);
            Controls.Add(dateTime);
            Controls.Add(label1);
            Name = "FormDeleteServiceScale";
            Text = "FormDeleServiceScale";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label infoLabel;
        private Button btQuery;
        private Label label16;
        private DateTimePicker dateTime;
        private Button btRemover;
        private DataGridView table;
    }
}