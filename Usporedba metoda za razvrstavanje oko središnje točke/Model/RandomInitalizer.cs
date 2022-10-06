using System;
using System.Collections.Generic;

namespace ZavrsniRad
{
    class RandomInitalizer : IClusterCenterInitializer
    {
        public Cluster[] initializeClusterCentres(Point[] points, int clusterCount)
        {
            Cluster[] clusters = new Cluster[clusterCount];
            List<Point> centroids = new List<Point>();
            Random rnd = new Random();
            for (int i = 0; i < clusterCount; i++)
            {
                Point centroid;
                do
                {
                    centroid = points[rnd.Next(points.Length)];
                } while (centroids.Contains(centroid));
                clusters[i] = new Cluster(i, new Point(centroid));
                centroids.Add(centroid);
            }
            return clusters;
        }
    }
}
