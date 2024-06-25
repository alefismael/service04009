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
    public partial class FormAddAtirador : Form
    {
        public FormAddAtirador()
        {
            InitializeComponent();
        }

        private void checkIsCfc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsCfc.Checked == true && checkIsNotCfc.Checked == true)
            {
                checkIsNotCfc.Checked = false;
            }
        }

        private void checkIsNotCfc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsNotCfc.Checked == true && checkIsCfc.Checked == true)
            {
                checkIsCfc.Checked = false;
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

        private void sunMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (sunMorning.Checked == true)
            {
                sunMorning.Text = "Disponível";
            }
            else
            {
                sunMorning.Text = "Indisponível";
            }
        }
    }
}