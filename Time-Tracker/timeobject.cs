using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Time_Tracker
{
    class timeobject
    {
        DateTime start;
        DateTime end;
        TimeSpan elapsed;
        //Stopwatch stopwatch = new Stopwatch();    //Werte minimal größer als Diff. zw. Start-End...

        //### Getter und Setter
        public DateTime getStart() {return start;}
        public DateTime getEnd() { return end; }
        public TimeSpan getElapsed() { return elapsed; }


        public void startTimer()
        {
            //stopwatch.Start();
            start = DateTime.Now.ToLocalTime();
        }

        public void stopTimer()
        {
            //stopwatch.Stop();
            end = DateTime.Now.ToLocalTime();
            //elapsed2 = stopwatch.Elapsed;
            elapsed = end - start;
        }

        public timeobject getData()
        {
            return this;
        }

    }
}
