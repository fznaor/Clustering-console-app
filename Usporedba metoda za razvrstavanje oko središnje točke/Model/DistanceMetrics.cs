using System;

namespace ZavrsniRad
{
    class DistanceMetrics
    {
        public static double calculateSquareEuclideanDistance(Point p1, Point p2)
        {
            double sum = 0;
            for (int i = 0; i < p1.dimension; i++)
            {
                sum += (p2.coordinates[i] - p1.coordinates[i]) * (p2.coordinates[i] - p1.coordinates[i]);
            }
            return sum;
        }

        public static double calculateEuclideanDistance(Point p1, Point p2)
        {
            return Math.Sqrt(calculateSquareEuclideanDistance(p1, p2));
        }

        public static double calculateManhattanDistance(Point p1, Point p2)
        {
            double sum = 0;
            for (int i = 0; i < p1.dimension; i++)
            {
                sum += Math.Abs(p2.coordinates[i] - p1.coordinates[i]);
            }
            return sum;
        }

        public static double calculateSquareManhattanDistance(Point p1, Point p2)
        {
            double distance = calculateManhattanDistance(p1, p2);
            return distance * distance;
        }
    }
}
