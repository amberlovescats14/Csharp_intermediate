using System;
using System.Collections.Generic;

namespace Mosh_Part2.exerecises
{
    public class Stopwatch
    {
        private readonly List<TimeSpan> timeRecords = new List<TimeSpan>();
        private DateTime startTime;
        private DateTime endTime;
        private Boolean timerStarted = false;
        private TimeSpan lastTimerSpan;

        public Stopwatch()
        {
        }

        public void Start()
        {
            if (timerStarted) Console.WriteLine("Timer has already started...");
            else
            {
                this.startTime = new DateTime();
                this.timerStarted = true;
            }
        }

        public void Stop()
        {
            if (!timerStarted) Console.WriteLine("Please start timer first.");
            else
            {
                this.endTime = new DateTime();
                this.lastTimerSpan = this.startTime - this.endTime;
                timeRecords.Add(this.lastTimerSpan);
                Console.WriteLine($"Time elapsed: {this.lastTimerSpan}");
            }
        }

        public void getLastTimerSpan()
        {
            Console.WriteLine($"Last timer span: {lastTimerSpan}");
        }

        public void printAllTimerSpans()
        {
            foreach (var time in timeRecords)
            {
                Console.WriteLine($"Time: {time}");
            }
        }
    }
}
