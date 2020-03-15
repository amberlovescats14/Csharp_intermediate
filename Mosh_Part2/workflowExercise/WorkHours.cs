using System;
namespace Mosh_Part2.workflowExercise
{
    public class WorkHours : IWorkflow
    {
        public WorkHours()
        {
        }

        public void Execute() =>
            Console.WriteLine("Execute PBI");
    }
}
