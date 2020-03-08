using System;
using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using System.Threading.Tasks;

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
      
    }

 
}

