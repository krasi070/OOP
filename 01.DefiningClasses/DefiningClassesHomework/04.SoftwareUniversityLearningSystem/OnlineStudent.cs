using System;

class OnlineStudent : CurrentStudent
{
    public OnlineStudent(string firstName, string lastName, int age,
        string studentNumber, double averageGrade, string currentCourse)
        : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
    {
 
    }

    public override void PrintInformation()
    {
        Console.WriteLine("{0} {1}\nAge: {2}\nStudent Number: {3}\nAverage Grade: {4}\nCurrent Course: {5}\n" +
        "Type of Student: Online",
            this.FirstName.ToUpper(), this.LastName.ToUpper(), this.Age, this.StudentNumber,
            this.AverageGrade, this.CurrentCourse);
    }
}

