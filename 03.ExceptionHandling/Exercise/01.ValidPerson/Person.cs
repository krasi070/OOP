using System;

class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("First name cannot be null value!");
            }
            if (value.Trim().Length == 0)
            {
                throw new ArgumentException("First name cannot be empty space!");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Last name cannot be null value!");
            }
            if (value.Trim().Length == 0)
            {
                throw new ArgumentException("Last name cannot be empty space!");
            }
            this.lastName = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative!");
            }
            if (value > 120)
            {
                throw new ArgumentOutOfRangeException("Age cannot be over 120!");
            }
            this.age = value;
        }
    }
}

