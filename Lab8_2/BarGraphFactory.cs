namespace Lab8_2
{
    public class BarGraphFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new BarGraph();
        }

        public override List<DataPoint> CollectData()
        {
            return new List<DataPoint>();
        }
    }
}
