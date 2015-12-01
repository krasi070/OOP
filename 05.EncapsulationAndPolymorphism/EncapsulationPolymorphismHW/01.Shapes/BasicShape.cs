﻿namespace _01.Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be a negative number");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be a negative number");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
