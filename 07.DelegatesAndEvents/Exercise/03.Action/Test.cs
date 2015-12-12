namespace _03.Action
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            list.ForEach(Console.WriteLine);
        }
    }
}
