namespace Service04009.FormsScaleService
{
    partial class FormSwapService
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
            date1Label = new Label();
            dateTimeService1 = new DateTimePicker();
            date2Label = new Label();
            dateTimeService2 = new DateTimePicker();
            numAtrBox1 = new TextBox();
            label3 = new Label();
            numAtrBox2 = new TextBox();
            label4 = new Label();
            btQueryShooters = new Button();
            btQueryServices = new Button();
            btSwap = new Button();
            shooter1InfoLabel = new Label();
            shooter2InfoLabel = new Label();
            service1InfoLabel = new Label();
            service2InfoLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 41);
            label1.Name = "label1";
            label1.Size = new Size(647, 43);
            label1.TabIndex = 2;
            label1.Text = "Troca de serviço entre atiradores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // date1Label
            // 
            date1Label.AutoSize = true;
            date1Label.BackColor = Color.DarkGreen;
            date1Label.Font = new Font("Consolas", 12F, FontStyle.Bold);
            date1Label.Location = new Point(37, 324);
            date1Label.Name = "date1Label";
            date1Label.Size = new Size(414, 19);
            date1Label.TabIndex = 70;
            date1Label.Text = "Dia para buscar os dados da escala de serviço";
            date1Label.Visible = false;
            // 
            // dateTimeService1
            // 
            dateTimeService1.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dateTimeService1.CalendarTitleBackColor = Color.SpringGreen;
            dateTimeService1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimeService1.Format = DateTimePickerFormat.Short;
            dateTimeService1.Location = new Point(37, 346);
            dateTimeService1.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimeService1.Name = "dateTimeService1";
            dateTimeService1.Size = new Size(414, 26);
            dateTimeService1.TabIndex = 69;
            dateTimeService1.Visible = false;
            // 
            // date2Label
            // 
            date2Label.AutoSize = true;
            date2Label.BackColor = Color.DarkGreen;
            date2Label.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date2Label.Location = new Point(636, 324);
            date2Label.Name = "date2Label";
            date2Label.Size = new Size(414, 19);
            date2Label.TabIndex = 72;
            date2Label.Text = "Dia para buscar os dados da escala de serviço";
            date2Label.Visible = false;
            // 
            // dateTimeService2
            // 
            dateTimeService2.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dateTimeService2.CalendarTitleBackColor = Color.SpringGreen;
            dateTimeService2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimeService2.Format = DateTimePickerFormat.Short;
            dateTimeService2.Location = new Point(636, 346);
            dateTimeService2.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimeService2.Name = "dateTimeService2";
            dateTimeService2.Size = new Size(414, 26);
            dateTimeService2.TabIndex = 71;
            dateTimeService2.Visible = false;
            // 
            // numAtrBox1
            // 
            numAtrBox1.Location = new Point(37, 173);
            numAtrBox1.MaxLength = 4;
            numAtrBox1.Name = "numAtrBox1";
            numAtrBox1.PlaceholderText = "Digite aqui o número do atirador para atualizar dados";
            numAtrBox1.Size = new Size(337, 23);
            numAtrBox1.TabIndex = 90;
            numAtrBox1.KeyPress += numAtrBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(37, 151);
            label3.Name = "label3";
            label3.Size = new Size(279, 19);
            label3.TabIndex = 89;
            label3.Text = "Número do 1º atirador da troca";
            // 
            // numAtrBox2
            // 
            numAtrBox2.Location = new Point(636, 173);
            numAtrBox2.MaxLength = 4;
            numAtrBox2.Name = "numAtrBox2";
            numAtrBox2.PlaceholderText = "Digite aqui o número do atirador para atualizar dados";
            numAtrBox2.Size = new Size(337, 23);
            numAtrBox2.TabIndex = 92;
            numAtrBox2.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label4.Location = new Point(636, 151);
            label4.Name = "label4";
            label4.Size = new Size(279, 19);
            label4.TabIndex = 91;
            label4.Text = "Número do 2º atirador da troca";
            // 
            // btQueryShooters
            // 
            btQueryShooters.AutoSize = true;
            btQueryShooters.BackColor = Color.MediumSeaGreen;
            btQueryShooters.FlatStyle = FlatStyle.Flat;
            btQueryShooters.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btQueryShooters.Location = new Point(386, 215);
            btQueryShooters.Name = "btQueryShooters";
            btQueryShooters.Size = new Size(391, 27);
            btQueryShooters.TabIndex = 93;
            btQueryShooters.Text = "Clique aqui para buscar os dois atiradores da troca de serviço";
            btQueryShooters.UseVisualStyleBackColor = false;
            btQueryShooters.Click += btQueryShooters_Click;
            // 
            // btQueryServices
            // 
            btQueryServices.AutoSize = true;
            btQueryServices.BackColor = Color.MediumSeaGreen;
            btQueryServices.FlatStyle = FlatStyle.Flat;
            btQueryServices.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btQueryServices.Location = new Point(386, 393);
            btQueryServices.Name = "btQueryServices";
            btQueryServices.Size = new Size(349, 27);
            btQueryServices.TabIndex = 94;
            btQueryServices.Text = "Clique aqui para buscar os serviços da troca de serviço";
            btQueryServices.UseVisualStyleBackColor = false;
            btQueryServices.Visible = false;
            btQueryServices.Click += btQueryServices_Click;
            // 
            // btSwap
            // 
            btSwap.AutoSize = true;
            btSwap.BackColor = Color.Lime;
            btSwap.FlatStyle = FlatStyle.Flat;
            btSwap.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSwap.Location = new Point(118, 520);
            btSwap.Name = "btSwap";
            btSwap.Size = new Size(986, 57);
            btSwap.TabIndex = 95;
            btSwap.Text = "Clique aqui para realizar a troca do serviço entre os atiradores";
            btSwap.UseVisualStyleBackColor = false;
            btSwap.Visible = false;
            btSwap.Click += btSwap_Click;
            // 
            // shooter1InfoLabel
            // 
            shooter1InfoLabel.AutoSize = true;
            shooter1InfoLabel.BackColor = Color.Chartreuse;
            shooter1InfoLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            shooter1InfoLabel.Location = new Point(37, 273);
            shooter1InfoLabel.Name = "shooter1InfoLabel";
            shooter1InfoLabel.Padding = new Padding(28, 0, 28, 0);
            shooter1InfoLabel.Size = new Size(182, 19);
            shooter1InfoLabel.TabIndex = 96;
            shooter1InfoLabel.Text = "Info Shooter1";
            shooter1InfoLabel.Visible = false;
            // 
            // shooter2InfoLabel
            // 
            shooter2InfoLabel.AutoSize = true;
            shooter2InfoLabel.BackColor = Color.Chartreuse;
            shooter2InfoLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            shooter2InfoLabel.Location = new Point(636, 273);
            shooter2InfoLabel.Name = "shooter2InfoLabel";
            shooter2InfoLabel.Padding = new Padding(28, 0, 28, 0);
            shooter2InfoLabel.Size = new Size(182, 19);
            shooter2InfoLabel.TabIndex = 97;
            shooter2InfoLabel.Text = "Info Shooter2";
            shooter2InfoLabel.Visible = false;
            // 
            // service1InfoLabel
            // 
            service1InfoLabel.AutoSize = true;
            service1InfoLabel.BackColor = Color.Chartreuse;
            service1InfoLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            service1InfoLabel.Location = new Point(37, 453);
            service1InfoLabel.Name = "service1InfoLabel";
            service1InfoLabel.Padding = new Padding(28, 0, 28, 0);
            service1InfoLabel.Size = new Size(182, 19);
            service1InfoLabel.TabIndex = 98;
            service1InfoLabel.Text = "Info Service1";
            service1InfoLabel.Visible = false;
            // 
            // service2InfoLabel
            // 
            service2InfoLabel.AutoSize = true;
            service2InfoLabel.BackColor = Color.Chartreuse;
            service2InfoLabel.Font = new Font("Consolas", 12F, FontStyle.Bold);
            service2InfoLabel.Location = new Point(636, 453);
            service2InfoLabel.Name = "service2InfoLabel";
            service2InfoLabel.Padding = new Padding(28, 0, 28, 0);
            service2InfoLabel.Size = new Size(182, 19);
            service2InfoLabel.TabIndex = 99;
            service2InfoLabel.Text = "Info Service2";
            service2InfoLabel.Visible = false;
            // 
            // FormSwapService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 610);
            Controls.Add(service2InfoLabel);
            Controls.Add(service1InfoLabel);
            Controls.Add(shooter2InfoLabel);
            Controls.Add(shooter1InfoLabel);
            Controls.Add(btSwap);
            Controls.Add(btQueryServices);
            Controls.Add(btQueryShooters);
            Controls.Add(numAtrBox2);
            Controls.Add(label4);
            Controls.Add(numAtrBox1);
            Controls.Add(label3);
            Controls.Add(date2Label);
            Controls.Add(dateTimeService2);
            Controls.Add(date1Label);
            Controls.Add(dateTimeService1);
            Controls.Add(label1);
            Name = "FormSwapService";
            Text = "FormSwapService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label date1Label;
        private DateTimePicker dateTimeService1;
        private Label date2Label;
        private DateTimePicker dateTimeService2;
        private TextBox numAtrBox1;
        private Label label3;
        private TextBox numAtrBox2;
        private Label label4;
        private Button btQueryShooters;
        private Button btQueryServices;
        private Button btSwap;
        private Label shooter1InfoLabel;
        private Label shooter2InfoLabel;
        private Label service1InfoLabel;
        private Label service2InfoLabel;
    }
}