using System.Windows.Forms;

namespace Service04009
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            atiradoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            btApenasCfc = new ToolStripMenuItem();
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
            panel = new Panel();
            pesquisaPersonalizadaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = Color.DarkGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { atiradoresToolStripMenuItem, escalaDeServiçoToolStripMenuItem, serviçoToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            // 
            // atiradoresToolStripMenuItem
            // 
            resources.ApplyResources(atiradoresToolStripMenuItem, "atiradoresToolStripMenuItem");
            atiradoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, exibirToolStripMenuItem, atualizarToolStripMenuItem, removerToolStripMenuItem });
            atiradoresToolStripMenuItem.Name = "atiradoresToolStripMenuItem";
            // 
            // cadastrarToolStripMenuItem
            // 
            resources.ApplyResources(cadastrarToolStripMenuItem, "cadastrarToolStripMenuItem");
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            // 
            // exibirToolStripMenuItem
            // 
            resources.ApplyResources(exibirToolStripMenuItem, "exibirToolStripMenuItem");
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, btApenasCfc, pesquisaPersonalizadaToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            // 
            // todosToolStripMenuItem
            // 
            resources.ApplyResources(todosToolStripMenuItem, "todosToolStripMenuItem");
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // btApenasCfc
            // 
            resources.ApplyResources(btApenasCfc, "btApenasCfc");
            btApenasCfc.Name = "btApenasCfc";
            btApenasCfc.Click += apenasCfcToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            resources.ApplyResources(atualizarToolStripMenuItem, "atualizarToolStripMenuItem");
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            // 
            // removerToolStripMenuItem
            // 
            resources.ApplyResources(removerToolStripMenuItem, "removerToolStripMenuItem");
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Click += removerToolStripMenuItem_Click;
            // 
            // escalaDeServiçoToolStripMenuItem
            // 
            resources.ApplyResources(escalaDeServiçoToolStripMenuItem, "escalaDeServiçoToolStripMenuItem");
            escalaDeServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarToolStripMenuItem, exibirToolStripMenuItem1, editarToolStripMenuItem, gerardocWordToolStripMenuItem });
            escalaDeServiçoToolStripMenuItem.Name = "escalaDeServiçoToolStripMenuItem";
            // 
            // gerarToolStripMenuItem
            // 
            resources.ApplyResources(gerarToolStripMenuItem, "gerarToolStripMenuItem");
            gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            // 
            // exibirToolStripMenuItem1
            // 
            resources.ApplyResources(exibirToolStripMenuItem1, "exibirToolStripMenuItem1");
            exibirToolStripMenuItem1.Name = "exibirToolStripMenuItem1";
            // 
            // editarToolStripMenuItem
            // 
            resources.ApplyResources(editarToolStripMenuItem, "editarToolStripMenuItem");
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            // 
            // gerardocWordToolStripMenuItem
            // 
            resources.ApplyResources(gerardocWordToolStripMenuItem, "gerardocWordToolStripMenuItem");
            gerardocWordToolStripMenuItem.Name = "gerardocWordToolStripMenuItem";
            // 
            // serviçoToolStripMenuItem
            // 
            resources.ApplyResources(serviçoToolStripMenuItem, "serviçoToolStripMenuItem");
            serviçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, consultarToolStripMenuItem, editarToolStripMenuItem1, removerToolStripMenuItem1 });
            serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            // 
            // adicionarToolStripMenuItem
            // 
            resources.ApplyResources(adicionarToolStripMenuItem, "adicionarToolStripMenuItem");
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            // 
            // consultarToolStripMenuItem
            // 
            resources.ApplyResources(consultarToolStripMenuItem, "consultarToolStripMenuItem");
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            // 
            // editarToolStripMenuItem1
            // 
            resources.ApplyResources(editarToolStripMenuItem1, "editarToolStripMenuItem1");
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            // 
            // removerToolStripMenuItem1
            // 
            resources.ApplyResources(removerToolStripMenuItem1, "removerToolStripMenuItem1");
            removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Green;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkGreen;
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            // 
            // panel
            // 
            resources.ApplyResources(panel, "panel");
            panel.Name = "panel";
            // 
            // pesquisaPersonalizadaToolStripMenuItem
            // 
            resources.ApplyResources(pesquisaPersonalizadaToolStripMenuItem, "pesquisaPersonalizadaToolStripMenuItem");
            pesquisaPersonalizadaToolStripMenuItem.Name = "pesquisaPersonalizadaToolStripMenuItem";
            pesquisaPersonalizadaToolStripMenuItem.Click += pesquisaPersonalizadaToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            Controls.Add(dataGridView1);
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
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
        private ToolStripMenuItem btApenasCfc;
        private Panel panel;
        private ToolStripMenuItem pesquisaPersonalizadaToolStripMenuItem;
    }
}
