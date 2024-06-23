namespace Service04009.Forms
{
    partial class FormAtiradorConsult
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            table = new DataGridView();
            label5 = new Label();
            checkIsNotCfc = new CheckBox();
            checkIsCfc = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 24);
            label1.Name = "label1";
            label1.Size = new Size(413, 37);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Atiradores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome de Guerra";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 159);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 5;
            label3.Text = "Número do atirador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 217);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 6;
            label4.Text = "Número de serviços tirados";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToResizeColumns = false;
            table.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            table.Anchor = AnchorStyles.None;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            table.BackgroundColor = Color.Green;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Lime;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            table.DefaultCellStyle = dataGridViewCellStyle7;
            table.EnableHeadersVisualStyles = false;
            table.GridColor = Color.DarkGreen;
            table.Location = new Point(255, 103);
            table.MultiSelect = false;
            table.Name = "table";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            table.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            table.RowHeadersVisible = false;
            table.Size = new Size(930, 422);
            table.TabIndex = 8;
            table.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 287);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Faz CFC";
            // 
            // checkIsNotCfc
            // 
            checkIsNotCfc.Appearance = Appearance.Button;
            checkIsNotCfc.AutoSize = true;
            checkIsNotCfc.BackColor = Color.White;
            checkIsNotCfc.FlatAppearance.BorderColor = Color.Black;
            checkIsNotCfc.FlatAppearance.CheckedBackColor = Color.DarkGreen;
            checkIsNotCfc.FlatStyle = FlatStyle.Flat;
            checkIsNotCfc.Location = new Point(30, 314);
            checkIsNotCfc.Name = "checkIsNotCfc";
            checkIsNotCfc.Size = new Size(43, 25);
            checkIsNotCfc.TabIndex = 11;
            checkIsNotCfc.Text = "NÃO";
            checkIsNotCfc.UseVisualStyleBackColor = false;
            // 
            // checkIsCfc
            // 
            checkIsCfc.Appearance = Appearance.Button;
            checkIsCfc.AutoSize = true;
            checkIsCfc.BackColor = Color.White;
            checkIsCfc.FlatAppearance.BorderColor = Color.Black;
            checkIsCfc.FlatAppearance.CheckedBackColor = Color.DarkGreen;
            checkIsCfc.FlatStyle = FlatStyle.Flat;
            checkIsCfc.Location = new Point(101, 314);
            checkIsCfc.Name = "checkIsCfc";
            checkIsCfc.Size = new Size(37, 25);
            checkIsCfc.TabIndex = 12;
            checkIsCfc.Text = "SIM";
            checkIsCfc.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(30, 470);
            button1.Name = "button1";
            button1.Size = new Size(90, 39);
            button1.TabIndex = 13;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAtiradorConsult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1248, 610);
            Controls.Add(button1);
            Controls.Add(checkIsCfc);
            Controls.Add(checkIsNotCfc);
            Controls.Add(label5);
            Controls.Add(table);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormAtiradorConsult";
            Text = "FormAtiradorConsult";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private DataGridView table;
        private Label label5;
        private CheckBox checkIsNotCfc;
        private CheckBox checkIsCfc;
        private Button button1;
    }
}