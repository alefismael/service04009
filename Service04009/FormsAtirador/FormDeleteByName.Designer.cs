namespace Service04009.FormsAtirador
{
    partial class FormDeleteByName
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
            btRemover = new Button();
            btQuery = new Button();
            warNameBox = new TextBox();
            infoLabel = new Label();
            table = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // btRemover
            // 
            btRemover.AutoSize = true;
            btRemover.BackColor = Color.MediumSeaGreen;
            btRemover.FlatStyle = FlatStyle.Flat;
            btRemover.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRemover.Location = new Point(267, 495);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(731, 57);
            btRemover.TabIndex = 97;
            btRemover.Text = "Clique aqui para remover o atirador";
            btRemover.UseVisualStyleBackColor = false;
            btRemover.Visible = false;
            btRemover.Click += btRemover_Click;
            // 
            // btQuery
            // 
            btQuery.AutoSize = true;
            btQuery.BackColor = Color.MediumSeaGreen;
            btQuery.FlatStyle = FlatStyle.Flat;
            btQuery.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btQuery.Location = new Point(40, 279);
            btQuery.Name = "btQuery";
            btQuery.Size = new Size(337, 27);
            btQuery.TabIndex = 96;
            btQuery.Text = "Clique aqui para buscar o atirador que será removido";
            btQuery.UseVisualStyleBackColor = false;
            btQuery.Click += btQuery_Click;
            // 
            // warNameBox
            // 
            warNameBox.Location = new Point(40, 250);
            warNameBox.MaxLength = 20;
            warNameBox.Name = "warNameBox";
            warNameBox.PlaceholderText = "Digite aqui o número do atirador para atualizar dados";
            warNameBox.Size = new Size(337, 23);
            warNameBox.TabIndex = 95;
            warNameBox.KeyPress += warNameBox_KeyPress;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = Color.Red;
            infoLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoLabel.Location = new Point(535, 209);
            infoLabel.Name = "infoLabel";
            infoLabel.Padding = new Padding(25, 0, 25, 0);
            infoLabel.Size = new Size(612, 24);
            infoLabel.TabIndex = 94;
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
            table.Location = new Point(483, 233);
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
            table.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(40, 209);
            label3.Name = "label3";
            label3.Size = new Size(288, 19);
            label3.TabIndex = 92;
            label3.Text = "Nome do atirador para atualizar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 79);
            label1.Name = "label1";
            label1.Size = new Size(685, 43);
            label1.TabIndex = 91;
            label1.Text = "Remover atirador por nome de guerra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDeleteByName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 610);
            Controls.Add(btRemover);
            Controls.Add(btQuery);
            Controls.Add(warNameBox);
            Controls.Add(infoLabel);
            Controls.Add(table);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormDeleteByName";
            Text = "FormDeleteByName";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRemover;
        private Button btQuery;
        private TextBox warNameBox;
        private Label infoLabel;
        private DataGridView table;
        private Label label3;
        private Label label1;
    }
}