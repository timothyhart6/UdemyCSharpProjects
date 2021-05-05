using System;

namespace CSharpTutorial
{
    class StopWatch
    {
        private DateTime? StartTime { get; set; }
        private DateTime? StopTime { get; set; }
        private TimeSpan Duration { get; set; }

        public void Start()
        {
            if (StartTime == null)
                StartTime = DateTime.Now;
            else
                throw new InvalidOperationException();
        }

        public void Stop()
        {
            StopTime = DateTime.Now;
            Duration = (TimeSpan)(StopTime - StartTime);
            StartTime = null;
            StopTime = null;
        }

        public void DisplayDuration()
        {
            Console.WriteLine(Duration);
        }


    }

}
