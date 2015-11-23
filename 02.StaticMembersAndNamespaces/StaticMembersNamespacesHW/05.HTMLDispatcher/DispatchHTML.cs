using System;

class DispatchHTML
{
    static void Main()
    {
        ElementBuilder div = new ElementBuilder("div");
        div.AddAttribute("id", "page");
        div.AddAttribute("class", "big");
        div.AddContent("<p>Hello</p>");
        Console.WriteLine(div * 2 + 
            HTMLDispatcher.CreateImage("img.jpg", "alt", "title") + 
            HTMLDispatcher.CreateURL("www.softuni.bg", "title", "text") + 
            HTMLDispatcher.CreateInput("type", "name", "value"));
    }
}

