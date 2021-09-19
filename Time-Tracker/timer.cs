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

        public timer()
        {
            InitializeComponent();
            measuretime();
        }

        public timer(string timername)
        {
            InitializeComponent();
            this.Text = timername;
            measuretime();
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
            writedata();
        }

        public void writedata()
        {
            sqladapter myadapter = new sqladapter();
            myadapter.savetime(thistimer, this.Text);
            lblStatus.Text = "saved!";
        }
    }
}
