using System;
using System.Collections.Generic;

namespace Mosh_Part2.oop
{
    public class TestingExtensionMethods
    {
        private List<int> numbers = new List<int>()
        {
            1,2,3,4,5,6,7
        };
        public TestingExtensionMethods()
        {
            
        }

        public void testPop()
        {
            var original = string.Join(",", numbers);

            var popped = numbers.Pop();
            var poppedString = string.Join(",", popped);
            Console.WriteLine("Original: "+ original);
            Console.WriteLine("Popped: " + poppedString);


        }
    }
}
