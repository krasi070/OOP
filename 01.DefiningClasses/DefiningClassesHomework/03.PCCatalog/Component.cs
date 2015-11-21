using System;

class Component
{
    private string name;
    private string details;
    private double price;

    public Component(string name, double price)
        : this(name, null, price)
    {
 
    }

    public Component(string name, string details, double price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
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
    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            if (value == null)
            {
                this.details = value;
            }
            else if (value == "")
            {
                throw new Exception("Details cannot be empty!");
            }
            else
            {
                this.details = value;
            }
        }
    }
    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Price cannot be negative!");
            }
            this.price = value;
        }
    }
}

