using NUnit.Framework;
using NSubstitute;
using Interface.Engine.API;
using System;

namespace Interface.Engine.UnitTests
{
    public class WorkflowTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Run_NoActivitiesProvided_ThrowsInvalidOperationException()
        {
            var workflow = new Workflow();

            Assert.Throws<InvalidOperationException>(() => workflow.Run());
        }

        [Test]
        public void Run_ActivityProvided_CallExecute()
        {
            var activity = Substitute.For<IActivity>();
            var activity2 = Substitute.For<IActivity>();

            var workFlow = new Workflow();

            workFlow.RegisterActivity(activity);
            workFlow.RegisterActivity(activity2);
            workFlow.Run();

            activity.Received().Execute();
            activity2.Received().Execute();

        }
    }
}