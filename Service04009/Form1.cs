using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;

namespace Service04009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = new List<Shooter>{
                new Shooter(01, "Álef", true),
                new Shooter(02, "Queiroz", false)
            };
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}
