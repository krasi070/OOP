namespace _02.Func
{
    using System;
    using System.Collections.Generic;

    public static class TakeWhileExtension
    {
        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> collection, Func<T, bool> func)
        {
            List<T> list = new List<T>();

            foreach (var item in collection)
            {
                if (func(item))
                {
                    list.Add(item);
                }
                else
                {
                    break;
                }
            }

            return list;
        }
    }
}
