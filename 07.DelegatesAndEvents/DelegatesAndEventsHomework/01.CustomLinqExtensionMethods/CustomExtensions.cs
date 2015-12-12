namespace _01.CustomLinqExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class CustomExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            List<T> list = new List<T>();

            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> func)
            where TSelector : IComparable
        {
            List<TSelector> list = new List<TSelector>();

            foreach (var item in collection)
            {
                list.Add(func(item));
            }

            var max = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
