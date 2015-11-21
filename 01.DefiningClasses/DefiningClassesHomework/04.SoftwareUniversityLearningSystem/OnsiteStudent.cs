using System;

class OnsiteStudent : CurrentStudent
{
    private int numberOfVisits;

    public OnsiteStudent(string firstName, string lastName, int age,
        string studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
        : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
    {
        this.NumberOfVisits = numberOfVisits;
    }

    public int NumberOfVisits { get; set; }

    public override void PrintInformation()
    {
        Console.WriteLine("{0} {1}\nAge: {2}\nStudent Number: {3}\nAverage Grade: {4}\nCurrent Course: {5}\n" + 
        "Type of Student: Onsite\nNumber Of Visits: {6}",
            this.FirstName.ToUpper(), this.LastName.ToUpper(), this.Age, this.StudentNumber,
            this.AverageGrade, this.CurrentCourse, this.NumberOfVisits);
    }
}

