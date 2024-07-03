using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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
        }

        // Método para chamar o form de pesquisa personalizada de um atirador
        private void pesquisaPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se já têm um formActive no main form então feche ele e passe formActive para null
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormAtiradorConsult();
            formActive.TopLevel = false;  // Diz para o formActive não ser um formulário TopLevel (que não pode estar dentro de outro)
            formActive.FormBorderStyle = FormBorderStyle.None;  //  Tira as bordas do formulário
            formActive.Dock = DockStyle.Fill;  //  Faz o formulário ocupar toda a tela do main form sem tirar a barra de navegação
            panel.Controls.Add(formActive);  // Passa o form para o panel para ele poder ser exibido corretamente
            formActive.Show();
        }

        // Método para chamar o form que mostra todos os atiradores
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormConsultTodos();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        // Método para chamar o form que mostra todos os atiradores que são cfc
        private void btApenasCfc_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormConsultApenasCfc();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        // Método para chamar o form que mostra todos os atiradores que não são cfc
        private void apenasQuemNãoÉCFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormConsultNotCfc();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        // Método para chamar o form que serve para cadastrar atiradores
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormAddAtirador();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        // Método para chamar o form que pesquisa atiradores por número para poder mudar dados
        private void buscandoPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormUpdateByNumber();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        // Método para chamar o form que pesquisa atiradores por nome para poder mudar dados
        private void buscandoPorNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormUpdateByName();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        // Método para chamar o form que pesquisa atiradores por número para poder remover atirador
        private void buscandoPorNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormDeleteByNumber();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        // Método para chamar o form que pesquisa atiradores por noma para poder remover atirador
        private void buscandoPorNomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormDeleteByName();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        private void gerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            serviceLabel.Visible = false;
            creatorLabel.Visible = false;
            formActive = new FormCreateScaleService();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
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
    }
}
