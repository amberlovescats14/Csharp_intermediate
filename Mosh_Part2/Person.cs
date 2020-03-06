using System;
using System.Collections.Generic;
using System.Linq;

namespace Mosh_Part2
{
    public class Person
    {
        public string Name;
        public List<int> Numbers;

        public Person()
        {
            this.Numbers = new List<int>();
        }

        //! Constructor that also calls default constructor
        //! You can also do it with constructors that have parameters
        public Person(String name)
            : this()
        {
            this.Name = name;
        }

        
        public void Introduce()
        {
            if (this.Name == null) this.Name = "Amber";
            Console.WriteLine("I am {0}", this.Name);
        }

       public static Person Parse(String name)
        {
            var person = new Person();
            person.Name = name;
            return person;
        }

        // CODE SMELLS
        public int add(params int[] numbers)
        {
            // this is how u give it unlimited number of params
            return numbers.Aggregate((x, y)=> x + y);

        }
        public void alterTheValue(ref int a)
        {
            //this will alter the value that is passed in instead of
            //making a copy
            a += 2;
        }
        public void sendMultipleValues(out int result)
        {
            result = 1;
        }
        public void tryToParse(string num)
        {
            int number;
            var result = int.TryParse("abc", out number);
            //false
            Console.WriteLine(result);
        }


    }
}
