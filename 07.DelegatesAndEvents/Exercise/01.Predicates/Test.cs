namespace _01.Predicates
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            List<string> list = new List<string>()
            {
                "hahhaha",
                "ha",
                "ha ha ha",
                "Ha h",
                "ho hi ho"
            };

            string haha = list.FirstOrDefault(h => h.Equals("ha"));
            Console.WriteLine(haha);
        }
    }
}
