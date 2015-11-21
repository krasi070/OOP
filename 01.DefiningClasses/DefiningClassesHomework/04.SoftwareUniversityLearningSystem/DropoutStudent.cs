using System;

class DropoutStudent : Student
{
    private string dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age,
        string studentNumber, double averageGrade, string dropoutReason)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
        this.DropoutReason = dropoutReason;
    }

    public void Reapply()
    {
        Console.WriteLine("{0} {1}\nAge: {2}\nStudent Number: {3}\nAverage Grade: {4}\nDropout Reason: {5}",
            this.FirstName.ToUpper(), this.LastName.ToUpper(), this.Age, this.StudentNumber,
            this.AverageGrade, this.DropoutReason);
    }

    public string DropoutReason { get; set; }
}

