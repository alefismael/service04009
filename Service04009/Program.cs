namespace Service04009
{
    internal static class Program
    {

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

            if (!createdNew)
            {
                // Se o Mutex já existir, significa que outra instância está em execução
                MessageBox.Show("O aplicativo já está em execução.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}