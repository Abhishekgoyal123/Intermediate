using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_1
{
    public class Stopwatch
    {
        public DateTime startTime;

        public DateTime endTime;

        public bool isRunning;
        public void start()
        {
            if (!isRunning)
            {
                isRunning = true;
                startTime = DateTime.Now;

            }
            else
            {
                throw new InvalidOperationException("cant start again, watch is already running");
            }
        }


        public void stop()
        {
            if (isRunning)
            {
                isRunning = false;
                endTime = DateTime.Now;
            }
        }

    }
}
