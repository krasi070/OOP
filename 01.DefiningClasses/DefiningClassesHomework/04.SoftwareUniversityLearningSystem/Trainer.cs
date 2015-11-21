using System;

abstract class Trainer : Person
{
    public Trainer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {
 
    }

    public abstract void CreateCourse(string courseName);
}

