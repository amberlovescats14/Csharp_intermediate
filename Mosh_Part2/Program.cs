using System;

namespace Mosh_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new exerecises.Stopwatch();
            stopwatch.Start();
            stopwatch.Start();


            Console.WriteLine("Hello World!");
            Person.Parse("Amber");

            //set values initially
            var person = new Person
            {
                Name = "Amber"
            };


            var customer = new Customer("Amber");
            var customerName = customer.Name;


            var indexer = new Indexers();
            indexer["name"] = "Amber";
            var indexersName = indexer["name"]; // will be Amber

            var linqExamples = new LinqExamples();
            //linqExamples.getFordCars();

            stopwatch.Stop();



        }
    }
}
