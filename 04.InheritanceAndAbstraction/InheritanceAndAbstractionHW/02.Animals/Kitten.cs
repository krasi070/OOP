using System;

public class Kitten : Cat
{
    public Kitten(string name, int age)
        : base(name, age, "F")
    {
 
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meeeoooow...");
    }
}

