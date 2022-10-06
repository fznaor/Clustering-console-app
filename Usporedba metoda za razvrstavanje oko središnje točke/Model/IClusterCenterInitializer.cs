namespace ZavrsniRad
{
    interface IClusterCenterInitializer
    {
        Cluster[] initializeClusterCentres(Point[] points, int clusterCount);
    }
}
