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
        public timer()
        {
            InitializeComponent();
        }

        public timer(string timername)
        {
            InitializeComponent();
            this.Text = timername;
        }
    }
}
