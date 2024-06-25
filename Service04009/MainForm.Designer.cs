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
            menuStrip1 = new MenuStrip();
            atiradoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            btApenasCfc = new ToolStripMenuItem();
            apenasQuemNãoÉCFCToolStripMenuItem = new ToolStripMenuItem();
            pesquisaPersonalizadaToolStripMenuItem = new ToolStripMenuItem();
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
            panel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = Color.DarkGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { atiradoresToolStripMenuItem, escalaDeServiçoToolStripMenuItem, serviçoToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // atiradoresToolStripMenuItem
            // 
            resources.ApplyResources(atiradoresToolStripMenuItem, "atiradoresToolStripMenuItem");
            atiradoresToolStripMenuItem.BackColor = Color.DarkGreen;
            atiradoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, exibirToolStripMenuItem, atualizarToolStripMenuItem, removerToolStripMenuItem });
            atiradoresToolStripMenuItem.Name = "atiradoresToolStripMenuItem";
            // 
            // cadastrarToolStripMenuItem
            // 
            resources.ApplyResources(cadastrarToolStripMenuItem, "cadastrarToolStripMenuItem");
            cadastrarToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem
            // 
            resources.ApplyResources(exibirToolStripMenuItem, "exibirToolStripMenuItem");
            exibirToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, btApenasCfc, apenasQuemNãoÉCFCToolStripMenuItem, pesquisaPersonalizadaToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            // 
            // todosToolStripMenuItem
            // 
            resources.ApplyResources(todosToolStripMenuItem, "todosToolStripMenuItem");
            todosToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // btApenasCfc
            // 
            resources.ApplyResources(btApenasCfc, "btApenasCfc");
            btApenasCfc.BackColor = Color.FromArgb(192, 255, 192);
            btApenasCfc.Name = "btApenasCfc";
            btApenasCfc.Click += btApenasCfc_Click;
            // 
            // apenasQuemNãoÉCFCToolStripMenuItem
            // 
            resources.ApplyResources(apenasQuemNãoÉCFCToolStripMenuItem, "apenasQuemNãoÉCFCToolStripMenuItem");
            apenasQuemNãoÉCFCToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            apenasQuemNãoÉCFCToolStripMenuItem.Name = "apenasQuemNãoÉCFCToolStripMenuItem";
            apenasQuemNãoÉCFCToolStripMenuItem.Click += apenasQuemNãoÉCFCToolStripMenuItem_Click;
            // 
            // pesquisaPersonalizadaToolStripMenuItem
            // 
            resources.ApplyResources(pesquisaPersonalizadaToolStripMenuItem, "pesquisaPersonalizadaToolStripMenuItem");
            pesquisaPersonalizadaToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            pesquisaPersonalizadaToolStripMenuItem.Name = "pesquisaPersonalizadaToolStripMenuItem";
            pesquisaPersonalizadaToolStripMenuItem.Click += pesquisaPersonalizadaToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            resources.ApplyResources(atualizarToolStripMenuItem, "atualizarToolStripMenuItem");
            atualizarToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            // 
            // removerToolStripMenuItem
            // 
            resources.ApplyResources(removerToolStripMenuItem, "removerToolStripMenuItem");
            removerToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
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
            // panel
            // 
            resources.ApplyResources(panel, "panel");
            panel.BackColor = Color.Lime;
            panel.BackgroundImage = Properties.Resources.img_fundo_service_04009;
            panel.Name = "panel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripMenuItem btApenasCfc;
        private Panel panel;
        private ToolStripMenuItem pesquisaPersonalizadaToolStripMenuItem;
        private ToolStripMenuItem apenasQuemNãoÉCFCToolStripMenuItem;
    }
}
