using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsniRad
{
    class Kmeans
    {
        private Point[] points;
        public Cluster[] clusters { get; private set; }
        private int clusterCount;
        public int[] results { get; private set; }
        protected int maxIterations;
        public int iterationCount { get; private set; }
        private IClusterCenterInitializer initializer;
        private int distanceMeasure;
        
        public Kmeans(Point[] points, int clusterCount, int maxIterations, IClusterCenterInitializer initializer, int distanceMeasure)
        {
            this.points = points;
            this.clusterCount = clusterCount;
            results = new int[points.Length];
            this.maxIterations = maxIterations;
            iterationCount = 0;
            this.initializer = initializer;
            this.distanceMeasure = distanceMeasure;
        }

        public void performKmeans()
        {
            clusters = initializer.initializeClusterCentres(points, clusterCount);
            for (int i = 0; i < maxIterations; i++)
            {
                iterationCount++;
                bool clusterChanged = updateClusters();
                if (!clusterChanged) return;
                updateCentroids();
            }
        }

        private bool updateClusters()
        {
            bool clusterChanged = false;
            for (int i = 0; i < points.Length; i++) 
            {
                int nearestCluster = findNearestCluster(points[i]);
                if (results[i] != nearestCluster)
                {
                    results[i] = nearestCluster;
                    clusterChanged = true;
                }
            }
            return clusterChanged;
        }

        private int findNearestCluster(Point point)
        {
            int nearestCluster = 0;
            double nearestDistance = calculateDistance(point, clusters[0].centroid);
            for (int j = 1; j < clusters.Length; j++)
            {
                double distance = calculateDistance(point, clusters[j].centroid);
                if (distance < nearestDistance)
                {
                    nearestCluster = j;
                    nearestDistance = distance;
                }
            }
            return nearestCluster;
        }

        private void updateCentroids()
        {
            double[][] coordinateSums = new double[clusters.Length][];
            for (int i = 0; i < clusters.Length; i++)
            {
                coordinateSums[i] = new double[points[0].dimension];
            }
            int[] clusterSizes = new int[clusters.Length];
            for (int i = 0; i < points.Length; i++) 
            {
                for (int j = 0; j < points[i].dimension; j++)
                {
                    coordinateSums[results[i]][j] += points[i].coordinates[j];
                }
                clusterSizes[results[i]]++;
            }
            for (int i = 0; i < clusters.Length; i++)
            {
                for (int j = 0; j < clusters[i].centroid.dimension; j++)
                {
                    clusters[i].centroid.coordinates[j] = coordinateSums[i][j] / clusterSizes[i];
                }
            }
        }

        private double calculateDistance(Point p1, Point p2)
        {
            switch (distanceMeasure)
            {
                case 1: return DistanceMetrics.calculateSquareEuclideanDistance(p1, p2);
                default: return DistanceMetrics.calculateManhattanDistance(p1, p2);
            }
        }
    }
}