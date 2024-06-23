using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service04009.Forms
{
    public partial class FormAtiradorConsult : Form
    {
        public FormAtiradorConsult()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var db = new ServiceContext())
            {
                table.Visible = true;
                if (checkIsCfc.Checked && checkIsNotCfc.Checked)
                {
                    table.DataSource = db.Shooters.Select(s => new ShooterDT(s)).ToList();
                }
                else if(checkIsCfc.Checked && !checkIsNotCfc.Checked)
                {
                    List<Shooter> cfcs = db.Shooters.Where(s => s.isCfc).ToList();
                    List<ShooterDT> cfcDt = new List<ShooterDT>();
                    foreach (var cfc in cfcs) {
                        cfcDt.Add(new ShooterDT(cfc));
                    }
                    table.DataSource = cfcDt;
                }
            }
        }
    }
}
