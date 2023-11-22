using Lab8_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of graph (Line/Bar/Pie):");
        string graphType = Console.ReadLine();

        GraphFactory graphFactory;

        switch (graphType.ToLower())
        {
            case "line":
                graphFactory = new LineGraphFactory();
                break;
            case "bar":
                graphFactory = new BarGraphFactory();
                break;
            case "pie":
                graphFactory = new PieChartFactory();
                break;
            default:
                Console.WriteLine("Invalid graph type.");
                return;
        }

        IGraph graph = graphFactory.CreateGraph();
        List<DataPoint> dataPoints = new List<DataPoint>();
        GetDataFromUser(dataPoints);

        graph.Draw(dataPoints);

        Console.ReadLine();
    }

    static void GetDataFromUser(List<DataPoint> dataPoints)
    {
        Console.Write("Enter X value: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Y value: ");
        int y = Convert.ToInt32(Console.ReadLine());

        dataPoints.Add(new DataPoint { X = x, Y = y });

        Console.Write("Do you want to enter more data? (yes/no): ");
        string moreData = Console.ReadLine().ToLower();

        if (moreData == "yes")
        {
            GetDataFromUser(dataPoints);
        }
    }
}