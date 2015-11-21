using System;

class Shop
{
    static void Main()
    {
        Laptop[] laptops = new Laptop[2];
        laptops[0] = new Laptop("Lenovo Yoga 2 Pro", "Lenovo",
            "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400",
            "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
            new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5), 2259.00);
        laptops[1] = new Laptop("THE NEW RAZER BLADE PRO", 4999.99);

        foreach (var laptop in laptops)
        {
            Console.WriteLine(laptop.ToString());

            if (!laptop.Equals(laptops[laptops.Length - 1]))
            {
                Console.WriteLine();
            }
        }
    }
}

