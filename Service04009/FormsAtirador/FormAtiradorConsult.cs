using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
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
                string warName = warNameBox.Text.Trim();
                int? numAtr = string.IsNullOrEmpty(numAtrBox.Text) ? (int?)null : int.Parse(numAtrBox.Text);
                int? numService = string.IsNullOrEmpty(numServiceBox.Text) ? (int?)null : int.Parse(numServiceBox.Text);
                bool isCfcChecked = checkIsCfc.Checked;
                bool isNotCfcChecked = checkIsNotCfc.Checked;

                var query = db.Shooters.AsQueryable();

                if (!string.IsNullOrEmpty(warName))
                {
                    query = query.Where(s => s.warName == warName);
                }

                if (numAtr.HasValue)
                {
                    query = query.Where(s => s.numAtr == numAtr.Value);
                }

                if (numService.HasValue)
                {
                    query = query.Where(s => s.numOfService - s.numServiceExtra == numService.Value);
                }

                if (!isCfcChecked && isNotCfcChecked)
                {
                    query = query.Where(s => !s.isCfc); // Supondo que existe uma propriedade `isCfc` para filtrar atiradores não CFC
                }
                else if (isCfcChecked && !isNotCfcChecked)
                {
                    query = query.Where(s => s.isCfc); // Supondo que existe uma propriedade `isCfc` para filtrar atiradores CFC
                }

                var listQuery = query.ToList();
                if (!isCfcChecked && !isNotCfcChecked)
                {
                    listQuery.Clear();
                }

                if (listQuery.Count == 0)
                {
                    MessageBox.Show("Sem atiradores encontrados na pesquisa.");
                    table.Visible = false;
                }
                else
                {
                    table.Visible = true;
                    table.DataSource = listQuery.OrderBy(s => s.numAtr).Select(shoot => new ShooterDT(shoot)).ToList();
                }


            }

        }

        private void warNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Conjunto de caracteres adicionais permitidos
            char[] allowedSpecialChars = { (char)8, ' ', '.' };

            // Verificar se é uma letra ou caractere permitido
            if (char.IsLetter(e.KeyChar) || allowedSpecialChars.Contains(e.KeyChar))
            {
                return;
            }

            // Caso contrário, cancelar o evento de tecla
            e.Handled = true;
        }

        private void numAtrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void numServiceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
