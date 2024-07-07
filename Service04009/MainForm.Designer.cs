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
            inícioToolStripMenuItem = new ToolStripMenuItem();
            atiradoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            btApenasCfc = new ToolStripMenuItem();
            apenasQuemNãoÉCFCToolStripMenuItem = new ToolStripMenuItem();
            pesquisaPersonalizadaToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            buscandoPorIDToolStripMenuItem = new ToolStripMenuItem();
            buscandoPorNomeToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            buscandoPorNúmeroToolStripMenuItem = new ToolStripMenuItem();
            buscandoPorNomeToolStripMenuItem1 = new ToolStripMenuItem();
            escalaDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            gerarToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem1 = new ToolStripMenuItem();
            todasAsEscalasCriadasToolStripMenuItem = new ToolStripMenuItem();
            exibirEscalaPorDataDeUmServiçoToolStripMenuItem = new ToolStripMenuItem();
            exibirServiçoToolStripMenuItem = new ToolStripMenuItem();
            porDataDoServiçoToolStripMenuItem = new ToolStripMenuItem();
            mudarEscalaToolStripMenuItem = new ToolStripMenuItem();
            trocaDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            atribuirServiçoAAtiradorToolStripMenuItem = new ToolStripMenuItem();
            excluirEscalaDeServiçoToolStripMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            creatorLabel = new Label();
            serviceLabel = new Label();
            menuStrip1.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = Color.DarkGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, atiradoresToolStripMenuItem, escalaDeServiçoToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // inícioToolStripMenuItem
            // 
            resources.ApplyResources(inícioToolStripMenuItem, "inícioToolStripMenuItem");
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.Click += inícioToolStripMenuItem_Click;
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
            atualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscandoPorIDToolStripMenuItem, buscandoPorNomeToolStripMenuItem });
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            // 
            // buscandoPorIDToolStripMenuItem
            // 
            resources.ApplyResources(buscandoPorIDToolStripMenuItem, "buscandoPorIDToolStripMenuItem");
            buscandoPorIDToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            buscandoPorIDToolStripMenuItem.Name = "buscandoPorIDToolStripMenuItem";
            buscandoPorIDToolStripMenuItem.Click += buscandoPorIDToolStripMenuItem_Click;
            // 
            // buscandoPorNomeToolStripMenuItem
            // 
            resources.ApplyResources(buscandoPorNomeToolStripMenuItem, "buscandoPorNomeToolStripMenuItem");
            buscandoPorNomeToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            buscandoPorNomeToolStripMenuItem.Name = "buscandoPorNomeToolStripMenuItem";
            buscandoPorNomeToolStripMenuItem.Click += buscandoPorNomeToolStripMenuItem_Click;
            // 
            // removerToolStripMenuItem
            // 
            resources.ApplyResources(removerToolStripMenuItem, "removerToolStripMenuItem");
            removerToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            removerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscandoPorNúmeroToolStripMenuItem, buscandoPorNomeToolStripMenuItem1 });
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            // 
            // buscandoPorNúmeroToolStripMenuItem
            // 
            resources.ApplyResources(buscandoPorNúmeroToolStripMenuItem, "buscandoPorNúmeroToolStripMenuItem");
            buscandoPorNúmeroToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            buscandoPorNúmeroToolStripMenuItem.Name = "buscandoPorNúmeroToolStripMenuItem";
            buscandoPorNúmeroToolStripMenuItem.Click += buscandoPorNúmeroToolStripMenuItem_Click;
            // 
            // buscandoPorNomeToolStripMenuItem1
            // 
            resources.ApplyResources(buscandoPorNomeToolStripMenuItem1, "buscandoPorNomeToolStripMenuItem1");
            buscandoPorNomeToolStripMenuItem1.BackColor = Color.FromArgb(192, 255, 192);
            buscandoPorNomeToolStripMenuItem1.Name = "buscandoPorNomeToolStripMenuItem1";
            buscandoPorNomeToolStripMenuItem1.Click += buscandoPorNomeToolStripMenuItem1_Click;
            // 
            // escalaDeServiçoToolStripMenuItem
            // 
            resources.ApplyResources(escalaDeServiçoToolStripMenuItem, "escalaDeServiçoToolStripMenuItem");
            escalaDeServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarToolStripMenuItem, exibirToolStripMenuItem1, exibirServiçoToolStripMenuItem, mudarEscalaToolStripMenuItem, excluirEscalaDeServiçoToolStripMenuItem });
            escalaDeServiçoToolStripMenuItem.Name = "escalaDeServiçoToolStripMenuItem";
            // 
            // gerarToolStripMenuItem
            // 
            resources.ApplyResources(gerarToolStripMenuItem, "gerarToolStripMenuItem");
            gerarToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            gerarToolStripMenuItem.Click += gerarToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem1
            // 
            resources.ApplyResources(exibirToolStripMenuItem1, "exibirToolStripMenuItem1");
            exibirToolStripMenuItem1.BackColor = Color.FromArgb(128, 255, 128);
            exibirToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { todasAsEscalasCriadasToolStripMenuItem, exibirEscalaPorDataDeUmServiçoToolStripMenuItem });
            exibirToolStripMenuItem1.Name = "exibirToolStripMenuItem1";
            // 
            // todasAsEscalasCriadasToolStripMenuItem
            // 
            resources.ApplyResources(todasAsEscalasCriadasToolStripMenuItem, "todasAsEscalasCriadasToolStripMenuItem");
            todasAsEscalasCriadasToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            todasAsEscalasCriadasToolStripMenuItem.Name = "todasAsEscalasCriadasToolStripMenuItem";
            todasAsEscalasCriadasToolStripMenuItem.Click += todasAsEscalasCriadasToolStripMenuItem_Click;
            // 
            // exibirEscalaPorDataDeUmServiçoToolStripMenuItem
            // 
            resources.ApplyResources(exibirEscalaPorDataDeUmServiçoToolStripMenuItem, "exibirEscalaPorDataDeUmServiçoToolStripMenuItem");
            exibirEscalaPorDataDeUmServiçoToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            exibirEscalaPorDataDeUmServiçoToolStripMenuItem.Name = "exibirEscalaPorDataDeUmServiçoToolStripMenuItem";
            exibirEscalaPorDataDeUmServiçoToolStripMenuItem.Click += exibirEscalaPorDataDeUmServiçoToolStripMenuItem_Click;
            // 
            // exibirServiçoToolStripMenuItem
            // 
            resources.ApplyResources(exibirServiçoToolStripMenuItem, "exibirServiçoToolStripMenuItem");
            exibirServiçoToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            exibirServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porDataDoServiçoToolStripMenuItem });
            exibirServiçoToolStripMenuItem.Name = "exibirServiçoToolStripMenuItem";
            // 
            // porDataDoServiçoToolStripMenuItem
            // 
            resources.ApplyResources(porDataDoServiçoToolStripMenuItem, "porDataDoServiçoToolStripMenuItem");
            porDataDoServiçoToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            porDataDoServiçoToolStripMenuItem.Name = "porDataDoServiçoToolStripMenuItem";
            porDataDoServiçoToolStripMenuItem.Click += porDataDoServiçoToolStripMenuItem_Click;
            // 
            // mudarEscalaToolStripMenuItem
            // 
            resources.ApplyResources(mudarEscalaToolStripMenuItem, "mudarEscalaToolStripMenuItem");
            mudarEscalaToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            mudarEscalaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trocaDeServiçoToolStripMenuItem, atribuirServiçoAAtiradorToolStripMenuItem });
            mudarEscalaToolStripMenuItem.Name = "mudarEscalaToolStripMenuItem";
            // 
            // trocaDeServiçoToolStripMenuItem
            // 
            resources.ApplyResources(trocaDeServiçoToolStripMenuItem, "trocaDeServiçoToolStripMenuItem");
            trocaDeServiçoToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            trocaDeServiçoToolStripMenuItem.Name = "trocaDeServiçoToolStripMenuItem";
            trocaDeServiçoToolStripMenuItem.Click += trocaDeServiçoToolStripMenuItem_Click;
            // 
            // atribuirServiçoAAtiradorToolStripMenuItem
            // 
            resources.ApplyResources(atribuirServiçoAAtiradorToolStripMenuItem, "atribuirServiçoAAtiradorToolStripMenuItem");
            atribuirServiçoAAtiradorToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            atribuirServiçoAAtiradorToolStripMenuItem.Name = "atribuirServiçoAAtiradorToolStripMenuItem";
            atribuirServiçoAAtiradorToolStripMenuItem.Click += atribuirServiçoAAtiradorToolStripMenuItem_Click;
            // 
            // excluirEscalaDeServiçoToolStripMenuItem
            // 
            resources.ApplyResources(excluirEscalaDeServiçoToolStripMenuItem, "excluirEscalaDeServiçoToolStripMenuItem");
            excluirEscalaDeServiçoToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            excluirEscalaDeServiçoToolStripMenuItem.Name = "excluirEscalaDeServiçoToolStripMenuItem";
            excluirEscalaDeServiçoToolStripMenuItem.Click += excluirEscalaDeServiçoToolStripMenuItem_Click;
            // 
            // panel
            // 
            resources.ApplyResources(panel, "panel");
            panel.BackColor = Color.Lime;
            panel.BackgroundImage = Properties.Resources.img_fundo_service_04009;
            panel.Controls.Add(creatorLabel);
            panel.Controls.Add(serviceLabel);
            panel.Name = "panel";
            // 
            // creatorLabel
            // 
            resources.ApplyResources(creatorLabel, "creatorLabel");
            creatorLabel.BackColor = Color.DarkGreen;
            creatorLabel.ForeColor = Color.Black;
            creatorLabel.Name = "creatorLabel";
            // 
            // serviceLabel
            // 
            resources.ApplyResources(serviceLabel, "serviceLabel");
            serviceLabel.BackColor = Color.DarkGreen;
            serviceLabel.ForeColor = Color.Black;
            serviceLabel.Name = "serviceLabel";
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
            panel.ResumeLayout(false);
            panel.PerformLayout();
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
        private ToolStripMenuItem mudarEscalaToolStripMenuItem;
        private ToolStripMenuItem excluirEscalaDeServiçoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem removerToolStripMenuItem1;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem btApenasCfc;
        private Panel panel;
        private ToolStripMenuItem pesquisaPersonalizadaToolStripMenuItem;
        private ToolStripMenuItem apenasQuemNãoÉCFCToolStripMenuItem;
        private ToolStripMenuItem buscandoPorIDToolStripMenuItem;
        private ToolStripMenuItem buscandoPorNomeToolStripMenuItem;
        private ToolStripMenuItem buscandoPorNúmeroToolStripMenuItem;
        private ToolStripMenuItem buscandoPorNomeToolStripMenuItem1;
        private ToolStripMenuItem inícioToolStripMenuItem;
        private Label creatorLabel;
        private Label serviceLabel;
        private ToolStripMenuItem todasAsEscalasCriadasToolStripMenuItem;
        private ToolStripMenuItem exibirEscalaPorDataDeUmServiçoToolStripMenuItem;
        private ToolStripMenuItem trocaDeServiçoToolStripMenuItem;
        private ToolStripMenuItem atribuirServiçoAAtiradorToolStripMenuItem;
        private ToolStripMenuItem exibirServiçoToolStripMenuItem;
        private ToolStripMenuItem porDataDoServiçoToolStripMenuItem;
    }
}
