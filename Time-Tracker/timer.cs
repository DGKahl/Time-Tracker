using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Tracker
{
    public partial class timer : Form
    {
        timeobject thistimer = new timeobject();
        Timer mytimer = new Timer();
        Timer closingtimer = new Timer();

        // --> wird aktuell überhaupt nicht verwendet!!!!
        public timer()
        {
            InitializeComponent();
            measuretime();

            //initialize Timer_Ticks:

            //Update der Zeitanzeige:
            mytimer.Interval = (1000); // 1 secs
            mytimer.Tick += new EventHandler(timer_Tick);
            mytimer.Start();

            //Countdown bis zum Fenster-Schließen:
            closingtimer.Interval = (3000); // 3 secs
            closingtimer.Tick += new EventHandler(timer_TickClose);
            closingtimer.Start();
        }

        public timer(string timername)
        {
            InitializeComponent();
            this.Text = timername;
            measuretime();

            //initialize Timer_Tick:
            mytimer.Interval = (1000); // 1 secs
            mytimer.Tick += new EventHandler(timer_Tick);
            mytimer.Start();

            //Countdown bis zum Fenster-Schließen:
            closingtimer.Interval = (3000); // 3 secs
            closingtimer.Tick += new EventHandler(timer_TickClose);
        }

        //Methode zum refreshen der aktuellen Timeranzeige
        private void timer_Tick(object sender, EventArgs e)
        {
            //lblDurationTime.Text = (DateTime.Now.ToLocalTime() - thistimer.getStart()).ToString(@"hh\:mm\:ss");
            lblDurationTime.Text = DateTime.Now.Subtract(thistimer.getStart()).ToString(@"hh\:mm\:ss");
        }

        //Methode zum refreshen der automatischen Fenster-SChließung
        private void timer_TickClose(object sender, EventArgs e)
        {
            closingtimer.Stop();
            //!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!!'!'!'!''!'!'!'!'!'!'!'!!'!'!''!'!'!'!'!'!'!'!!''!'!'!'!'!'!'!'!!'!'!''!'!'
            // --> HIER MUSS IRGENDWIE EIN EVENT HANDLER REIN, um beim FORMCLOSE Event den Namen der Form an MAIN.CS zu schicken.
            //Dort dann die Liste der offenen forms entsprechend um diesen Eintrag reduzieren.
            //!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!'!!'!'!'!''!'!'!'!'!'!'!'!!'!'!''!'!'!'!'!'!'!'!!''!'!'!'!'!'!'!'!!'!'!''!'!'
            //PS: Falls das nicht klappt mit der Liste, kann diese auch einfach jedes Mal, wenn das FormClose Event erfolgt, komplett neu 
            //auf Basis aller offenen Forms befüllt werden; so was ähnliches steht schon in einer anderen Methode...
            this.Close();
        }

        public void measuretime()
        {
            thistimer.startTimer();
            lblStartTime.Text = thistimer.getStart().ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thistimer.stopTimer();
            lblEndTime.Text = thistimer.getEnd().ToString();
            mytimer.Stop();
            writedata();
            closingtimer.Start();
        }

        public void writedata()
        {
            sqladapter myadapter = new sqladapter();
            myadapter.savetime(thistimer, this.Text);
            lblStatus.Text = "saved!";
        }
    }
}
