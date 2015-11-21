using System;

class Battery
{
    private string model;
    private double hours;

    public Battery()
        : this(null, 0)
    {
 
    }

    public Battery(string model)
        : this(model, 0)
    {
        
    }

    public Battery(double hours)
        : this(null, hours)
    {
 
    }

    public Battery(string model, double hours)
    {
        this.Model = model;
        this.Hours = hours;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set 
        {
            if (value == null)
            {
                this.model = value;
            }
            else if (value == "")
            {
                throw new Exception("Model cannot be empty!");
            }
            else
            {
                this.model = value;
            }
        }
    }
    public double Hours
    {
        get
        {
            return this.hours;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Hours cannot be negative!");
            }
            this.hours = value;
        }
    }
}

