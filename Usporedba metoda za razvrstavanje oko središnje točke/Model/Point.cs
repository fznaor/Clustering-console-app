namespace ZavrsniRad
{
    public class Point
    {
        public int dimension { get; private set; }
        public double[] coordinates { get; private set; }

        public Point(double[] coordinates)
        {
            this.coordinates = coordinates;
            this.dimension = coordinates.Length;
        }
        public Point(int dimension)
        {
            this.dimension = dimension;
            this.coordinates = new double[dimension];
        }
        public Point(Point point)
        {
            this.dimension = point.dimension;
            this.coordinates = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                coordinates[i] = point.coordinates[i];
            }
        }

        public bool Equals(Point other)
        {
            if (other == null) return false;
            for (int i = 0; i < dimension; i++)
            {
                if (other.coordinates[i] != this.coordinates[i]) return false;
            }
            return true;
        }
    }
}
