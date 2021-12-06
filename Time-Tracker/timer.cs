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
        }

        //Methode zum refreshen der aktuellen Timeranzeige
        private void timer_Tick(object sender, EventArgs e)
        {
            //lblDurationTime.Text = (DateTime.Now.ToLocalTime() - thistimer.getStart()).ToString(@"hh\:mm\:ss");
            lblDurationTime.Text = DateTime.Now.Subtract(thistimer.getStart()).ToString(@"hh\:mm\:ss");
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
            this.Close();
        }

        public void writedata()
        {
            sqladapter myadapter = new sqladapter();
            myadapter.savetime(thistimer, this.Text);
            lblStatus.Text = "saved!";
        }

        public void ExternalClosing()
        {
            thistimer.stopTimer();
            lblEndTime.Text = thistimer.getEnd().ToString();
            mytimer.Stop();
            writedata();
            this.Close();
        }
    }
}
