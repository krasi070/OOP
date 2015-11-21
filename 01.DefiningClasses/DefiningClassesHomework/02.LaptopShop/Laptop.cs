using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;
    private double price;

    public Laptop(string model, double price)
        : this(model, null, null, null, null, null, null, null, price)
    {
 
    }

    public Laptop(string model, string manufacturer, string processor, string ram,
        string graphicsCard, string hdd, string screen, Battery battery, double price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.Price = price;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value == "")
            {
                throw new Exception("Model cannot be empty!");
            }
                this.model = value;
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value == null)
            {
                this.manufacturer = value;
            }
            else if (value == "")
            {
                throw new Exception("Manufacturer cannot be empty!");
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }
    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (value == null)
            {
                this.processor = value;
            }
            else if (value == "")
            {
                throw new Exception("Processor cannot be empty!");
            }
            else
            {
                this.processor = value;
            }
        }
    }
    public string Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value == null)
            {
                this.ram = value;
            }
            else if (value == "")
            {
                throw new Exception("RAM cannot be empty!");
            }
            else
            {
                this.ram = value;
            }
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (value == null)
            {
                this.graphicsCard = value;
            }
            else if (value == "")
            {
                throw new Exception("Graphics card cannot be empty!");
            }
            else
            {
                this.graphicsCard = value;
            }
        }
    }
    public string Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (value == null)
            {
                this.hdd = value;
            }
            else if (value == "")
            {
                throw new Exception("HDD cannot be empty!");
            }
            else
            {
                this.hdd = value;
            }
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (value == null)
            {
                this.screen = value;
            }
            else if (value == "")
            {
                throw new Exception("Screen cannot be empty!");
            }
            else
            {
                this.screen = value;
            }
        }
    }
    public Battery Battery { get; set; }
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

    public override string ToString()
    {
        return string.Format("{0}\nManufacturer: {1}\nProcessor: {2}\nRAM: {3}\nGraphics Card: {4}\nHDD: {5}\n" +
        "Screen: {6}\nBattery: {7}\nBattery Life: {8}\nPrice: {9}",
        this.Model.ToUpper(),
        this.Manufacturer ?? "[not given]",
        this.Processor ?? "[not given]",
        this.Ram ?? "[not given]",
        this.GraphicsCard ?? "[not given]",
        this.Hdd ?? "[not given]",
        this.Screen ?? "[not given]",
        this.Battery == null ? "[not given]" : this.Battery.Model,
        this.Battery == null ? "[not given]" : this.Battery.Hours + " hours",
        this.Price + " lv."); 
    }
}

