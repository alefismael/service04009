namespace Service04009.FormsAtirador
{
    partial class FormConsultNotCfc
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
            table = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
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
            table.Location = new Point(115, 111);
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
            table.Size = new Size(1035, 465);
            table.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 38);
            label2.Name = "label2";
            label2.Size = new Size(523, 39);
            label2.TabIndex = 12;
            label2.Text = "Atiradores que não fazem CFC";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConsultNotCfc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1248, 610);
            Controls.Add(label2);
            Controls.Add(table);
            Name = "FormConsultNotCfc";
            Text = "FormConsultNotCfc";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView table;
        private Label label2;
    }
}