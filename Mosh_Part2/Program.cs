using System;
using Mosh_Part2.oop;
using Mosh_Part2.workflowExercise;
namespace Mosh_Part2
{
    class Program
    {
        static void Main(string[] args)
        {



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

            //var stopwatch = new exerecises.Stopwatch();
            //stopwatch.Start();
            //stopwatch.Start();
            //stopwatch.Stop();

            //autoboxing with a super constructor
            PresentationObject text = new Text("Amber");
            //text.Copy();

            //var extensionMethodsTest = new TestingExtensionMethods();
            //extensionMethodsTest.testPop();

            var workflowEngine = new WorkflowEngine();
            workflowEngine.AddWorkFlowToList(new Scrum());
            workflowEngine.AddWorkFlowToList(new WorkHours());
            workflowEngine.Run();



        }
    }
}
