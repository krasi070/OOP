using System;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, double price)
        : base(title, author, price)
    {
 
    }

    public override double Price
    {
        get
        {
            return base.Price;
        }
        set
        {
            base.Price = value * 1.3;
        }
    }
}

