namespace Service04009.FormsAtirador
{
    partial class FormDeleteByNumber
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
            label3 = new Label();
            infoLabel = new Label();
            table = new DataGridView();
            btQuery = new Button();
            numAtrBox = new TextBox();
            btRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 44);
            label1.Name = "label1";
            label1.Size = new Size(723, 43);
            label1.TabIndex = 3;
            label1.Text = "Remover atirador por número de guerra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 144);
            label3.Name = "label3";
            label3.Size = new Size(306, 19);
            label3.TabIndex = 52;
            label3.Text = "Número do atirador para atualizar";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = Color.Red;
            infoLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoLabel.Location = new Point(520, 144);
            infoLabel.Name = "infoLabel";
            infoLabel.Padding = new Padding(25, 0, 25, 0);
            infoLabel.Size = new Size(612, 24);
            infoLabel.TabIndex = 54;
            infoLabel.Text = "Sem atirador informado para atualizar os dados";
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
            table.BackgroundColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            table.DefaultCellStyle = dataGridViewCellStyle3;
            table.EnableHeadersVisualStyles = false;
            table.GridColor = Color.DarkGreen;
            table.Location = new Point(468, 168);
            table.Margin = new Padding(3, 0, 3, 3);
            table.MultiSelect = false;
            table.Name = "table";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            table.RowHeadersVisible = false;
            table.Size = new Size(715, 67);
            table.TabIndex = 53;
            // 
            // btQuery
            // 
            btQuery.AutoSize = true;
            btQuery.BackColor = Color.MediumSeaGreen;
            btQuery.FlatStyle = FlatStyle.Flat;
            btQuery.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btQuery.Location = new Point(25, 214);
            btQuery.Name = "btQuery";
            btQuery.Size = new Size(337, 27);
            btQuery.TabIndex = 89;
            btQuery.Text = "Clique aqui para buscar o atirador que será removido";
            btQuery.UseVisualStyleBackColor = false;
            btQuery.Click += btQuery_Click;
            // 
            // numAtrBox
            // 
            numAtrBox.Location = new Point(25, 185);
            numAtrBox.MaxLength = 4;
            numAtrBox.Name = "numAtrBox";
            numAtrBox.PlaceholderText = "Digite aqui o número do atirador para atualizar dados";
            numAtrBox.Size = new Size(337, 23);
            numAtrBox.TabIndex = 88;
            numAtrBox.KeyPress += numAtrBox_KeyPress;
            // 
            // btRemover
            // 
            btRemover.AutoSize = true;
            btRemover.BackColor = Color.MediumSeaGreen;
            btRemover.FlatStyle = FlatStyle.Flat;
            btRemover.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRemover.Location = new Point(252, 430);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(731, 57);
            btRemover.TabIndex = 90;
            btRemover.Text = "Clique aqui para remover o atirador";
            btRemover.UseVisualStyleBackColor = false;
            btRemover.Visible = false;
            btRemover.Click += btRemover_Click;
            // 
            // FormDeleteByNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_fundo_service_04009;
            ClientSize = new Size(1248, 610);
            Controls.Add(btRemover);
            Controls.Add(btQuery);
            Controls.Add(numAtrBox);
            Controls.Add(infoLabel);
            Controls.Add(table);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormDeleteByNumber";
            Text = "FormDeleteByNumber";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label infoLabel;
        private DataGridView table;
        private Button btQuery;
        private TextBox numAtrBox;
        private Button btRemover;
    }
}