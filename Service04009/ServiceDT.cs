using System.ComponentModel;
using System.Data;

namespace Service04009
{
    /// <summary>
    /// Gera um DataTable dinâmico a partir de uma lista de serviços.
    /// As colunas de Comandantes, Permanências e Sentinelas são criadas
    /// conforme a quantidade máxima encontrada nos serviços fornecidos.
    /// </summary>
    internal static class ServiceDT
    {
        public static DataTable ToDataTable(IEnumerable<Service> services)
        {
            var list = services.ToList();
            var dt = new DataTable();

            // Colunas fixas
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Data", typeof(string));

            // Descobrir a quantidade máxima de cada função entre todos os serviços
            int maxCmd = list.Count > 0 ? list.Max(s => s.Commanders?.Count ?? 0) : 1;
            int maxPerm = list.Count > 0 ? list.Max(s => s.Permanences?.Count ?? 0) : 1;
            int maxSent = list.Count > 0 ? list.Max(s => s.Sentinels?.Count ?? 0) : 1;

            // Garantir pelo menos 1 coluna de cada
            maxCmd = Math.Max(maxCmd, 1);
            maxPerm = Math.Max(maxPerm, 1);
            maxSent = Math.Max(maxSent, 1);

            // Criar colunas dinâmicas
            for (int i = 1; i <= maxCmd; i++)
                dt.Columns.Add(maxCmd == 1 ? "Comandante" : $"Comandante {i}", typeof(string));

            for (int i = 1; i <= maxPerm; i++)
                dt.Columns.Add(maxPerm == 1 ? "Permanência" : $"Permanência {i}", typeof(string));

            for (int i = 1; i <= maxSent; i++)
                dt.Columns.Add(maxSent == 1 ? "Sentinela" : $"Sentinela {i}", typeof(string));

            // Preencher linhas
            foreach (var service in list)
            {
                var row = dt.NewRow();
                row["ID"] = service.Id;
                row["Data"] = service.Date.ToString("dd/MM/yyyy (ddd)");

                // Comandantes
                for (int i = 0; i < maxCmd; i++)
                {
                    string colName = maxCmd == 1 ? "Comandante" : $"Comandante {i + 1}";
                    if (service.Commanders != null && i < service.Commanders.Count)
                        row[colName] = $"{service.Commanders[i].warName} ({service.Commanders[i].numAtr})";
                    else
                        row[colName] = "—";
                }

                // Permanências
                for (int i = 0; i < maxPerm; i++)
                {
                    string colName = maxPerm == 1 ? "Permanência" : $"Permanência {i + 1}";
                    if (service.Permanences != null && i < service.Permanences.Count)
                        row[colName] = $"{service.Permanences[i].warName} ({service.Permanences[i].numAtr})";
                    else
                        row[colName] = "—";
                }

                // Sentinelas
                for (int i = 0; i < maxSent; i++)
                {
                    string colName = maxSent == 1 ? "Sentinela" : $"Sentinela {i + 1}";
                    if (service.Sentinels != null && i < service.Sentinels.Count)
                        row[colName] = $"{service.Sentinels[i].warName} ({service.Sentinels[i].numAtr})";
                    else
                        row[colName] = "—";
                }

                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        /// Conveniência para um único serviço.
        /// </summary>
        public static DataTable ToDataTable(Service service)
        {
            return ToDataTable(new[] { service });
        }
    }
}
