using Interface.Engine.API;
using System;

namespace Interface.Engine.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.RegisterActivity(new EmailActivity());
            workflow.RegisterActivity(new UploadVideoActivity());
            workflow.RegisterActivity(new WebServiceActivity());
            workflow.Run();
        }
    }
}
