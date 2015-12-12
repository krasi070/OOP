namespace _04.StudentClass
{
    using System;

    class Program
    {
        static void Main()
        {
            Student rick = new Student("Rick", 60);
            rick.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            };

            rick.Name = "Morty";
            rick.Age = 14;
        }
    }
}
