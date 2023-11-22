using System;

namespace Lab8_2
{
    public abstract class GraphFactory
    {
        public abstract IGraph CreateGraph();

        public abstract List<DataPoint> CollectData();
    }
}
