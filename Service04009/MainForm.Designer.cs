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
            opcoesToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            relatorioEscalaToolStripMenuItem = new ToolStripMenuItem();
            relatorioAtiradoresToolStripMenuItem = new ToolStripMenuItem();
            importExportToolStripMenuItem = new ToolStripMenuItem();
            excluirServicoToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.BackColor = AppTheme.SurfaceColor;
            menuStrip1.ForeColor = AppTheme.TextPrimary;
            menuStrip1.Items.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, atiradoresToolStripMenuItem, escalaDeServiçoToolStripMenuItem, opcoesToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            // 
            // inícioToolStripMenuItem
            // 
            resources.ApplyResources(inícioToolStripMenuItem, "inícioToolStripMenuItem");
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            inícioToolStripMenuItem.Click += inícioToolStripMenuItem_Click;
            // 
            // atiradoresToolStripMenuItem
            // 
            resources.ApplyResources(atiradoresToolStripMenuItem, "atiradoresToolStripMenuItem");
            atiradoresToolStripMenuItem.BackColor = AppTheme.SurfaceColor;
            atiradoresToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            atiradoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, exibirToolStripMenuItem, atualizarToolStripMenuItem, removerToolStripMenuItem, importExportToolStripMenuItem });
            atiradoresToolStripMenuItem.Name = "atiradoresToolStripMenuItem";
            // 
            // cadastrarToolStripMenuItem
            // 
            resources.ApplyResources(cadastrarToolStripMenuItem, "cadastrarToolStripMenuItem");
            cadastrarToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            cadastrarToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem
            // 
            resources.ApplyResources(exibirToolStripMenuItem, "exibirToolStripMenuItem");
            exibirToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            exibirToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, btApenasCfc, apenasQuemNãoÉCFCToolStripMenuItem, pesquisaPersonalizadaToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            // 
            // todosToolStripMenuItem
            // 
            resources.ApplyResources(todosToolStripMenuItem, "todosToolStripMenuItem");
            todosToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // btApenasCfc
            // 
            resources.ApplyResources(btApenasCfc, "btApenasCfc");
            btApenasCfc.BackColor = AppTheme.SurfaceLight;
            btApenasCfc.Name = "btApenasCfc";
            btApenasCfc.Click += btApenasCfc_Click;
            // 
            // apenasQuemNãoÉCFCToolStripMenuItem
            // 
            resources.ApplyResources(apenasQuemNãoÉCFCToolStripMenuItem, "apenasQuemNãoÉCFCToolStripMenuItem");
            apenasQuemNãoÉCFCToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            apenasQuemNãoÉCFCToolStripMenuItem.Name = "apenasQuemNãoÉCFCToolStripMenuItem";
            apenasQuemNãoÉCFCToolStripMenuItem.Click += apenasQuemNãoÉCFCToolStripMenuItem_Click;
            // 
            // pesquisaPersonalizadaToolStripMenuItem
            // 
            resources.ApplyResources(pesquisaPersonalizadaToolStripMenuItem, "pesquisaPersonalizadaToolStripMenuItem");
            pesquisaPersonalizadaToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            pesquisaPersonalizadaToolStripMenuItem.Name = "pesquisaPersonalizadaToolStripMenuItem";
            pesquisaPersonalizadaToolStripMenuItem.Click += pesquisaPersonalizadaToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            resources.ApplyResources(atualizarToolStripMenuItem, "atualizarToolStripMenuItem");
            atualizarToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            atualizarToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            atualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscandoPorIDToolStripMenuItem, buscandoPorNomeToolStripMenuItem });
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            // 
            // buscandoPorIDToolStripMenuItem
            // 
            resources.ApplyResources(buscandoPorIDToolStripMenuItem, "buscandoPorIDToolStripMenuItem");
            buscandoPorIDToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            buscandoPorIDToolStripMenuItem.Name = "buscandoPorIDToolStripMenuItem";
            buscandoPorIDToolStripMenuItem.Click += buscandoPorIDToolStripMenuItem_Click;
            // 
            // buscandoPorNomeToolStripMenuItem
            // 
            resources.ApplyResources(buscandoPorNomeToolStripMenuItem, "buscandoPorNomeToolStripMenuItem");
            buscandoPorNomeToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            buscandoPorNomeToolStripMenuItem.Name = "buscandoPorNomeToolStripMenuItem";
            buscandoPorNomeToolStripMenuItem.Click += buscandoPorNomeToolStripMenuItem_Click;
            // 
            // removerToolStripMenuItem
            // 
            resources.ApplyResources(removerToolStripMenuItem, "removerToolStripMenuItem");
            removerToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            removerToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            removerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscandoPorNúmeroToolStripMenuItem, buscandoPorNomeToolStripMenuItem1 });
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            // 
            // buscandoPorNúmeroToolStripMenuItem
            // 
            resources.ApplyResources(buscandoPorNúmeroToolStripMenuItem, "buscandoPorNúmeroToolStripMenuItem");
            buscandoPorNúmeroToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            buscandoPorNúmeroToolStripMenuItem.Name = "buscandoPorNúmeroToolStripMenuItem";
            buscandoPorNúmeroToolStripMenuItem.Click += buscandoPorNúmeroToolStripMenuItem_Click;
            // 
            // buscandoPorNomeToolStripMenuItem1
            // 
            resources.ApplyResources(buscandoPorNomeToolStripMenuItem1, "buscandoPorNomeToolStripMenuItem1");
            buscandoPorNomeToolStripMenuItem1.BackColor = AppTheme.SurfaceLight;
            buscandoPorNomeToolStripMenuItem1.Name = "buscandoPorNomeToolStripMenuItem1";
            buscandoPorNomeToolStripMenuItem1.Click += buscandoPorNomeToolStripMenuItem1_Click;
            // 
            // escalaDeServiçoToolStripMenuItem
            // 
            resources.ApplyResources(escalaDeServiçoToolStripMenuItem, "escalaDeServiçoToolStripMenuItem");
            escalaDeServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarToolStripMenuItem, exibirToolStripMenuItem1, exibirServiçoToolStripMenuItem, mudarEscalaToolStripMenuItem, excluirEscalaDeServiçoToolStripMenuItem, excluirServicoToolStripMenuItem });
            escalaDeServiçoToolStripMenuItem.Name = "escalaDeServiçoToolStripMenuItem";
            // 
            // gerarToolStripMenuItem
            // 
            resources.ApplyResources(gerarToolStripMenuItem, "gerarToolStripMenuItem");
            gerarToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            gerarToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            gerarToolStripMenuItem.Click += gerarToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem1
            // 
            resources.ApplyResources(exibirToolStripMenuItem1, "exibirToolStripMenuItem1");
            exibirToolStripMenuItem1.BackColor = AppTheme.SurfaceLight;
            exibirToolStripMenuItem1.ForeColor = AppTheme.TextPrimary;
            exibirToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { todasAsEscalasCriadasToolStripMenuItem, exibirEscalaPorDataDeUmServiçoToolStripMenuItem });
            exibirToolStripMenuItem1.Name = "exibirToolStripMenuItem1";
            // 
            // todasAsEscalasCriadasToolStripMenuItem
            // 
            resources.ApplyResources(todasAsEscalasCriadasToolStripMenuItem, "todasAsEscalasCriadasToolStripMenuItem");
            todasAsEscalasCriadasToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            todasAsEscalasCriadasToolStripMenuItem.Name = "todasAsEscalasCriadasToolStripMenuItem";
            todasAsEscalasCriadasToolStripMenuItem.Click += todasAsEscalasCriadasToolStripMenuItem_Click;
            // 
            // exibirEscalaPorDataDeUmServiçoToolStripMenuItem
            // 
            resources.ApplyResources(exibirEscalaPorDataDeUmServiçoToolStripMenuItem, "exibirEscalaPorDataDeUmServiçoToolStripMenuItem");
            exibirEscalaPorDataDeUmServiçoToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            exibirEscalaPorDataDeUmServiçoToolStripMenuItem.Name = "exibirEscalaPorDataDeUmServiçoToolStripMenuItem";
            exibirEscalaPorDataDeUmServiçoToolStripMenuItem.Click += exibirEscalaPorDataDeUmServiçoToolStripMenuItem_Click;
            // 
            // exibirServiçoToolStripMenuItem
            // 
            resources.ApplyResources(exibirServiçoToolStripMenuItem, "exibirServiçoToolStripMenuItem");
            exibirServiçoToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            exibirServiçoToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            exibirServiçoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porDataDoServiçoToolStripMenuItem });
            exibirServiçoToolStripMenuItem.Name = "exibirServiçoToolStripMenuItem";
            // 
            // porDataDoServiçoToolStripMenuItem
            // 
            resources.ApplyResources(porDataDoServiçoToolStripMenuItem, "porDataDoServiçoToolStripMenuItem");
            porDataDoServiçoToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            porDataDoServiçoToolStripMenuItem.Name = "porDataDoServiçoToolStripMenuItem";
            porDataDoServiçoToolStripMenuItem.Click += porDataDoServiçoToolStripMenuItem_Click;
            // 
            // mudarEscalaToolStripMenuItem
            // 
            resources.ApplyResources(mudarEscalaToolStripMenuItem, "mudarEscalaToolStripMenuItem");
            mudarEscalaToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            mudarEscalaToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            mudarEscalaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trocaDeServiçoToolStripMenuItem, atribuirServiçoAAtiradorToolStripMenuItem });
            mudarEscalaToolStripMenuItem.Name = "mudarEscalaToolStripMenuItem";
            // 
            // trocaDeServiçoToolStripMenuItem
            // 
            resources.ApplyResources(trocaDeServiçoToolStripMenuItem, "trocaDeServiçoToolStripMenuItem");
            trocaDeServiçoToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            trocaDeServiçoToolStripMenuItem.Name = "trocaDeServiçoToolStripMenuItem";
            trocaDeServiçoToolStripMenuItem.Click += trocaDeServiçoToolStripMenuItem_Click;
            // 
            // atribuirServiçoAAtiradorToolStripMenuItem
            // 
            resources.ApplyResources(atribuirServiçoAAtiradorToolStripMenuItem, "atribuirServiçoAAtiradorToolStripMenuItem");
            atribuirServiçoAAtiradorToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            atribuirServiçoAAtiradorToolStripMenuItem.Name = "atribuirServiçoAAtiradorToolStripMenuItem";
            atribuirServiçoAAtiradorToolStripMenuItem.Click += atribuirServiçoAAtiradorToolStripMenuItem_Click;
            // 
            // excluirEscalaDeServiçoToolStripMenuItem
            // 
            resources.ApplyResources(excluirEscalaDeServiçoToolStripMenuItem, "excluirEscalaDeServiçoToolStripMenuItem");
            excluirEscalaDeServiçoToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            excluirEscalaDeServiçoToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            excluirEscalaDeServiçoToolStripMenuItem.Name = "excluirEscalaDeServiçoToolStripMenuItem";
            excluirEscalaDeServiçoToolStripMenuItem.Click += excluirEscalaDeServiçoToolStripMenuItem_Click;
            //
            // importExportToolStripMenuItem
            //
            importExportToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            importExportToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            importExportToolStripMenuItem.Text = "Importar / Exportar";
            importExportToolStripMenuItem.Size = new Size(200, 22);
            importExportToolStripMenuItem.Click += importExportToolStripMenuItem_Click;
            //
            // excluirServicoToolStripMenuItem
            //
            excluirServicoToolStripMenuItem.BackColor = AppTheme.SurfaceLight;
            excluirServicoToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            excluirServicoToolStripMenuItem.Name = "excluirServicoToolStripMenuItem";
            excluirServicoToolStripMenuItem.Text = "Excluir serviço da escala";
            excluirServicoToolStripMenuItem.Size = new Size(250, 22);
            excluirServicoToolStripMenuItem.Click += excluirServicoToolStripMenuItem_Click;
            // 
            // opcoesToolStripMenuItem
            // 
            opcoesToolStripMenuItem.Name = "opcoesToolStripMenuItem";
            opcoesToolStripMenuItem.Text = "Opções";
            opcoesToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            opcoesToolStripMenuItem.Size = new Size(62, 20);
            opcoesToolStripMenuItem.Click += opcoesToolStripMenuItem_Click;
            // 
            // relatoriosToolStripMenuItem
            //
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatorioEscalaToolStripMenuItem, relatorioAtiradoresToolStripMenuItem });
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Text = "Relatórios";
            relatoriosToolStripMenuItem.ForeColor = AppTheme.TextPrimary;
            relatoriosToolStripMenuItem.Size = new Size(73, 20);
            //
            // relatorioEscalaToolStripMenuItem
            //
            relatorioEscalaToolStripMenuItem.Name = "relatorioEscalaToolStripMenuItem";
            relatorioEscalaToolStripMenuItem.Text = "Escala de Serviço";
            relatorioEscalaToolStripMenuItem.Click += relatorioEscalaToolStripMenuItem_Click;
            //
            // relatorioAtiradoresToolStripMenuItem
            //
            relatorioAtiradoresToolStripMenuItem.Name = "relatorioAtiradoresToolStripMenuItem";
            relatorioAtiradoresToolStripMenuItem.Text = "Atiradores";
            relatorioAtiradoresToolStripMenuItem.Click += relatorioAtiradoresToolStripMenuItem_Click;
            // 
            // panel
            // 
            resources.ApplyResources(panel, "panel");
            panel.BackColor = AppTheme.BackgroundColor;
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(creatorLabel);
            panel.Controls.Add(serviceLabel);
            panel.Name = "panel";
            // 
            // creatorLabel
            // 
            resources.ApplyResources(creatorLabel, "creatorLabel");
            creatorLabel.BackColor = AppTheme.BackgroundColor;
            creatorLabel.ForeColor = AppTheme.TextPrimary;
            creatorLabel.Name = "creatorLabel";
            // 
            // serviceLabel
            // 
            resources.ApplyResources(serviceLabel, "serviceLabel");
            serviceLabel.BackColor = AppTheme.BackgroundColor;
            serviceLabel.ForeColor = AppTheme.TextPrimary;
            serviceLabel.Name = "serviceLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Sizable;
            MainMenuStrip = menuStrip1;
            MaximizeBox = true;
            Name = "MainForm";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem opcoesToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem relatorioEscalaToolStripMenuItem;
        private ToolStripMenuItem relatorioAtiradoresToolStripMenuItem;
        private ToolStripMenuItem importExportToolStripMenuItem;
        private ToolStripMenuItem excluirServicoToolStripMenuItem;
    }
}
