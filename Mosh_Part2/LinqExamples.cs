using System;
using System.Collections.Generic;
using System.Linq;

namespace Mosh_Part2
{
    public class LinqExamples
    {

        private IEnumerable<Car> cars = new List<Car>()
        {
            new Car("Cadillac", "SRX", 2016, "red"),
            new Car("Chevy", "Suburban", 2015, "black"),
            new Car("Ford", "Explorer", 2010, "White"),
            new Car("Ford", "Escape", 2008, "silver"),
            new Car("Mitsubishi", "Eclipse", 2004, "black")

        };
        public LinqExamples()
        {
        }

        public void getFordCars()
        {
            var query = cars.Where(c => c.Make == "Ford")
                                         .OrderBy(c => c.Year);
            foreach (var car in query)
            {
                Console.WriteLine($"{car.Make}, {car.Year }");
            }

        }


    }
}
