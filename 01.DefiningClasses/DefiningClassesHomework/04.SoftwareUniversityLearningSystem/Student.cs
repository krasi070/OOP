using System;

abstract class Student : Person
{
    private string studentNumber;
    private double averageGrade;

    public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade)
        : base(firstName, lastName, age)
    {
        this.StudentNumber = studentNumber;
        this.AverageGrade = averageGrade;
    }

    public string StudentNumber { get; set; }
    public double AverageGrade { get; set; }
}

