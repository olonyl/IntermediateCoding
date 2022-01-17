using NUnit.Framework;
using NSubstitute;
using Interface.Engine.API;
using System;
using System.Linq;

namespace Interface.Engine.UnitTests
{
    public class WorkflowTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_AddOneActivity_ReturnsOneActivity()
        {
            var workflow = new Workflow();
            var activity = Substitute.For<IActivity>();

            workflow.Add(activity);

            Assert.AreEqual(1, workflow.GetActivities().Count());
        }

        [Test]
        public void Remove_AddTwoActivitiesAndRemoveOne_ReturnsOneActivity()
        {
            var workflow = new Workflow();
            var activity = Substitute.For<IActivity>();
            var activity2 = Substitute.For<IActivity>();

            workflow.Add(activity);
            workflow.Add(activity2);

            workflow.Remove(activity);

            Assert.AreEqual(1, workflow.GetActivities().Count());
        }
    }
}