using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service04009.FormsScaleService
{
    public partial class FormDeleteService : BaseChildForm
    {
        private ServiceScale? _serviceScale;
        private List<Service>? _services;

        public FormDeleteService()
        {
            InitializeComponent();
        }

        private void btQuery_Click(object? sender, EventArgs e)
        {
            using var db = new ServiceContext();
            var date = DateOnly.FromDateTime(dateTime.Value);

            var serviceScale = db.ServiceScales
                .Include(sc => sc.Services).ThenInclude(s => s.Commanders)
                .Include(sc => sc.Services).ThenInclude(s => s.Permanences)
                .Include(sc => sc.Services).ThenInclude(s => s.Sentinels)
                .FirstOrDefault(sc => sc.firstDay <= date && sc.lastDay >= date);

            if (serviceScale == null)
            {
                MessageBox.Show($"Nenhuma escala encontrada para a data {date:dd/MM/yyyy}.",
                    "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetUI();
                return;
            }

            _serviceScale = serviceScale;
            _services = serviceScale.Services.OrderBy(s => s.Date).ToList();

            infoLabel.Visible = true;
            infoLabel.BackColor = Color.Lime;
            infoLabel.Text = $"Escala de {serviceScale.firstDay:dd/MM/yyyy} a {serviceScale.lastDay:dd/MM/yyyy}  —  {_services.Count} serviço(s)";

            // Montar DataTable para exibição
            table.DataSource = ServiceDT.ToDataTable(_services);
            table.Visible = true;
            lblSelecione.Visible = true;
            btRemover.Visible = true;
        }

        private void btRemover_Click(object? sender, EventArgs e)
        {
            if (_services == null || _serviceScale == null || table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um serviço na tabela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o ID do serviço selecionado
            var selectedRow = table.SelectedRows[0];
            if (!int.TryParse(selectedRow.Cells["ID"]?.Value?.ToString(), out int serviceId))
            {
                MessageBox.Show("Não foi possível identificar o serviço selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var serviceToDelete = _services.FirstOrDefault(s => s.Id == serviceId);
            if (serviceToDelete == null)
            {
                MessageBox.Show("Serviço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dateStr = serviceToDelete.Date.ToString("dd/MM/yyyy (dddd)");
            var confirm = MessageBox.Show(
                $"Deseja excluir o serviço do dia {dateStr}?\n\n" +
                "Isso irá subtrair 1 do número de serviços tirados de cada atirador escalado neste serviço.",
                "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirm != DialogResult.OK) return;

            try
            {
                using var db = new ServiceContext();

                // Recarregar o serviço com relacionamentos do contexto atual
                var svc = db.Services
                    .Include(s => s.Commanders)
                    .Include(s => s.Permanences)
                    .Include(s => s.Sentinels)
                    .FirstOrDefault(s => s.Id == serviceId);

                if (svc == null)
                {
                    MessageBox.Show("Serviço não encontrado no banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Subtrair serviços dos atiradores
                svc.SubtractShooterNumberService();

                // Remover serviço
                db.Services.Remove(svc);
                db.SaveChanges();

                // Se a escala ficou sem serviços, remover também
                var remainingServices = db.Services.Where(s => s.ServiceScaleId == _serviceScale.id).Count();
                if (remainingServices == 0)
                {
                    var scaleToRemove = db.ServiceScales.Find(_serviceScale.id);
                    if (scaleToRemove != null)
                    {
                        db.ServiceScales.Remove(scaleToRemove);
                        db.SaveChanges();
                    }

                    MessageBox.Show(
                        $"Serviço do dia {dateStr} excluído.\nA escala ficou sem serviços e também foi removida.",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUI();
                    infoLabel.Visible = true;
                    infoLabel.BackColor = Color.Lime;
                    infoLabel.Text = $"Serviço excluído. Escala removida (sem serviços restantes).";
                }
                else
                {
                    MessageBox.Show($"Serviço do dia {dateStr} excluído com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar a tabela
                    _services.RemoveAll(s => s.Id == serviceId);
                    table.DataSource = ServiceDT.ToDataTable(_services);
                    infoLabel.Text = $"Escala de {_serviceScale.firstDay:dd/MM/yyyy} a {_serviceScale.lastDay:dd/MM/yyyy}  —  {_services.Count} serviço(s) restante(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetUI()
        {
            infoLabel.Visible = false;
            table.Visible = false;
            table.DataSource = null;
            lblSelecione.Visible = false;
            btRemover.Visible = false;
            _serviceScale = null;
            _services = null;
        }
    }
}
