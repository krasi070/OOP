using System;
using System.IO;

static class Storage
{
    public static void Save(Path3D path3D, string path)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            for (int i = 0; i < path3D.NumberOfPoints(); i++)
            {
                writer.WriteLine(path3D.Get3DPoint(i).ToString());
            }
        }
    }

    public static Path3D Load(string path)
    {
        Path3D path3D = new Path3D();
        using (StreamReader reader = new StreamReader(path))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] strArr = line.Split(new char[] { '(', ')', ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
                double[] arr = new double[3];
                for (int i = 0; i < strArr.Length; i++)
                {
                    arr[i] = double.Parse(strArr[i]);
                }
                Point3D point = new Point3D(arr[0], arr[1], arr[2]);
                path3D.Add3DPoint(point);
                line = reader.ReadLine();
            }
        }
        return path3D;
    }
}

