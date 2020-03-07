using System;
using System.Collections.Generic;

namespace Mosh_Part2
{
    public class Customer
    {
        //! READ ONLY
        private readonly List<String> orders = new List<string>();
        private DateTime birthdate;

        //another way to do getter and setter
        public string Name { get; private set; }

        //!!! SNIPPET:  prop
        public int age { get; set; }




        public Customer(string name)
        {
            this.Name = name;
            this.birthdate = new DateTime();
        }

        // GETTER AND SETTER
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }







    }
}
