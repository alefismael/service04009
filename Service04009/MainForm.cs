using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Service04009.FormsAtirador;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Service04009
{
    public partial class MainForm : Form
    {
        private Form? formActive;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pesquisaPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            formActive = new FormAtiradorConsult();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            formActive = new FormConsultTodos();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        private void btApenasCfc_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            formActive = new FormConsultApenasCfc();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        private void apenasQuemN„o…CFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            formActive = new FormConsultNotCfc();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            formActive = new FormAddAtirador();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        private void buscandoPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            formActive = new FormUpdateByNumber();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }

        private void buscandoPorNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formActive != null)
            {
                formActive.Close();
                formActive = null;
            }
            formActive = new FormUpdateByName();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }
    }
}
