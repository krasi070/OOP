using System;

public class Tomcat : Cat
{
    public Tomcat(string name, int age)
        : base(name, age, "M")
    {
 
    }

    public override void ProduceSound()
    {
        Console.WriteLine("MEOW! MEOW! MEOW!");
    }
}

