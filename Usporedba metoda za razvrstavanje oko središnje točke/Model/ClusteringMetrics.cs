using System;

namespace ZavrsniRad
{
    class ClusteringMetrics
    {
        public static double daviesBouldinIndex(Point[] points, int[] pointClusters, Cluster[] clusters)
        {
            double[] distanceAverages = new double[clusters.Length];
            double[] distanceSums = new double[clusters.Length];
            int[] clusterSizes = new int[clusters.Length];
            double sum = 0;
            for(int i = 0; i < points.Length; i++)
            {
                distanceSums[pointClusters[i]] += DistanceMetrics.calculateEuclideanDistance(points[i], clusters[pointClusters[i]].centroid);
                clusterSizes[pointClusters[i]]++;
            }
            for (int i = 0; i < clusters.Length; i++)
            {
                distanceAverages[i] = distanceSums[i] / clusterSizes[i];
            }
            for (int i = 0; i < clusters.Length; i++)
            {
                double max = 0;
                for(int j = 0; j < clusters.Length; j++)
                {
                    if (i == j) continue;
                    double value = (distanceAverages[i] + distanceAverages[j]) / DistanceMetrics.calculateEuclideanDistance(clusters[i].centroid, clusters[j].centroid);
                    if (value > max) max = value;
                }
                sum += max;
            }
            return sum / clusters.Length;
        }

        public static double calinskiHarabaszIndex(Point[] points, int[] pointClusters, Cluster[] clusters)
        {
            double ssb = 0, ssw = 0;
            int[] clusterSizes = new int[clusters.Length];
            double[] globalMeans = new double[points[0].dimension];
            for(int i = 0; i < points.Length; i++)
            {
                clusterSizes[pointClusters[i]]++;
                ssw += DistanceMetrics.calculateSquareEuclideanDistance(points[i], clusters[pointClusters[i]].centroid);
                for (int j = 0; j < points[i].dimension; j++)
                    globalMeans[j] += points[i].coordinates[j];
            }
            for (int j = 0; j < points[0].dimension; j++)
                globalMeans[j] /= points.Length;
            Point globalCentroid = new Point(globalMeans);
            for (int i = 0; i < clusters.Length; i++)
            {
                if (clusterSizes[i] != 0)
                    ssb += clusterSizes[i] * DistanceMetrics.calculateSquareEuclideanDistance(clusters[i].centroid, globalCentroid);
            }
            return (ssb / ssw) * ((points.Length - clusters.Length) / ((double)clusters.Length - 1));
        }

        public static double silhouetteCoefficient(Point[] points, int[] pointClusters, int clusterCount)
        {
            double sum = 0;
            for (int i = 0; i < points.Length; i++)
            {
                double[] distanceSums = new double[clusterCount];
                double[] clusterSizes = new double[clusterCount];
                for (int j = 0; j < points.Length; j++)
                {
                    if (i == j) continue;
                    clusterSizes[pointClusters[j]]++;
                    distanceSums[pointClusters[j]] += DistanceMetrics.calculateEuclideanDistance(points[i], points[j]);
                }
                if (clusterSizes[pointClusters[i]] == 0) continue;
                double a = distanceSums[pointClusters[i]] / clusterSizes[pointClusters[i]];
                double b = Double.MaxValue;
                for (int j = 0; j < clusterCount; j++)
                {
                    if (j == pointClusters[i]) continue;
                    double mean = distanceSums[j] / clusterSizes[j];
                    if (mean < b) b = mean;
                }
                if (a > b) sum += (b - a) / a;
                else sum += (b - a) / b;
            }
            return sum / points.Length;
        }
    }
}
