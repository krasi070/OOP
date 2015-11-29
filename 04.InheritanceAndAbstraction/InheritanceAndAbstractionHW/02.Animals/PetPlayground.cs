using System;
using System.Collections.Generic;
using System.Linq;

class PetPlayground
{
    static void Main()
    {
        Console.WriteLine("PRODUCING SOUNDS");

        List<Animal> animals = new List<Animal>();

        animals.Add(new Dog("Sparky", 6, "M"));
        animals.Add(new Cat("Elizabeth", 9, "F"));
        animals.Add(new Dog("Snowball", 5, "M"));
        animals.Add(new Kitten("Henrieta", 3));
        animals.Add(new Tomcat("Harry", 1));
        animals.Add(new Frog("Mr. Ribbit", 7, "M"));
        animals.Add(new Frog("Mrs. Ribbit", 8, "F"));

        foreach (var animal in animals)
        {
            animal.ProduceSound();
        }

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Average Dog Age: {0:F2} years\nAverage Frog Age: {1:F2} years\nAverage Cat Age: {2:F2} years",
            animals.Where(a => a is Dog).Average(d => d.Age),
            animals.Where(a => a is Frog).Average(f => f.Age),
            animals.Where(a => a is Cat).Average(c => c.Age));
    }
}

