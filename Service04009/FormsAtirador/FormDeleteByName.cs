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
    public partial class FormDeleteByName : Form
    {
        private Shooter? shooter;

        public FormDeleteByName()
        {
            InitializeComponent();
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

        private void btQuery_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                if (warNameBox.Text.Trim() == "")
                {
                    MessageBox.Show("Sem atirador encontrado");
                }
                else
                {
                    var shooterQuery = db.Shooters.Where(s => s.warName == warNameBox.Text.Trim()).ToList();
                    if (shooterQuery.Count == 0)
                    {
                        MessageBox.Show("Sem atirador encontrado");
                        shooter = null;
                        infoLabel.Text = "Sem atirador informado para remover os dados";
                        infoLabel.BackColor = Color.Red;
                        table.DataSource = null;
                        btRemover.Visible = false;
                    }
                    else
                    {
                        shooter = shooterQuery.FirstOrDefault();
                        if (shooter != null)
                        {
                            table.DataSource = new List<ShooterDT> { new ShooterDT(shooter) };
                        }
                        infoLabel.Text = "Esse é o atirador que você removerá os dados.";

                        infoLabel.BackColor = Color.Lime;
                        btRemover.Visible = true;
                    }
                }
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (shooter == null)
            {
                MessageBox.Show("Não há um atirador informado para remover.");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Deseja continuar com a remoção do atirador {shooter.numAtr} {shooter.warName}?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    using (var db = new ServiceContext())
                    {
                        db.Shooters.Where(s => s.warName == shooter.warName).ExecuteDelete();
                        db.SaveChanges();
                        MessageBox.Show($"O atirador {shooter.numAtr} {shooter.warName} foi removido.");
                        infoLabel.Text = $"Atirador {shooter.numAtr} {shooter.warName} foi removido.";
                        btRemover.Visible = false;
                        warNameBox.Text = "";
                        infoLabel.BackColor = Color.Lime;
                        shooter = null;
                        table.DataSource = null;
                        warNameBox.Text = "";
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Operação cancelada.");
                    warNameBox.Text = "";
                    infoLabel.Text = "Sem atirador informado para remover os dados";
                    infoLabel.BackColor = Color.Red;
                    table.DataSource = null;
                    shooter = null;
                }
            }
        }
    }
}
