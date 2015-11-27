using System;

class BookShop
{
    static void Main()
    {
        Book readyPlayerOne = new Book("Ready Player One", "Ernest Cline", 16.90);
        Console.WriteLine(readyPlayerOne.ToString());
        GoldenEditionBook fahrenheit = new GoldenEditionBook("Fahrenheit 451", "Ray Bradbury", 11.90);
        Console.WriteLine(fahrenheit.ToString());
    }
}

