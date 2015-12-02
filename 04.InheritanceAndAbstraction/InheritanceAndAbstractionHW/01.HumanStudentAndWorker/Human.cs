using System;

public abstract class Human
{
    private string firstName;
    private string lastName;

    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("First name cannot be null");
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
        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Last name cannot be null");
            }

            this.lastName = value;
        }
    }
}
