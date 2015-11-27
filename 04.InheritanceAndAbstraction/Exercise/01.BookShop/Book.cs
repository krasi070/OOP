using System;

public class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title
    {
        get
        {
            return this.title;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Title cannot be null");
            }

            this.title = value;
        }
    }

    public string Author
    {
        get
        {
            return this.author;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Author name cannot be null");
            }

            this.author = value;
        }
    }

    public virtual double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("-Type: {0}\n-Title: {1}\n-Author: {2}\n-Price: {3:F2}\n" + 
        "-----------------------------------------------------------------------------",
            base.ToString(), this.Title, this.Author, this.Price);
    }
}

