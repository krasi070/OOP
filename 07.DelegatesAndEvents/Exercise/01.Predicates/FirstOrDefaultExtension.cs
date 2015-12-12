namespace _01.Predicates
{
    using System;
    using System.Collections.Generic;

    public static class FirstOrDefaultExtension
    {
        public static T FirstOrDefault<T>(this IEnumerable<T> list, Predicate<T> predicate)
        {
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}
