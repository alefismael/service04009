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

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var db = new ServiceContext())
            {
                dataGridView1.Visible = true;
                var shootersList = db.Shooters.ToList();
                List<ShooterDT> shotersDt = new List<ShooterDT>();
                foreach (var shooter in shootersList)
                {
                    shotersDt.Add(new ShooterDT(shooter));
                }
                dataGridView1.DataSource = shotersDt;
            }
        }

        private void apenasCfcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                dataGridView1.Visible = true;
                var atr = db.Shooters.ToList();
                List<ShooterDT> cfc = new List<ShooterDT>();
                foreach (var at in atr)
                {
                    if (at.isCfc)
                    {
                        cfc.Add(new ShooterDT(at));
                    }
                }

                dataGridView1.DataSource = cfc;
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
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
