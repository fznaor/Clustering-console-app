using System;

namespace ZavrsniRad
{
    class Kmedoids
    {
        Point[] points;
        public Cluster[] clusters { get; private set; }
        int clusterCount;
        public int[] results { get; private set; }
        int maxIterations;
        public int iterationCount { get; private set; }
        IClusterCenterInitializer initializer;
        int distanceMeasure;
        double[][] distances;
        double[] distancesToNearestMedoid;
        double[] distancesToSecondNearestMedoid;

        public Kmedoids(Point[] points, int clusterCount, int maxIterations, IClusterCenterInitializer initializer, int distance)
        {
            this.points = points;
            this.clusterCount = clusterCount;
            results = new int[points.Length];
            this.maxIterations = maxIterations;
            iterationCount = 0;
            this.initializer = initializer;
            this.distanceMeasure = distance;
            initDistanceMatrix();
            this.distancesToNearestMedoid = new double[points.Length];
            this.distancesToSecondNearestMedoid = new double[points.Length];
        }

        private void initDistanceMatrix()
        {
            distances = new double[points.Length][];
            for (int i = 0; i < points.Length; i++)
            {
                distances[i] = new double[points.Length];
            }
            for (int i = 0; i < points.Length; i++) { 
                for (int j = i; j < points.Length; j++)
                {
                    distances[i][j] = calculateDistance(points[i], points[j]);
                    distances[j][i] = distances[i][j];
                }
            }
        }

        public void performKmedoids()
        {
            clusters = initializer.initializeClusterCentres(points, clusterCount);
            for (int i = 0; i < maxIterations; i++)
            {
                iterationCount++;
                updateClusters();
                bool hasSwapped = swap();
                if (!hasSwapped) return;
            }
            updateClusters();
        }

        private void updateClusters()
        {
            for (int i = 0; i < points.Length; i++)
            {
                int nearestCluster = findNearestCluster(points[i]);
                if (results[i] != nearestCluster)
                {
                    results[i] = nearestCluster;
                }
            }
            updateDistancesToMedoids();
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

        private void updateDistancesToMedoids()
        {
            for (int i = 0; i < points.Length; i++)
            {
                distancesToNearestMedoid[i] = calculateDistance(points[i], clusters[results[i]].centroid);
                double minDistance = Double.MaxValue;
                for (int j = 0; j < clusterCount; j++)
                {
                    if (j == results[i]) continue;
                    double distance = calculateDistance(points[i], clusters[j].centroid);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                    }
                }
                distancesToSecondNearestMedoid[i] = minDistance;
            }
        }

        private bool swap()
        {
            double bestCostChange = 0;
            int candidatePoint = 0, candidateCluster = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (isMedoid(points[i])) continue;
                double[] clusterCostChanges = new double[clusterCount];
                for (int j = 0; j < clusterCount; j++)
                {
                    clusterCostChanges[j] = -1 * distancesToNearestMedoid[i];
                }
                for (int j = 0; j < points.Length; j++)
                {
                    if (i == j) continue;
                    double distance = distances[i][j];
                    double distanceToNearestMedoid = distancesToNearestMedoid[j], distanceToSecondNearestMedoid = distancesToSecondNearestMedoid[j];
                    clusterCostChanges[results[j]] += Math.Min(distance, distanceToSecondNearestMedoid) - distanceToNearestMedoid;
                    if (distance < distanceToNearestMedoid)
                    {
                        for (int k = 0; k < clusterCount; k++)
                        {
                            if (k == results[j]) continue;
                            clusterCostChanges[k] += distance - distanceToNearestMedoid;
                        }
                    }
                }
                double minCostChange = clusterCostChanges[0];
                int minCostChangeCluster = 0;
                for (int j = 1; j < clusterCount; j++)
                {
                    if (clusterCostChanges[j] < minCostChange)
                    {
                        minCostChange = clusterCostChanges[j];
                        minCostChangeCluster = j;
                    }
                }
                if (minCostChange < bestCostChange)
                {
                    bestCostChange = minCostChange;
                    candidatePoint = i;
                    candidateCluster = minCostChangeCluster;
                }
            }
            if (bestCostChange < 0)
            {
                clusters[candidateCluster].centroid = points[candidatePoint];
                return true;
            }
            return false;
        }

        private bool isMedoid(Point point)
        {
            for (int i = 0; i < clusters.Length; i++)
            {
                if (point.Equals(clusters[i].centroid)) return true;
            }
            return false;
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
