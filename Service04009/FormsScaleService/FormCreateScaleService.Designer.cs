namespace Service04009.FormsScaleService
{
    partial class FormCreateScaleService
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
            label1 = new Label();
            label16 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            labelInfoNotCfc = new Label();
            labelInfoCfc = new Label();
            notCfcNecessary = new Label();
            cfcNecessary = new Label();
            scaleInfo = new Label();
            btQuery = new Button();
            btLimpar = new Button();
            btCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 47);
            label1.Name = "label1";
            label1.Size = new Size(457, 43);
            label1.TabIndex = 2;
            label1.Text = "Criar escala de serviço";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkGreen;
            label16.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(38, 210);
            label16.Name = "label16";
            label16.Padding = new Padding(25, 0, 25, 0);
            label16.Size = new Size(336, 24);
            label16.TabIndex = 50;
            label16.Text = "Dia de início da escala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(525, 210);
            label2.Name = "label2";
            label2.Padding = new Padding(25, 0, 25, 0);
            label2.Size = new Size(300, 24);
            label2.TabIndex = 51;
            label2.Text = "Dia do fim da escala";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 9F);
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dateTimePicker2.CalendarTitleBackColor = Color.SpringGreen;
            dateTimePicker2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(525, 255);
            dateTimePicker2.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(98, 26);
            dateTimePicker2.TabIndex = 53;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dateTimePicker1.CalendarTitleBackColor = Color.SpringGreen;
            dateTimePicker1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(38, 255);
            dateTimePicker1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 26);
            dateTimePicker1.TabIndex = 54;
            // 
            // labelInfoNotCfc
            // 
            labelInfoNotCfc.AutoSize = true;
            labelInfoNotCfc.BackColor = Color.DarkGreen;
            labelInfoNotCfc.Font = new Font("Consolas", 12F, FontStyle.Bold);
            labelInfoNotCfc.Location = new Point(24, 433);
            labelInfoNotCfc.Name = "labelInfoNotCfc";
            labelInfoNotCfc.Size = new Size(558, 19);
            labelInfoNotCfc.TabIndex = 55;
            labelInfoNotCfc.Text = "Quantidade de atiradores CFC necessários para gerar a escala:";
            labelInfoNotCfc.Visible = false;
            // 
            // labelInfoCfc
            // 
            labelInfoCfc.AutoSize = true;
            labelInfoCfc.BackColor = Color.DarkGreen;
            labelInfoCfc.Font = new Font("Consolas", 12F, FontStyle.Bold);
            labelInfoCfc.Location = new Point(24, 414);
            labelInfoCfc.Name = "labelInfoCfc";
            labelInfoCfc.Size = new Size(666, 19);
            labelInfoCfc.TabIndex = 56;
            labelInfoCfc.Text = "Quantidade de atiradores que não são CFC necessários para gerar a escala:";
            labelInfoCfc.Visible = false;
            // 
            // notCfcNecessary
            // 
            notCfcNecessary.AccessibleDescription = "";
            notCfcNecessary.Location = new Point(725, 395);
            notCfcNecessary.Name = "notCfcNecessary";
            notCfcNecessary.Size = new Size(100, 23);
            notCfcNecessary.TabIndex = 57;
            notCfcNecessary.Text = "0";
            notCfcNecessary.Visible = false;
            // 
            // cfcNecessary
            // 
            cfcNecessary.Location = new Point(725, 426);
            cfcNecessary.Name = "cfcNecessary";
            cfcNecessary.Size = new Size(100, 23);
            cfcNecessary.TabIndex = 58;
            cfcNecessary.Text = "0";
            cfcNecessary.Visible = false;
            // 
            // scaleInfo
            // 
            scaleInfo.AutoSize = true;
            scaleInfo.BackColor = Color.DarkGreen;
            scaleInfo.Font = new Font("Consolas", 12F, FontStyle.Bold);
            scaleInfo.Location = new Point(24, 369);
            scaleInfo.Name = "scaleInfo";
            scaleInfo.Size = new Size(45, 19);
            scaleInfo.TabIndex = 60;
            scaleInfo.Text = "Info";
            scaleInfo.Visible = false;
            // 
            // btQuery
            // 
            btQuery.AutoSize = true;
            btQuery.BackColor = Color.MediumSeaGreen;
            btQuery.FlatStyle = FlatStyle.Flat;
            btQuery.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btQuery.Location = new Point(24, 316);
            btQuery.Name = "btQuery";
            btQuery.Size = new Size(518, 39);
            btQuery.TabIndex = 61;
            btQuery.Text = "Clique aqui para ver a quantidade de atiradores necessários para gerar essa escala";
            btQuery.UseVisualStyleBackColor = false;
            btQuery.Click += btQuery_Click;
            // 
            // btLimpar
            // 
            btLimpar.AutoSize = true;
            btLimpar.BackColor = Color.MediumSeaGreen;
            btLimpar.FlatStyle = FlatStyle.Flat;
            btLimpar.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLimpar.Location = new Point(882, 422);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(204, 25);
            btLimpar.TabIndex = 62;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Visible = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.AutoSize = true;
            btCadastrar.BackColor = Color.MediumSeaGreen;
            btCadastrar.FlatStyle = FlatStyle.Flat;
            btCadastrar.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrar.Location = new Point(293, 529);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(656, 57);
            btCadastrar.TabIndex = 63;
            btCadastrar.Text = "Clique aqui para criar a escala de serviço";
            btCadastrar.UseVisualStyleBackColor = false;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // FormCreateScaleService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_fundo_service_04009;
            ClientSize = new Size(1248, 610);
            Controls.Add(btCadastrar);
            Controls.Add(btLimpar);
            Controls.Add(btQuery);
            Controls.Add(scaleInfo);
            Controls.Add(cfcNecessary);
            Controls.Add(notCfcNecessary);
            Controls.Add(labelInfoCfc);
            Controls.Add(labelInfoNotCfc);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(label16);
            Controls.Add(label1);
            Name = "FormCreateScaleService";
            Text = "FormCreateScaleService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label16;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label labelInfoNotCfc;
        private Label labelInfoCfc;
        private Label notCfcNecessary;
        private Label cfcNecessary;
        private Label scaleInfo;
        private Button btQuery;
        private Button btLimpar;
        private Button btCadastrar;
    }
}