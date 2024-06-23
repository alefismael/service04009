using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Service04009.Forms;
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
            formActive = new FormAtiradorConsult();
            formActive.TopLevel = false;
            formActive.FormBorderStyle = FormBorderStyle.None;
            formActive.Dock = DockStyle.Fill;
            panel.Controls.Add(formActive);
            formActive.Show();
        }
    }
}
