using System;
using System.Linq;
namespace Mosh_Part2.oop
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        // this is how you do a super()
        public Text(string username)
            :base(username)
        {
        }

        public void AddHyperlink(string url)
        {
            Console.WriteLine($"{url} was made into a hyperlink");
        }

        //BOXING, non type things, like array list are heavier than a typed List<int>
        // where only int can be stored

    }
}
