namespace Service04009.FormsScaleService
{
    partial class FormShowScaleForServiceData
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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            label1 = new Label();
            dateTime = new DateTimePicker();
            label16 = new Label();
            btQuery = new Button();
            table = new DataGridView();
            infoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Bold);
            label1.Location = new Point(172, 44);
            label1.Name = "label1";
            label1.Size = new Size(951, 43);
            label1.TabIndex = 15;
            label1.Text = "Pesquisar escala de serviço completa por uma data";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTime
            // 
            dateTime.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dateTime.CalendarTitleBackColor = Color.SpringGreen;
            dateTime.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(59, 158);
            dateTime.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(588, 26);
            dateTime.TabIndex = 55;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkGreen;
            label16.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(59, 131);
            label16.Name = "label16";
            label16.Padding = new Padding(25, 0, 25, 0);
            label16.Size = new Size(600, 24);
            label16.TabIndex = 56;
            label16.Text = "Dia para buscar os dados da escala de serviço";
            // 
            // btQuery
            // 
            btQuery.AutoSize = true;
            btQuery.BackColor = Color.MediumSeaGreen;
            btQuery.FlatStyle = FlatStyle.Flat;
            btQuery.Font = new Font("Consolas", 15.25F, FontStyle.Bold);
            btQuery.Location = new Point(59, 210);
            btQuery.Name = "btQuery";
            btQuery.Size = new Size(538, 36);
            btQuery.TabIndex = 64;
            btQuery.Text = "Clique aqui para buscar a escala dessa data";
            btQuery.UseVisualStyleBackColor = false;
            btQuery.Click += btQuery_Click;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeColumns = false;
            table.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.Black;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            table.Anchor = AnchorStyles.None;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.BackgroundColor = Color.DarkSlateGray;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.Lime;
            dataGridViewCellStyle18.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = SystemColors.Window;
            dataGridViewCellStyle19.Font = new Font("Consolas", 8.25F);
            dataGridViewCellStyle19.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            table.DefaultCellStyle = dataGridViewCellStyle19;
            table.EnableHeadersVisualStyles = false;
            table.GridColor = Color.DarkGreen;
            table.Location = new Point(41, 328);
            table.MultiSelect = false;
            table.Name = "table";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new Font("Consolas", 8.25F);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            table.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            table.RowHeadersVisible = false;
            table.Size = new Size(1186, 270);
            table.TabIndex = 65;
            table.Visible = false;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = Color.Lime;
            infoLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoLabel.Location = new Point(59, 282);
            infoLabel.Name = "infoLabel";
            infoLabel.Padding = new Padding(25, 0, 25, 0);
            infoLabel.Size = new Size(444, 24);
            infoLabel.TabIndex = 66;
            infoLabel.Text = "Informações da escala de serviço";
            infoLabel.Visible = false;
            // 
            // FormShowScaleForServiceData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 610);
            Controls.Add(infoLabel);
            Controls.Add(table);
            Controls.Add(btQuery);
            Controls.Add(label16);
            Controls.Add(dateTime);
            Controls.Add(label1);
            Name = "FormShowScaleForServiceData";
            Text = "FormShowScaleForServiceData";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTime;
        private Label label16;
        private Button btQuery;
        private DataGridView table;
        private Label infoLabel;
    }
}