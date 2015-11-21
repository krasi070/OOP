using System;
using System.Collections.Generic;
using System.Linq;

class SULSTest
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        people.Add(new JuniorTrainer("Jerry", "Smith", 40));
        people.Add(new OnsiteStudent("Morty", "Smith", 14, "12345678", 3.50, "Programming Basics", 4));
        people.Add(new OnlineStudent("Summer", "Smith", 17, "87654321", 5.12, "Java Fundamentals"));
        people.Add(new SeniorTrainer("Rick", "Sanchez", 60));
        people.Add(new SeniorTrainer("Walter", "White", 51));
        people.Add(new DropoutStudent("Bird", "Person", 50, "13578901", 4.89, "Didn't have enough free time."));
        people.Add(new GraduateStudent("Stan", "Marsh", 10, "11223344", 5.00));
        people.Add(new JuniorTrainer("Randy", "Marsh", 40));
        people.Add(new DropoutStudent("Kenny", "McCormick", 10, "99808077", 4.17, "Not enough money to pay for his exam."));
        people.Add(new OnsiteStudent("Kyle", "Broflovski", 10, "14889967", 5.13, "OOP", 7));
        people.Add(new OnsiteStudent("Butters", "Stotch", 10, "90901010", 4.34, "Programming Basics", 8));

        ((JuniorTrainer)people[0]).CreateCourse("Marketing");
        Console.WriteLine();
        ((SeniorTrainer)people[3]).DeleteCourse("Marketing");
        Console.WriteLine();
        ((DropoutStudent)people[5]).Reapply();
        Console.WriteLine();
        ((DropoutStudent)people[8]).Reapply();
        Console.WriteLine();
        ((SeniorTrainer)people[4]).CreateCourse("What Chemistry & Progromming Have in Common");

        Console.WriteLine("--------------------------------------------\nCURRENT STUDENTS:\n");

        List<CurrentStudent> currentStudents = people
            .Where(p => p is CurrentStudent)
            .Select(p => ((CurrentStudent)(p)))
            .OrderBy(s => s.AverageGrade)
            .ToList();

        foreach (var student in currentStudents)
        {
            student.PrintInformation();

            if (!student.Equals(currentStudents[currentStudents.Count() - 1]))
            {
                Console.WriteLine();
            }
        }
    }
}

