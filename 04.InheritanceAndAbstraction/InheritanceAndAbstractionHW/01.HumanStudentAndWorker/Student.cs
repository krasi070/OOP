﻿using System;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10)
            {
                throw new ArgumentOutOfRangeException("Faculty number can only be from 5 to 10 digits/letters");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0} {1}\nFaculty Number: {2}",
            this.FirstName, this.LastName, this.FacultyNumber);
    }
}
