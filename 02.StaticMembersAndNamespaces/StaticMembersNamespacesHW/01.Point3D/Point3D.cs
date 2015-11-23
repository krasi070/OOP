﻿using System;

class Point3D
{
    private double x;
    private double y;
    private double z;
    private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public static Point3D StartingPoint
    {
        get
        {
            return Point3D.startingPoint;
        }
    }

    public override string ToString()
    {
        return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
    }
}

