using System;

public class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, double weekSalary, double workHoursperDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursperDay;
    }

    public double WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Week salary cannot be a negative number");
            }

            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentOutOfRangeException("Work hours per day must be in the range [0...24]");
            }

            this.workHoursPerDay = value;
        }
    }

    public double MoneyPerHour()
    {
        return this.WeekSalary / (this.WorkHoursPerDay * 5);
    }

    public override string ToString()
    {
        return string.Format("{0} {1}\nMoney Per Hour: {2:F2}",
            this.FirstName, this.LastName, this.MoneyPerHour());
    }
}
