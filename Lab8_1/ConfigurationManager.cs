namespace Lab8_1
{
    class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private string loggingMode;
        private string databaseConnection;

        private ConfigurationManager()
        {
            loggingMode = "DefaultLogging";
            databaseConnection = "DefaultConnection";
        }
        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }
        public void DisplayConfiguration()
        {
            Console.WriteLine($"Logging Mode: {loggingMode}");
            Console.WriteLine($"Database Connection: {databaseConnection}");
        }
        public void ChangeLoggingMode(string newLoggingMode)
        {
            loggingMode = newLoggingMode;
        }
        public void ChangeDatabaseConnection(string newConnection)
        {
            databaseConnection = newConnection;
        }
        public void SaveConfiguration()
        {
            Console.WriteLine("Configuration saved.");
        }
    }
}
