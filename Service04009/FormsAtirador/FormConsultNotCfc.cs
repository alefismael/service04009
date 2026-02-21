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
    public partial class FormConsultNotCfc : BaseChildForm
    {
        public FormConsultNotCfc()
        {
            InitializeComponent();
            ArrangeLayout();
            using (var db = new ServiceContext())
            {
                table.DataSource = db.Shooters.OrderBy(s => s.numAtr).Where(s => !s.isCfc).Select(shoot => new ShooterDT(shoot)).ToList();
            }
        }

        private void ArrangeLayout()
        {
            label1.Location = new Point(20, 10);
            table.Location = new Point(20, 60);
            table.Size = new Size(1200, 530);
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }
    }
}
