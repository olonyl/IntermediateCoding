using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface.Engine.API
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            if (workflow.GetActivities().Count() == 0)
                throw new InvalidOperationException($"No activities were specified to this method [{nameof(Run)}]:{nameof(workflow.GetActivities)}");

            foreach (var activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}
