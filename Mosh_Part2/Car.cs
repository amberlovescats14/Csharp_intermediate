using System;
namespace Mosh_Part2
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        //public override string ToString()
        //{
        //    return $"Car= make:{Make}, model:{Model}, year:{Year}, color:{Color}";
        //}
    }
}
