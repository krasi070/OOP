using System;
using System.Collections.Generic;
using System.Linq;

class ListOfStudentsAndWorkers
{
    static void Main()
    {
        Console.WriteLine("ORDERED STUDENTS\n");

        List<Student> students = new List<Student>();

        students.Add(new Student("Little", "Rick", "12af3"));
        students.Add(new Student("Morty", "Smith", "788llp01"));
        students.Add(new Student("Summer", "Smith", "8f9pgoh7"));
        students.Add(new Student("Eric", "Cartman", "9ok78jnh12"));
        students.Add(new Student("Kyle", "Broflovski", "1b34a"));
        students.Add(new Student("Stan", "Marsh", "78io908"));
        students.Add(new Student("Kenny", "McCormick", "667died9"));
        students.Add(new Student("Jon", "Snow", "78kn18"));
        students.Add(new Student("Arya", "Stark", "172p182j12"));
        students.Add(new Student("Scott", "Pilgrim", "afg67a"));

        students
            .OrderBy(s => s.FacultyNumber)
            .ToList()
            .ForEach(s => Console.WriteLine(s.ToString() + "\n--------------------------------"));

        Console.WriteLine("ORDERED WORKERS\n");

        List<Worker> workers = new List<Worker>();

        workers.Add(new Worker("Rick", "Sanchez", 10000, 1));
        workers.Add(new Worker("Jerry", "Smith", 100, 2));
        workers.Add(new Worker("Beth", "Smith", 2500, 8));
        workers.Add(new Worker("Randy", "Marsh", 1000, 1));
        workers.Add(new Worker("Don", "Quixote", 100, 24));
        workers.Add(new Worker("Homer", "Simpson", 2000, 8));
        workers.Add(new Worker("Ned", "Flanders", 3500, 8));
        workers.Add(new Worker("Oliver", "Queen", 10000, 2));
        workers.Add(new Worker("Arin", "Hanson", 5000, 9));
        workers.Add(new Worker("Barry", "Kramer", 2000, 12));

        workers
            .OrderBy(w => w.MoneyPerHour())
            .ToList()
            .ForEach(w => Console.WriteLine(w.ToString() + "\n--------------------------------"));

        Console.WriteLine("ORDERED HUMANS\n");

        List<Human> humans = new List<Human>();

        humans.AddRange(students);
        humans.AddRange(workers);

        humans
            .OrderBy(h => h.FirstName)
            .ThenBy(h => h.LastName)
            .ToList()
            .ForEach(h => Console.WriteLine(h.FirstName + " " + h.LastName));
    }
}
