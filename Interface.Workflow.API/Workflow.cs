using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Interface.Engine.API
{
    public sealed class Workflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Run()
        {
            if (_activities.Count == 0)
                throw new InvalidOperationException($"You need to define an activity to be executed, please call this method to register one [{nameof(RegisterActivity)}]");

            foreach (var activity in _activities)
                activity.Execute();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
