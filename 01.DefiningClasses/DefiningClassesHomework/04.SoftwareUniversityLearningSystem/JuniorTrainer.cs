using System;

class JuniorTrainer : Trainer
{
    public JuniorTrainer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {
 
    }

    public override void CreateCourse(string courseName)
    {
        Console.WriteLine("{0} {1} has created the course {2}", this.FirstName, this.LastName, courseName);
    }
}

