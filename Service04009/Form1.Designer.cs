namespace Service04009
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            atiradoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            escalaDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            gerarToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            gerardocWordToolStripMenuItem = new ToolStripMenuItem();
            serviçoToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            removerToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkGreen;
            menuStrip1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { atiradoresToolStripMenuItem, escalaDeServiçoToolStripMenuItem, serviçoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1264, 38);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // atiradoresToolStripMenuItem
            // 
            atiradoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, exibirToolStripMenuItem, atualizarToolStripMenuItem, removerToolStripMenuItem });
            atiradoresToolStripMenuItem.Name = "atiradoresToolStripMenuItem";
            atiradoresToolStripMenuItem.Size = new Size(120, 34);
            atiradoresToolStripMenuItem.Text = "Atiradores";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(174, 34);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // exibirToolStripMenuItem
            // 
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            exibirToolStripMenuItem.Size = new Size(174, 34);
            exibirToolStripMenuItem.Text = "Exibir";
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(140, 34);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new Size(174, 34);
            atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(174, 34);
            removerToolStripMenuItem.Text = "Remover";
            removerToolStripMenuItem.Click += removerToolStripMenuItem_Click;
            // 
            // escalaDeServiçoToolStripMenuItem
            // 
            escalaDeServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarToolStripMenuItem, exibirToolStripMenuItem1, editarToolStripMenuItem, gerardocWordToolStripMenuItem });
            escalaDeServiçoToolStripMenuItem.Name = "escalaDeServiçoToolStripMenuItem";
            escalaDeServiçoToolStripMenuItem.Size = new Size(183, 34);
            escalaDeServiçoToolStripMenuItem.Text = "Escala de Serviço";
            // 
            // gerarToolStripMenuItem
            // 
            gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            gerarToolStripMenuItem.Size = new Size(237, 34);
            gerarToolStripMenuItem.Text = "Criar";
            // 
            // exibirToolStripMenuItem1
            // 
            exibirToolStripMenuItem1.Name = "exibirToolStripMenuItem1";
            exibirToolStripMenuItem1.Size = new Size(237, 34);
            exibirToolStripMenuItem1.Text = "Exibir";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(237, 34);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // gerardocWordToolStripMenuItem
            // 
            gerardocWordToolStripMenuItem.Name = "gerardocWordToolStripMenuItem";
            gerardocWordToolStripMenuItem.Size = new Size(237, 34);
            gerardocWordToolStripMenuItem.Text = "Gerar .doc Word";
            // 
            // serviçoToolStripMenuItem
            // 
            serviçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, consultarToolStripMenuItem, editarToolStripMenuItem1, removerToolStripMenuItem1 });
            serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            serviçoToolStripMenuItem.Size = new Size(91, 34);
            serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(174, 34);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(174, 34);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(174, 34);
            editarToolStripMenuItem1.Text = "Editar";
            // 
            // removerToolStripMenuItem1
            // 
            removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            removerToolStripMenuItem1.Size = new Size(174, 34);
            removerToolStripMenuItem1.Text = "Remover";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DarkGreen;
            dataGridView1.Location = new Point(50, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1164, 575);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1264, 681);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Service04009";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atiradoresToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem exibirToolStripMenuItem;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStripMenuItem escalaDeServiçoToolStripMenuItem;
        private ToolStripMenuItem serviçoToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
        private ToolStripMenuItem gerarToolStripMenuItem;
        private ToolStripMenuItem exibirToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem gerardocWordToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem removerToolStripMenuItem1;
        private ToolStripMenuItem todosToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}
