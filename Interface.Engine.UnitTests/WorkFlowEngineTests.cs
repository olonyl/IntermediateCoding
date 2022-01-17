using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;
using Interface.Engine.API;

namespace Interface.Engine.UnitTests
{
    class WorkFlowEngineTests
    {
        [Test]
        public void Run_CallWithNoActivities_ThrowsInvalidOperationException()
        {
            var workflow = Substitute.For<IWorkFlow>();
            var workFlowEngine = new WorkFlowEngine();

            Assert.Throws<InvalidOperationException>(()=> workFlowEngine.Run(workflow));
        }

        [Test]
        public void Run_CallWith2Activities_CallWorkflowGetActivitiesTwice()
        {
            var workflow = Substitute.For<IWorkFlow>();
            var workflowEngine = new WorkFlowEngine();

            workflow.GetActivities().Returns(GetListOfActivities());
            workflowEngine.Run(workflow);

            workflow.Received(2).GetActivities();

        }

        private IEnumerable<IActivity> GetListOfActivities()
        {
            yield return Substitute.For<IActivity>();
            yield return Substitute.For<IActivity>();         
        }
    }
}
