namespace _02.Func
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                1, 12, 19, 13, 100, 1, 1000, 13, 13, 1
            };

            IEnumerable<int> smallNums = list.TakeWhile(n => n < 100);

            foreach (var num in smallNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
