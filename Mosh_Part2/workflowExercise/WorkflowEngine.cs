using System;
using System.Collections.Generic;

namespace Mosh_Part2.workflowExercise
{
    public class WorkflowEngine
    {
        private IList<IWorkflow> workFlowList;
        public WorkflowEngine()
        {
            this.workFlowList = new List<IWorkflow>();
        }

        public void Run()
        {
            foreach (var item in workFlowList)
            {
                item.Execute();
            }
        }

        public void AddWorkFlowToList(IWorkflow workflow) =>
            workFlowList.Add(workflow);
    }
}
