using System;


namespace Stopwatch
{
    public class Stopwatch
    {
        private readonly System.Diagnostics.Stopwatch _stopWatch;
        private TimeSpan _totalDuration;

        public TimeSpan Duration { get=> _stopWatch.Elapsed;}
        public TimeSpan TotalDuration { get => _totalDuration; }
        public Boolean IsRunning { get => _stopWatch.IsRunning;  }

        public Stopwatch()
        {
            _stopWatch = new System.Diagnostics.Stopwatch();
        }
        public void Start()
        {
            if (_stopWatch.IsRunning)
                throw new InvalidOperationException($"{nameof(Start)}: Stopwatch is already running");
            _stopWatch.Start();

        }

        public void Stop()
        {
            _stopWatch.Stop();
            _totalDuration += _stopWatch.Elapsed;
        }
    }
}
