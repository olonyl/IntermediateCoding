using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voting.API;

namespace Voting.DestopApp
{
    public partial class VotingBox : Form
    {
        private API.Post _post;
        private Timer _timer;

        public VotingBox()
        {
            InitializeComponent();
            _post = new API.Post();
            InitTmer();
        }

        private void InitTmer()
        {
            _timer = new Timer();
            _timer.Interval = 10;
            _timer.Tick += new EventHandler(Timer_Tick);
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblValue.Text = _post.Vote.ToString();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            _post.UpVote();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            _post.DownVote();
        }
    }
}
