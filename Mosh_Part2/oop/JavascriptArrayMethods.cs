using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Mosh_Part2.oop
{
    public static class JavascriptArrayMethods
    {
        public static IEnumerable<T> Pop<T>(this IEnumerable<T> list)
        {
            List<T> genericAsList = new List<T>();
            genericAsList.AddRange(list);
            IEnumerable<T> genericWithoutEnd = genericAsList.GetRange(0, genericAsList.Count - 1);
            return genericWithoutEnd;

        }

        public static int Length<T>(this IEnumerable<T> list)
        {
            var count = 0;
            foreach (var item in list)
            {
                count++;
            }
            return count;
        }

        //! yield
        public static IEnumerable<T> Push<T>(this IEnumerable<T> list, T item)
        {
            foreach (var num in list)
            {
                yield return num;
            }
            yield return item;
        }

        




    }
}

