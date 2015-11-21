using System;
using System.Collections.Generic;

class Computer
{
    private string name;
    private List<Component> components;
    private double price;

    public Computer()
        : this(null, componentsArr: null)
    {

    }

    public Computer(string name)
        : this(name, null)
    {
 
    }

    public Computer(params Component[] componentsArr)
        : this(null, componentsArr)
    {
 
    }

    public Computer(string name, params Component[] componentsArr)
    {
        this.Name = name;
        if (componentsArr != null)
        {
            this.AddComponents(componentsArr);
            foreach (var component in this.components)
            {
                this.Price += component.Price;
            }
        }
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
                this.name = value;
            }
            else if (value == "")
            {
                throw new Exception("Name cannot be empty!");
            }
            else
            {
                this.name = value;
            }
        }
    }
    private void AddComponents(Component[] componentsArr)
    {
        this.components = new List<Component>();
        foreach (var component in componentsArr)
        {
            this.components.Add(component);
        }
    }
    public double Price { get; set; }

    public override string ToString()
    {
        string components = "Components:\n";
        if (this.components != null)
        {
            foreach (var component in this.components)
            {
                components += string.Format("-->{0}\nDetails: {1}\nComponent Price: {2}\n"
                    , component.Name, component.Details ?? "[no given details]", component.Price);
            }
        }
        else
        {
            components += "[no components]\n";
        }
        return string.Format("{0}\n{1}Total Price: {2}", this.Name ?? "[no name given]", components, this.Price);
    }
}

