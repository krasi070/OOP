namespace _01.Shapes
{
    using System;

    class TestShapes
    {
        static void Main()
        {
            IShape[] shapeArr = new IShape[5]
            {
                new Rectangle(12, 10),
                new Circle(3),
                new Rhombus(4, 2),
                new Circle(5.5),
                new Rectangle(3, 4)
            };

            for (int i = 0; i < shapeArr.Length; i++)
            {
                Console.WriteLine("Shape[{0}]\nArea: {1:F2}\nPerimeter: {2:F2}",
                    i, shapeArr[i].CalculateArea(), shapeArr[i].CalculatePerimeter());
            }
        }
    }
}
