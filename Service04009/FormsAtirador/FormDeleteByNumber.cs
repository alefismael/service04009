using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service04009.FormsAtirador
{
    public partial class FormDeleteByNumber : Form
    {

        private Shooter? shooter;

        public FormDeleteByNumber()
        {
            InitializeComponent();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            using (var db = new ServiceContext())
            {
                if (numAtrBox.Text.Trim() == "")
                {
                    MessageBox.Show("Sem atirador encontrado");
                }
                else
                {
                    var shooterQuery = db.Shooters.Where(s => s.numAtr == int.Parse(numAtrBox.Text.Trim())).ToList();
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

        private void numAtrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
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
                        db.Shooters.Where(s => s.numAtr == shooter.numAtr).ExecuteDelete();
                        db.SaveChanges();
                        MessageBox.Show($"O atirador {shooter.numAtr} {shooter.warName} foi removido.");
                        infoLabel.Text = $"Atirador {shooter.numAtr} {shooter.warName} foi removido.";
                        btRemover.Visible = false;
                        numAtrBox.Text = "";
                        infoLabel.BackColor = Color.Lime;
                        shooter = null;
                        table.DataSource = null;
                        numAtrBox.Text = "";
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Operação cancelada.");
                    numAtrBox.Text = "";
                    infoLabel.Text = "Sem atirador informado para remover os dados";
                    infoLabel.BackColor = Color.Red;
                    table.DataSource = null;
                    shooter = null;
                }
            }
        }
    }
}
