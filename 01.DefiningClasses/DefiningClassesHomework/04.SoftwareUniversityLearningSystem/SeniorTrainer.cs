using System;

class SeniorTrainer : Trainer
{
    public SeniorTrainer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {
 
    }

    public override void CreateCourse(string courseName)
    {
        Console.WriteLine("{0} {1} has created the course {2}", this.FirstName, this.LastName, courseName);
    }

    public void DeleteCourse(string courseName)
    {
        Console.WriteLine("{0} {1} has deleted the course {2}", this.FirstName, this.LastName, courseName);
    }
}

