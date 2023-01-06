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
        //Timer-Daten
        int id;
        string name;
        string descr;
        bool parallel;
        int quickslot;
        int color;

        //Zeiten
        DateTime start;
        DateTime end;

        //### Getter und Setter
        public DateTime getStart() {return start;}
        public DateTime getEnd() { return end; }

        public int getID() { return id; }
        public string getName() { return name; }
        public string getDescr() { return descr; }
        public bool getParallel() { return parallel; }
        public int getQuickslot() { return quickslot; }
        public int getColor() { return color; }
        public void setID(int i) { id=i; }
        public void setName(string s) { name=s; }
        public void setDescr(string s) { descr=s; }
        public void setParallel(bool b) { parallel=b; }
        public void setQuickslot(int i) {quickslot = i; }
        public void setColor(int i) { color = i; }

        //### Methoden etc.
        public void startTimer()
        {
            start = DateTime.Now.ToLocalTime();
        }

        public void stopTimer()
        {
            end = DateTime.Now.ToLocalTime();
        }
    }
}
