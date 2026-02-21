using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service04009.FormsScaleService
{
    public partial class FormShowFullScale : BaseChildForm
    {
        public FormShowFullScale()
        {
            InitializeComponent();
            ArrangeLayout();

            using (var db = new ServiceContext())
            {
                table.DataSource = db.ServiceScales.OrderBy(s => s.id).Select(scale => new ServiceScaleDT(scale)).ToList();
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
