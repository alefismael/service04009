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
    public partial class FormDeleteByNumber : BaseChildForm
    {

        private Shooter? shooter;

        public FormDeleteByNumber()
        {
            InitializeComponent();
            ArrangeLayout();
        }

        private void ArrangeLayout()
        {
            label1.Location = new Point(20, 10);
            label3.Location = new Point(30, 60);
            label3.Padding = Padding.Empty;
            numAtrBox.Location = new Point(30, 85);
            numAtrBox.Size = new Size(280, 25);
            btQuery.Location = new Point(320, 83);
            btQuery.Size = new Size(340, 28);
            infoLabel.Location = new Point(680, 80);
            infoLabel.Padding = new Padding(10, 4, 10, 4);
            table.Location = new Point(30, 125);
            table.Size = new Size(1185, 280);
            table.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            btRemover.Location = new Point(300, 425);
            btRemover.Size = new Size(600, 48);
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
