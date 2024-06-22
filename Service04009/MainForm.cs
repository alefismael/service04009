using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;

namespace Service04009
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var db = new ServiceContext())
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = db.Shooters.ToList();
            }
        }

        private void apenasCfcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                dataGridView1.Visible = true;
                var atr = db.Shooters.ToList();
                List<Shooter> cfc = new List<Shooter>();
                foreach(var at in atr)
                {
                    if (at.isCfc)
                    {
                        cfc.Add(at);
                    }
                }

                dataGridView1.DataSource = cfc;
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}
