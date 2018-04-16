using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceApp.service
{
    class TaskQuery
    {
        string query, error;
        int result;
        Stopwatch stopwatch;

        public TaskQuery()
        {
            stopwatch = new Stopwatch();
            result = -1;
        }

        public void startWach()
        {
            stopwatch.Start();
        }

        public void stopWatch()
        {
            stopwatch.Stop();
        }

        public void setResult(int result, string error)
        {
            this.result = result;
            this.error = error;
        }

        public int getResult()
        {
            return result;
        }

        public string getError()
        {
            return error;
        }

        public string getTime()
        {
            TimeSpan ts = stopwatch.Elapsed;
            return String.Format("{0:00}:{1:00}.{2:000}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
        }
    }
}
