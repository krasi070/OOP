namespace _03.GenericList
{
    using System;

    class TestGenericList
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(2);
            list.Add(12);
            list.Add(2);
            list.Add(133);
            list.Add(133);
            list.Add(113);
            list.Add(13344);
            list.Add(list.Access(0));
            list.Remove(0);
            list.Insert(3, 4);

            Console.WriteLine(list.Contains(133));
            Console.WriteLine(list.IndexOf(2));
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list);

            list.Clear();

            Console.WriteLine(list);
        }
    }
}
