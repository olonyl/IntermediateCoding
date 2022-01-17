using System.Collections.Generic;

namespace Interface.Engine.API
{
    public interface IWorkFlow{
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
