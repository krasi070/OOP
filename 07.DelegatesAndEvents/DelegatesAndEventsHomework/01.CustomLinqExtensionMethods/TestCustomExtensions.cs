namespace _01.CustomLinqExtensionMethods
{
    using System;
    using System.Collections.Generic;

    class TestCustomExtensions
    {
        static void Main()
        {
            var listOfStudents = new List<Student>()
            {
                new Student("Rick", 6.00),
                new Student("Morty", 3.67),
                new Student("Summer", 5.43),
                new Student("Genos", 5.78),
                new Student("Butters", 4.23)
            };

            Console.WriteLine("WhereNot:");

            var notExcellentStudents = listOfStudents.WhereNot(s => s.Grade > 5.50);
            Console.WriteLine("{0}", string.Join(", ", notExcellentStudents));

            Console.WriteLine("Max:");

            Console.WriteLine(listOfStudents.Max(s => s.Grade));

        }
    }
}
