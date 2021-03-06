﻿using System;

class Dog
{
    private string name;
    private string breed;

    public Dog() 
        : this(null, null)
    {
    }

    public Dog(string name, string breed) 
    {
        this.Name = name;
        this.Breed = breed;
    }

    public string Name { get; set; }
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine("{0} ({1}) said: Bauuuu!",
            this.Name ?? "???",
            this.Breed ?? "???");
    }
}

