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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            dateTime = new DateTimePicker();
            label16 = new Label();
            btQuery = new Button();
            table = new DataGridView();
            infoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 44);
            label2.Name = "label2";
            label2.Size = new Size(901, 39);
            label2.TabIndex = 15;
            label2.Text = "Pesquisar escala de serviço completa por uma data";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            table.Location = new Point(41, 328);
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
            BackgroundImage = Properties.Resources.img_fundo_service_04009;
            ClientSize = new Size(1248, 610);
            Controls.Add(infoLabel);
            Controls.Add(table);
            Controls.Add(btQuery);
            Controls.Add(label16);
            Controls.Add(dateTime);
            Controls.Add(label2);
            Name = "FormShowScaleForServiceData";
            Text = "FormShowScaleForServiceData";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dateTime;
        private Label label16;
        private Button btQuery;
        private DataGridView table;
        private Label infoLabel;
    }
}