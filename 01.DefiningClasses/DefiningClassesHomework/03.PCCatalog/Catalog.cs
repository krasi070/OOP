using System;
using System.Collections.Generic;
using System.Linq;

class Catalog
{
    static void Main()
    {
        List<Computer> computers = new List<Computer>();
        computers.Add(new Computer("MEGA COMPUTER",
            new Component("Ultra SSD", 10000.01),
            new Component("Hyper Video Card", "It's really hyper!", 10.99)));
        computers.Add(new Computer("Acer Extensa"));
        computers.Add(new Computer());
        computers.Add(new Computer("Lenovo ThinkCentre",
            new Component("Intel HD Graphics", 199.99),
            new Component("Intel inside Pentium", 99.99),
            new Component("Enhanced Performanced Keyboard", "Really enhanced!", 56.67)));
        computers.Add(new Computer(new Component("Deathstalker Essential Keyboard", "It'll stalk you till death!", 110.00),
            new Component("Samsung Monitor", 249.99)));

        List<Computer> sortedComputers = computers
            .OrderBy(c => c.Price)
            .ToList();

        foreach (var computer in sortedComputers)
        {
            Console.WriteLine(computer);

            if (!computer.Equals(sortedComputers[computers.Count() - 1]))
            {
                Console.WriteLine();
            }
        }
    }
}

