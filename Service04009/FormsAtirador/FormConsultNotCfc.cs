using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service04009.FormsAtirador
{
    public partial class FormConsultNotCfc : Form
    {
        public FormConsultNotCfc()
        {
            InitializeComponent();
            using (var db = new ServiceContext())
            {
                List<ShooterDT> listDT = new List<ShooterDT>();
                foreach (var shooter in db.Shooters.Where(s => !s.isCfc).ToList())
                {
                    listDT.Add(new ShooterDT(shooter));
                }
                table.DataSource = listDT;
            }
        }
    }
}
