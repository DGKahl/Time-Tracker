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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            SetQuickslots();
            Fillcb();
        }

        void Fillcb()
        {
            sqladapter adapter = new sqladapter();
            List<string> list = adapter.GetAllTimers();

            foreach (string t in list)
            {
                cbTimerSelection.Items.Add(t);
            }
        }


        void SetQuickslots()
        {
            sqladapter dbaccess = new sqladapter();
            List<string> qs_items = dbaccess.GetQuickslots();

            btnQTimer1.Text = qs_items[0];
            btnQTimer2.Text = qs_items[1];
            btnQTimer3.Text = qs_items[2];
        }

        bool checkFormStatus(string formname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == formname)
                {
                    return true;
                }
            }
            return false;
        }



        //---------------------------------------------------------------------------------------
        // ### KNÖPFE UND INTERAKTION -----------------------------------------------------------
        //---------------------------------------------------------------------------------------

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbTimerSelection.SelectedItem != null) {
                string timername = cbTimerSelection.SelectedItem.ToString();
                timer OpenForm = new timer(timername);
                OpenForm.Show();
            } else
            {
                MessageBox.Show("Kein Timer ausgewählt.", "Information", MessageBoxButtons.OK);
            }
        }

        private void btnQTimer1_Click(object sender, EventArgs e)
        {
            bool check = checkFormStatus(btnQTimer1.Text);

            if (check==true)
            {
                MessageBox.Show("Der Timer ist bereits geöffnet.", "Information", MessageBoxButtons.OK);
            }
            else
            {
                timer OpenForm = new timer(btnQTimer1.Text);
                OpenForm.Show();
            }
        }

        private void btnQTimer2_Click(object sender, EventArgs e)
        {
            bool check = checkFormStatus(btnQTimer2.Text);

            if (check == true)
            {
                MessageBox.Show("Der Timer ist bereits geöffnet.", "Information", MessageBoxButtons.OK);
            }
            else
            {
                timer OpenForm = new timer(btnQTimer2.Text);
                OpenForm.Show();
            }
        }

        private void btnQTimer3_Click(object sender, EventArgs e)
        {
            bool check = checkFormStatus(btnQTimer3.Text);

            if (check == true)
            {
                MessageBox.Show("Der Timer ist bereits geöffnet.", "Information", MessageBoxButtons.OK);
            }
            else
            {
                timer OpenForm = new timer(btnQTimer3.Text);
                OpenForm.Show();
            }
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings OpenForm = new Settings();
            OpenForm.Show();
        }
    }
}
