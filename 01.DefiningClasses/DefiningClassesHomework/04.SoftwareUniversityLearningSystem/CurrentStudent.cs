using System;

abstract class CurrentStudent : Student
{
    private string currentCourse;

    public CurrentStudent(string firstName, string lastName, int age,
        string studentNumber, double averageGrade, string currentCourse)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
        this.CurrentCourse = currentCourse;
    }

    public string CurrentCourse { get; set; }

    public abstract void PrintInformation();
}

