using System;
namespace Mosh_Part2.oop
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Username { get; set; }

        //constructor
        public PresentationObject(string username)
        {
            this.Username = username;
        }

        public void Copy()
        {
            Console.WriteLine("Object was copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }

    }
}
