using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting.API
{
    public class Post
    {
        private int _vote;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Vote { get => _vote;}

        public void UpVote()
        {
            _vote++;
        }

        public void DownVote()
        {
            _vote--;
        }
    }
}
