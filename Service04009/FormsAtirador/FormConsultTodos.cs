﻿using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class FormConsultTodos : Form
    {
        public FormConsultTodos()
        {
            InitializeComponent();
            using (var db = new ServiceContext())
            {
                List<ShooterDT> listDT = new List<ShooterDT>();
                foreach (var shooter in db.Shooters.ToList())
                {
                    listDT.Add(new ShooterDT(shooter));
                }
                table.DataSource = listDT;
            }
        }
    }
}
