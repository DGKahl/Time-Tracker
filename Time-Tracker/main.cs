﻿using System;
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            setQuickslots();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            string timername = cbTimerSelection.SelectedItem.ToString();
            timer OpenForm = new timer(timername); 
        }

        void setQuickslots()
        {
            sqladapter dbaccess = new sqladapter();
            List<string> qs_items = dbaccess.SetQuickslots();
            //qs_items = dbaccess.SetQuickslots();

            btnQTimer1.Text = qs_items[0];
            btnQTimer2.Text = qs_items[1];
            btnQTimer3.Text = qs_items[2];
        }



    }
}
