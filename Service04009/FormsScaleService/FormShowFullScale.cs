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
    public partial class FormShowFullScale : Form
    {
        public FormShowFullScale()
        {
            InitializeComponent();

            using (var db = new ServiceContext())
            {
                table.DataSource = db.ServiceScales.OrderBy(s => s.id).Select(scale => new ServiceScaleDT(scale)).ToList();
            }
        }
    }
}
