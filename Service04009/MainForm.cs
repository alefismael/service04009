using Service04009.FormsAtirador;
using Service04009.FormsScaleService;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Service04009
{
    // Form principal do programa
    public partial class MainForm : Form
    {
        private Form? formActive;

        public MainForm()
        {
            InitializeComponent();

            // Aplica tema claro verde
            BackColor = AppTheme.BackgroundColor;
            panel.BackColor = AppTheme.BackgroundColor;
            creatorLabel.ForeColor = AppTheme.TextSecondary;
            serviceLabel.ForeColor = AppTheme.AccentColor;
            serviceLabel.Font = AppTheme.FontSubtitle;
            AppTheme.StyleMenuStrip(menuStrip1);
        }

        // Método para chamar o form de pesquisa personalizada de um atirador
        private void pesquisaPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormAtiradorConsult());
        }

        // Método para chamar o form que mostra todos os atiradores
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormConsultTodos());
        }

        // Método para chamar o form que mostra todos os atiradores que são cfc
        private void btApenasCfc_Click(object sender, EventArgs e)
        {
            changeForm(new FormConsultApenasCfc());
        }

        // Método para chamar o form que mostra todos os atiradores que não são cfc
        private void apenasQuemNãoÉCFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormConsultNotCfc());
        }

        // Método para chamar o form que serve para cadastrar atiradores
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormAddAtirador());
        }

        // Método para chamar o form que pesquisa atiradores por número para poder mudar dados
        private void buscandoPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormUpdateByNumber());
        }

        // Método para chamar o form que pesquisa atiradores por nome para poder mudar dados
        private void buscandoPorNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormUpdateByName());
        }

        // Método para chamar o form que pesquisa atiradores por número para poder remover atirador
        private void buscandoPorNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormDeleteByNumber());
        }

        // Método para chamar o form que pesquisa atiradores por nome para poder remover atirador
        private void buscandoPorNomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            changeForm(new FormDeleteByName());
        }

        private void gerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormCreateScaleService());
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = true;
            creatorLabel.Visible = true;
        }

        private void todasAsEscalasCriadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormShowFullScale());
        }

        // Método interno padrão para carregar um novo form sobre o label do formulário main
        private void changeForm(Form form)
        {
            // Suspende o layout do panel para evitar renderização lenta (flicker)
            panel.SuspendLayout();
            try
            {
                // Se já têm um formActive no main form então feche ele e passe formActive para null
                if (formActive != null)
                {
                    formActive.Close();
                    formActive = null;
                }
                serviceLabel.Visible = false;
                creatorLabel.Visible = false;
                formActive = form;
                formActive.TopLevel = false;
                formActive.FormBorderStyle = FormBorderStyle.None;
                formActive.Dock = DockStyle.Fill;
                panel.Controls.Add(formActive);
                formActive.Show();
            }
            finally
            {
                panel.ResumeLayout(true);
            }
        }

        private void exibirEscalaPorDataDeUmServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            changeForm(new FormShowScaleForServiceData());
        }

        private void excluirEscalaDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormDeleteServiceScale());
        }

        private void porDataDoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormShowServiceForData());
        }

        private void trocaDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormSwapService());
        }

        private void atribuirServiçoAAtiradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormServiceAddShooter());
        }

        private void opcoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormOpcoes());
        }

        private void relatorioEscalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormRelatorio());
        }

        private void relatorioAtiradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormsScaleService.FormRelatorioAtiradores());
        }

        private void importExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormsAtirador.FormImportExportAtiradores());
        }

        private void excluirServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeForm(new FormsScaleService.FormDeleteService());
        }
    }
}
