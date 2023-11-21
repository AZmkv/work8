using Lab8_1;

class Program
{
    static void Main()
    {
        ConfigurationManager configManager = ConfigurationManager.Instance;
        //конфігураційні налаштування
        configManager.DisplayConfiguration();

        Console.Write("Enter new logging mode: ");
        string newLoggingMode = Console.ReadLine();
        configManager.ChangeLoggingMode(newLoggingMode);

        Console.Write("Enter new database connection: ");
        string newDatabaseConnection = Console.ReadLine();
        configManager.ChangeDatabaseConnection(newDatabaseConnection);

        configManager.SaveConfiguration();

        configManager.DisplayConfiguration();
    }
}