using Interface.Engine.API;
using System;

namespace Interface.Engine.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            var engine = new WorkFlowEngine();

            workflow.Add(new EmailActivity());
            workflow.Add(new UploadVideoActivity());
            workflow.Add(new WebServiceActivity());

            engine.Run(workflow);
        }
    }
}
