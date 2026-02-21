using Microsoft.EntityFrameworkCore;

namespace Service04009
{
    internal static class Program
    {

        // Esse Mutex serve para n�o permitir que esse aplicativo seja aberto duas vezes
        private static Mutex? mutex = null;
        private const string MutexName = "YourUniqueAppNameMutex";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            mutex = new Mutex(true, MutexName, out createdNew);
            using (var db = new ServiceContext())
            {
                db.Database.EnsureCreated();

                // Garantir que a tabela ServiceConfigs existe (para bancos existentes)
                try
                {
                    _ = db.ServiceConfigs.FirstOrDefault();
                }
                catch
                {
                    db.Database.ExecuteSqlRaw(@"
                        CREATE TABLE IF NOT EXISTS ServiceConfigs (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            SundayPermanences INTEGER NOT NULL DEFAULT 2,
                            SundaySentinels INTEGER NOT NULL DEFAULT 3,
                            SundayCommanders INTEGER NOT NULL DEFAULT 1,
                            SundayCommanderMustBeCfc INTEGER NOT NULL DEFAULT 1,
                            MondayPermanences INTEGER NOT NULL DEFAULT 1,
                            MondaySentinels INTEGER NOT NULL DEFAULT 3,
                            MondayCommanders INTEGER NOT NULL DEFAULT 1,
                            MondayCommanderMustBeCfc INTEGER NOT NULL DEFAULT 1,
                            TuesdayPermanences INTEGER NOT NULL DEFAULT 1,
                            TuesdaySentinels INTEGER NOT NULL DEFAULT 3,
                            TuesdayCommanders INTEGER NOT NULL DEFAULT 1,
                            TuesdayCommanderMustBeCfc INTEGER NOT NULL DEFAULT 1,
                            WednesdayPermanences INTEGER NOT NULL DEFAULT 1,
                            WednesdaySentinels INTEGER NOT NULL DEFAULT 3,
                            WednesdayCommanders INTEGER NOT NULL DEFAULT 1,
                            WednesdayCommanderMustBeCfc INTEGER NOT NULL DEFAULT 1,
                            ThursdayPermanences INTEGER NOT NULL DEFAULT 1,
                            ThursdaySentinels INTEGER NOT NULL DEFAULT 3,
                            ThursdayCommanders INTEGER NOT NULL DEFAULT 1,
                            ThursdayCommanderMustBeCfc INTEGER NOT NULL DEFAULT 1,
                            FridayPermanences INTEGER NOT NULL DEFAULT 2,
                            FridaySentinels INTEGER NOT NULL DEFAULT 3,
                            FridayCommanders INTEGER NOT NULL DEFAULT 1,
                            FridayCommanderMustBeCfc INTEGER NOT NULL DEFAULT 1,
                            SaturdayPermanences INTEGER NOT NULL DEFAULT 2,
                            SaturdaySentinels INTEGER NOT NULL DEFAULT 3,
                            SaturdayCommanders INTEGER NOT NULL DEFAULT 1,
                            SaturdayCommanderMustBeCfc INTEGER NOT NULL DEFAULT 1
                        )");
                }
            }

            if (!createdNew)
            {
                // Se o Mutex j� existir, significa que outra inst�ncia est� em execu��o
                MessageBox.Show("O aplicativo j� est� em execu��o.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());  // Inicia o form Main
        }
    }
}