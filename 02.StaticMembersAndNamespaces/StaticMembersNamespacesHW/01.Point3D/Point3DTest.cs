using System;

class Point3DTest
{
    static void Main()
    {
        Console.WriteLine("Point3D Test:");
        Point3D[] points = new Point3D[3];
        points[0] = new Point3D(1, -19, 17);
        points[1] = new Point3D(2, 0, -7);
        points[2] = Point3D.StartingPoint;

        foreach (var point in points)
        {
            Console.WriteLine(point.ToString());
        }

        Console.WriteLine("---------------------------------------\nDistance Calculator Test:");

        Console.WriteLine("Distance between A{0} and B{1}: {2}",
            points[0].ToString(),
            points[1].ToString(),
            DistanceCalculator.Calculate3DDistance(points[0], points[1]));

        Console.WriteLine("---------------------------------------\nPaths Test:");

        Path3D path3D = new Path3D();
        path3D.AddMultiple3DPoints(points);

        Storage.Save(path3D, "../../points.txt");

        Path3D sndPath3D = Storage.Load("../../points.txt");

        for (int i = 0; i < sndPath3D.NumberOfPoints(); i++)
        {
            Console.WriteLine(sndPath3D.Get3DPoint(i).ToString());
        }
    }
}

