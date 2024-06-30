﻿using System;
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
    public partial class FormConsultApenasCfc : Form
    {
        public FormConsultApenasCfc()
        {
            InitializeComponent();
            using (var db = new ServiceContext())
            {
                table.DataSource =  db.Shooters.OrderBy(s => s.numAtr).Where(s=> s.isCfc).Select(shoot => new ShooterDT(shoot)).ToList();
            }
        }
    }
}
