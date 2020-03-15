using System;
namespace Mosh_Part2.workflowExercise
{
    public class Scrum : IWorkflow
    {
        public Scrum()
        {
        }

        public void Execute() =>
              Console.WriteLine("Execute scrum meeting.");

    }
}
