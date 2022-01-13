using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stopwatch.API; 

namespace Stopwatch.DesktopApp
{
    public partial class Controller : Form
    {
        private readonly Stopwatch _stopWatch;
        private Timer _timer;

        public Controller()
        {
            InitializeComponent();
         
            _stopWatch = new Stopwatch();

            InitTimer();
        }

        private void InitTimer()
        {
            _timer = new Timer();
            _timer.Tick += new EventHandler(timer1_Tick);
            _timer.Interval = 10;
            _timer.Start();
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            if (!_stopWatch.IsRunning)
                _stopWatch.Start();
            else
                _stopWatch.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnStopwatch.Text = _stopWatch.IsRunning ? "Stop" : "Start";
            lblElapsedTime.Text = _stopWatch.Duration.ToString();
        }
    }
}
