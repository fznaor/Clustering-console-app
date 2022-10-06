using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad
{
    class KmeansppInitializer : IClusterCenterInitializer
    {
        int distanceMeasure;

        public KmeansppInitializer(int distance)
        {
            this.distanceMeasure = distance;
        }

        public Cluster[] initializeClusterCentres(Point[] points, int clusterCount)
        {
            Cluster[] clusters = new Cluster[clusterCount];
            Random rnd = new Random();
            Point firstCentroid = points[rnd.Next(points.Length)];
            clusters[0] = new Cluster(0, new Point(firstCentroid));
            for (int i = 1; i < clusterCount; i++)
            {
                double[] minSquaredDistances = getSmallestSquaredDistances(points, clusters, i);
                double minSquaredDistanceSum = getSumOfMinSquaredDistances(minSquaredDistances);
                double seed = rnd.NextDouble() * minSquaredDistanceSum;
                double sum = 0;
                for (int j = 0; j < minSquaredDistances.Length; j++)
                {
                    sum += minSquaredDistances[j];
                    if (seed < sum)
                    {
                        Point newCentroid = points[j];
                        clusters[i] = new Cluster(i, new Point(newCentroid));
                        break;
                    }
                }
            }
            return clusters;
        }

        private double[] getSmallestSquaredDistances(Point[] points, Cluster[] clusters, int currentClusterCount)
        {
            double[] distances = new double[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                double minSquaredDistance = calculateDistance(points[i], clusters[0].centroid);
                for (int j = 1; j < currentClusterCount; j++)
                {
                    if (calculateDistance(points[i], clusters[j].centroid) < minSquaredDistance)
                        minSquaredDistance = calculateDistance(points[i], clusters[j].centroid);
                }
                distances[i] = minSquaredDistance;
            }
            return distances;
        }

        private double getSumOfMinSquaredDistances(double[] minSquaredDistances)
        {
            double sum = 0;
            for (int i = 0; i < minSquaredDistances.Length; i++)
            {
                sum += minSquaredDistances[i];
            }
            return sum;
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
