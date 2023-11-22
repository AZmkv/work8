namespace Lab8_2
{
    public class LineGraph : IGraph
    {
        public void Draw(List<DataPoint> dataPoints)
        {
            Console.WriteLine("Drawing Line Graph");
            foreach (var point in dataPoints)
            {
                Console.WriteLine($"Point: ({point.X}, {point.Y})");
            }
        }
    }
}
