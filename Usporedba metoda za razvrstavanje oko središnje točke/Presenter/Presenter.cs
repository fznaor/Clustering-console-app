using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZavrsniRad
{
    public class Presenter
    {
        Point[] points, kmeansPoints, kmeansppPoints, kmedoidsPoints, changeablePoints;
        int dimension;
        MainForm mainForm;
        int[] kmeansResults, kmeansppResults, kmedoidsResults, changeableResults;
        double[][] fcmResults;

        public Presenter(MainForm form1)
        {
            this.mainForm = form1;
            this.mainForm.presenter = this;
        }

        public bool loadPointsFromFile(string filePath)
        {
            List<Point> newPoints = new List<Point>();

            using (var reader = new StreamReader(filePath))
            {
                if (reader.EndOfStream)
                {
                    mainForm.showEmptyFileMessage();
                    return false;
                }
                int lineCount = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    double[] values;
                    try
                    {
                        values = line.Split(',').Select(double.Parse).ToArray();
                        if (lineCount == 0) dimension = values.Length;
                        else if (values.Length != dimension)
                        {
                            mainForm.showWrongDimensionMessage();
                            return false;
                        }
                    }
                    catch (Exception)
                    {
                        mainForm.showWrongFormatMessage();
                        return false;
                    }
                    lineCount++;
                    newPoints.Add(new Point(values));
                }
                if (lineCount == 1)
                {
                    mainForm.showOnePointMessage();
                    return false;
                }
                mainForm.dimension = dimension;
                points = new Point[newPoints.Count];
                for(int i = 0; i < newPoints.Count; i++)
                {
                    points[i] = newPoints[i];
                }
                return true;
            }
        }

        public async Task performKmeans(int clusterCount, int maxIterations, int distance, Chart chart)
        {
            Kmeans kmeans = new Kmeans(points, clusterCount, maxIterations, new RandomInitalizer(), distance);
            Stopwatch watch = Stopwatch.StartNew();
            await Task.Run(() => kmeans.performKmeans());
            watch.Stop();
            int[] results = kmeans.results;
            await displayResults(watch, chart, results, clusterCount, kmeans.clusters, kmeans.iterationCount);
            if (chart.Name != "chartChangeable")
            {
                kmeansPoints = points;
                kmeansResults = results;
            }
            else
            {
                changeablePoints = points;
                changeableResults = results;
            }
        }

        public async Task performKmeanspp(int clusterCount, int maxIterations, int distance, Chart chart)
        {
            Kmeans kmeanspp = new Kmeans(points, clusterCount, maxIterations, new KmeansppInitializer(distance), distance);
            Stopwatch watch = Stopwatch.StartNew();
            await Task.Run(() => kmeanspp.performKmeans());
            watch.Stop();
            int[] results = kmeanspp.results;
            await displayResults(watch, chart, results, clusterCount, kmeanspp.clusters, kmeanspp.iterationCount);
            if (chart.Name != "chartChangeable")
            {
                kmeansppPoints = points;
                kmeansppResults = results;
            }
            else
            {
                changeablePoints = points;
                changeableResults = results;
            }
        }

        public async Task performKmedoids(int clusterCount, int maxIterations, int initalization, int distance, Chart chart)
        {
            IClusterCenterInitializer initializer;
            switch (initalization)
            {
                case 1: initializer = new RandomInitalizer(); break;
                default: initializer = new KmeansppInitializer(distance); break;
            }
            Kmedoids kmedoids = new Kmedoids(points, clusterCount, maxIterations, initializer, distance);
            Stopwatch watch = Stopwatch.StartNew(); 
            await Task.Run(() => kmedoids.performKmedoids());
            watch.Stop();
            int[] results = kmedoids.results;
            await displayResults(watch, chart, results, clusterCount, kmedoids.clusters, kmedoids.iterationCount);
            if (chart.Name != "chartChangeable")
            {
                kmedoidsPoints = points;
                kmedoidsResults = results;
            }
            else
            {
                changeablePoints = points;
                changeableResults = results;
            }
        }

        public async Task performFCM(int clusterCount, int maxIterations, double m, double epsilon, int distance, Chart chart)
        {
            FCM fcm = new FCM(points, clusterCount, maxIterations, m, epsilon, distance);
            Stopwatch watch = Stopwatch.StartNew();
            await Task.Run(() => fcm.performFCM());
            watch.Stop();
            double[][] results = fcm.membership;
            int[] hardResults = new int[points.Length];
            for(int i = 0; i < points.Length; i++)
            {
                int maxCoeffIndex = 0;
                for(int j = 0; j < clusterCount; j++)
                {
                    if (results[i][j] > results[i][maxCoeffIndex]) maxCoeffIndex = j;
                }
                hardResults[i] = maxCoeffIndex;
            }
            await displayResults(watch, chart, hardResults, clusterCount, fcm.clusters,fcm.iterationCount);
            changeablePoints = points;
            fcmResults = results;
        }

        public async Task displayResults(Stopwatch watch, Chart chart, int[] results, int clusterCount, Cluster[] clusters, int iterations)
        {
            mainForm.toggleCentroidVisibility(chart);
            mainForm.graphResults(chart, points, clusters, results);
            long executionTime = watch.ElapsedMilliseconds;
            double CHIndex = await Task.Run(() => ClusteringMetrics.calinskiHarabaszIndex(points, results, clusters));
            double DBIndex = await Task.Run(() => ClusteringMetrics.daviesBouldinIndex(points, results, clusters));
            double silhouette = await Task.Run(() => ClusteringMetrics.silhouetteCoefficient(points, results, clusterCount));
            kmeansPoints = points;
            mainForm.displayData(chart, executionTime, iterations, CHIndex, DBIndex, silhouette);
        }

        public bool isClusterCountValid(int clusterCount)
        {
            return clusterCount <= points.Length && clusterCount >= 2;
        }

        public void exportKmeansResults()
        {
            mainForm.exportResults(kmeansPoints, kmeansResults, "kmeans_rezultati.txt");
        }

        public void exportKmeansppResults()
        {
            mainForm.exportResults(kmeansppPoints, kmeansppResults, "kmeanspp_rezultati.txt");
        }

        public void exportKmedoidsResults()
        {
            mainForm.exportResults(kmedoidsPoints, kmedoidsResults, "kmedoids_rezultati.txt");
        }

        public void exportChangeableResults(int index)
        {
            switch (index)
            {
                case 0: mainForm.exportResults(changeablePoints, changeableResults,"kmeans_rezultati.txt"); break;
                case 1: mainForm.exportResults(changeablePoints, changeableResults, "kmeanspp_rezultati.txt"); break;
                case 2: mainForm.exportResults(changeablePoints, changeableResults, "kmedoids_rezultati.txt"); break;
                default: mainForm.exportResults(changeablePoints, fcmResults, "fcm_rezultati.txt"); break;
            }
        }
    }
}
