namespace Problem2.CustomLINQExtensionMethods
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(
            this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(col => !predicate(col));
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var list = collection.ToList();
            for (int counter = 1; counter <= count; counter++)
            {
                list.AddRange(collection);
            }

            return list as IEnumerable<T>;
        }

        public static IEnumerable<string> WhereEndsWith(
            this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            List<string> result = new List<string>();

            foreach (var item in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        result.Add(item);
                    }
                }
            }

            return result as IEnumerable<string>;
        }
    }
}