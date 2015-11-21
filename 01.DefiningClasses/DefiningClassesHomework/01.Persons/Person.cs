using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age)
        : this(name, age, null)
    {
 
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set 
        {
            if (value == "")
            {
                throw new Exception("Name cannot be empty!");
            }
            this.name = value;
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
            if (value < 1 || value > 100)
            {
                throw new Exception("Age cannot be under 1 or over 100!");
            }
            this.age = value;
        }
    }
    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value == null)
            {
                this.email = value;
            }
            else if (value == "" || !value.Contains("@"))
            {
                throw new Exception("Email cannot be empty and an email has to contain a @!");
            }
            else
            {
                this.email = value;
            }
        }
    }

    public string ToString()
    {
        return "Name: " + this.name + "\nAge: " + this.age + "\nEmail: " + (this.email ?? "[no email given]");
    }
}

