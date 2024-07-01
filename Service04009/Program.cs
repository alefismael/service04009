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