using System;


namespace Stopwatch
{
    public class Stopwatch
    {
        private readonly System.Diagnostics.Stopwatch _stopWatch;

        public TimeSpan Duration { get=> _stopWatch.Elapsed;}

        public void Start()
        {
            if (_stopWatch.IsRunning)
                throw new InvalidOperationException($"{nameof(Start)}: Stopwatch is already running");
            _stopWatch.Start();

        }

        public void Stop()
        {
            _stopWatch.Stop();
        }

    }
}
