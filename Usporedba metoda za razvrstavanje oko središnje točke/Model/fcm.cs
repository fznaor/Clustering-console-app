using System;

namespace ZavrsniRad
{
    class FCM
    {
        Point[] points;
        public Cluster[] clusters { get; private set; }
        int clusterCount;
        public double[][] membership { get; private set; }
        int maxIterations;
        public int iterationCount { get; private set; }
        double m;
        double epsilon;
        int distanceMeasure;

        public FCM(Point[] points, int clusterCount, int maxIterations, double m, double epsilon, int distanceMeasure)
        {
            this.points = points;
            this.clusterCount = clusterCount;
            initClusters();
            membership = new double[points.Length][];
            for (int i = 0; i < points.Length; i++)
                membership[i] = new double[clusterCount];
            this.maxIterations = maxIterations;
            iterationCount = 0;
            this.m = m;
            this.epsilon = epsilon;
            this.distanceMeasure = distanceMeasure;
        }

        private void initClusters()
        {
            clusters = new Cluster[clusterCount];
            for (int i = 0; i < clusterCount; i++)
            {
                clusters[i] = new Cluster(i, new Point(points[0].dimension));
            }
        }

        public void performFCM()
        {
            initMembership();
            for (int i = 0; i < maxIterations; i++)
            {
                iterationCount++;
                updateCentroids();
                bool hasConverged = updateMembership();
                if (hasConverged) return;
            }
        }

        private void initMembership()
        {
            Random rnd = new Random();
            for(int i = 0; i < points.Length; i++)
            {
                double coefficient = 1;
                for(int j = 0; j < clusterCount - 1; j++)
                {
                    membership[i][j] = rnd.NextDouble() * coefficient;
                    coefficient -= membership[i][j];
                }
                membership[i][clusterCount - 1] = coefficient;
            }
        }

        private void updateCentroids()
        {
            for(int i = 0; i < clusterCount; i++)
            {
                for(int j = 0; j < clusters[i].centroid.dimension; j++)
                {
                    double numerator = 0, denominator = 0;
                    for (int k = 0; k < points.Length; k++)
                    {
                        denominator += Math.Pow(membership[k][i], m);
                        numerator += (Math.Pow(membership[k][i], m) * (points[k].coordinates[j]));
                    }
                    clusters[i].centroid.coordinates[j] = numerator / denominator;
                }
            }
        }

        private bool updateMembership()
        {
            double norm = 0; //infinity norma matrice za provjeru konvergencije
            for(int i = 0; i < points.Length; i++)
            {
                double max = 0;
                for(int j = 0; j < clusterCount; j++)
                {
                    double sum = 0;
                    for(int k = 0; k < clusterCount; k++)
                    {
                        sum += Math.Pow((calculateDistance(points[i], clusters[j].centroid)/
                            calculateDistance(points[i], clusters[k].centroid)), 1.0 / (m - 1));
                    }
                    double newMembership = 1 / sum;
                    if (Math.Abs(newMembership - membership[i][j]) > max) max = Math.Abs(newMembership - membership[i][j]);
                    membership[i][j] = newMembership;
                }
                norm += max;
            }
            return norm < epsilon;
        }

        private double calculateDistance(Point p1, Point p2)
        {
            switch (distanceMeasure)
            {
                case 1: return DistanceMetrics.calculateSquareEuclideanDistance(p1, p2);
                default: return DistanceMetrics.calculateSquareManhattanDistance(p1, p2);
            }
        }
    }
}
