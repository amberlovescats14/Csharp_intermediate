using System;
namespace Mosh_Part2.oop
{
    public class Circle_A : Shape_A
    {
        public Circle_A()
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle from abstract.");
        }
    }
}
