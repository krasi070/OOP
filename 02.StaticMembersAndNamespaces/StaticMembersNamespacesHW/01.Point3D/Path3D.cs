using System;
using System.Collections.Generic;

class Path3D
{
    private List<Point3D> path3D;

    public Path3D()
    {
        this.Set3DPath();
    }

    private void Set3DPath()
    {
        this.path3D = new List<Point3D>();
    }

    public void Add3DPoint(Point3D p)
    {
        this.path3D.Add(p);
    }

    public void AddMultiple3DPoints(IEnumerable<Point3D> c)
    {
        this.path3D.AddRange(c);
    }

    public Point3D Get3DPoint(int i)
    {
        return this.path3D[i];
    }

    public int NumberOfPoints()
    {
        return this.path3D.Count;
    }
}

