namespace ZavrsniRad
{
    public class Cluster
    {
        int index;
        int dimension;
        public Point centroid { get; set; }

        public Cluster(int index, Point centroid)
        {
            this.index = index;
            this.centroid = centroid;
            this.dimension = centroid.dimension;
        }
    }
}
