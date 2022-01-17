using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Interface.Engine.API
{
    public sealed class Workflow: IWorkFlow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }
    }
}
