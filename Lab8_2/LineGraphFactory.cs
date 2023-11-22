namespace Lab8_2
{
    public class LineGraphFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new LineGraph();
        }

        public override List<DataPoint> CollectData()
        {
            return new List<DataPoint>();
        }
    }
}
