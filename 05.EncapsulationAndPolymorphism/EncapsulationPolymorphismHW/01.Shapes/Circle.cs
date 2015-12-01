namespace _01.Shapes
{
    using System;

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius canot be a negative number");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return this.Radius * 2 * Math.PI;
        }
    }
}
