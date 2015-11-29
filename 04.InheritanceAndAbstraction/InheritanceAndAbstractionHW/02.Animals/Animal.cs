using System;

public abstract class Animal : ISoundProducable
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Name cannot be null");
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
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative");
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get
        {
            return this.gender;
        }
        set
        {
            if (value != "F" && value != "M")
            {
                throw new ArgumentException("Gender can only be F or M");
            }

            this.gender = value;
        }
    }

    public abstract void ProduceSound();
}

