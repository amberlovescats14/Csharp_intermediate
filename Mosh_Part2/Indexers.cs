using System;
using System.Collections.Generic;

namespace Mosh_Part2
{
    public class Indexers
    {
        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();
        
        public Indexers()
        {
        }

        public string this[string key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }
        }
        
    }
}
