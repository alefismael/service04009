namespace Service04009.FormsAtirador
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            warNameBox = new TextBox();
            label2 = new Label();
            numAtrBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numServiceBox = new TextBox();
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
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 23);
            label1.Name = "label1";
            label1.Size = new Size(415, 39);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Atiradores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // warNameBox
            // 
            warNameBox.Location = new Point(26, 114);
            warNameBox.MaxLength = 20;
            warNameBox.Name = "warNameBox";
            warNameBox.PlaceholderText = "Digite aqui";
            warNameBox.Size = new Size(184, 23);
            warNameBox.TabIndex = 2;
            warNameBox.WordWrap = false;
            warNameBox.KeyPress += warNameBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Green;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Padding = new Padding(45, 0, 45, 0);
            label2.Size = new Size(184, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome de Guerra";
            // 
            // numAtrBox
            // 
            numAtrBox.Location = new Point(26, 177);
            numAtrBox.MaxLength = 4;
            numAtrBox.Name = "numAtrBox";
            numAtrBox.PlaceholderText = "Digite aqui";
            numAtrBox.Size = new Size(112, 23);
            numAtrBox.TabIndex = 4;
            numAtrBox.KeyPress += numAtrBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Green;
            label3.Location = new Point(26, 159);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 5;
            label3.Text = "Número do atirador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Green;
            label4.Location = new Point(26, 217);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 6;
            label4.Text = "Número de serviços tirados";
            // 
            // numServiceBox
            // 
            numServiceBox.Location = new Point(25, 235);
            numServiceBox.MaxLength = 4;
            numServiceBox.Name = "numServiceBox";
            numServiceBox.PlaceholderText = "Digite aqui";
            numServiceBox.Size = new Size(152, 23);
            numServiceBox.TabIndex = 7;
            numServiceBox.KeyPress += numServiceBox_KeyPress;
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
            table.BackgroundColor = Color.Green;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.EnableHeadersVisualStyles = false;
            table.GridColor = Color.DarkGreen;
            table.Location = new Point(240, 93);
            table.MultiSelect = false;
            table.Name = "table";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            table.RowHeadersVisible = false;
            table.Size = new Size(930, 422);
            table.TabIndex = 8;
            table.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Green;
            label5.Location = new Point(26, 287);
            label5.Name = "label5";
            label5.Padding = new Padding(25, 0, 25, 0);
            label5.Size = new Size(99, 15);
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
            checkIsNotCfc.Location = new Point(26, 305);
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
            checkIsCfc.Location = new Point(89, 305);
            checkIsCfc.Name = "checkIsCfc";
            checkIsCfc.Size = new Size(37, 25);
            checkIsCfc.TabIndex = 12;
            checkIsCfc.Text = "SIM";
            checkIsCfc.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(36, 469);
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
            Controls.Add(numServiceBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numAtrBox);
            Controls.Add(label2);
            Controls.Add(warNameBox);
            Controls.Add(label1);
            Name = "FormAtiradorConsult";
            Text = "FormAtiradorConsult";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox warNameBox;
        private Label label2;
        private TextBox numAtrBox;
        private Label label3;
        private Label label4;
        private TextBox numServiceBox;
        private DataGridView table;
        private Label label5;
        private CheckBox checkIsNotCfc;
        private CheckBox checkIsCfc;
        private Button button1;
    }
}