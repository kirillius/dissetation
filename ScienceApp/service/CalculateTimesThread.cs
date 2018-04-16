using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceApp.service
{
    class CalculateTimesThread
    {
        int lambda;
        int delay;
        int modelTime;
        Random rnd;

        public CalculateTimesThread(int lambda, Random rnd)
        {
            modelTime = 3600000; //1 час
            this.lambda = lambda;
            this.rnd = rnd;
            double tCalculate = (-1 * (1 / (double)lambda)) * Math.Log(rnd.NextDouble());
            Console.WriteLine(String.Format("T double {0:F20}", tCalculate));
            delay = Convert.ToInt32(tCalculate*modelTime);
        }

        public int getDelay()
        {
            return delay;
        }
    }
}
