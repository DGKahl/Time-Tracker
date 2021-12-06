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
        //zum Tracken, ob ein Single Timer läuft oder nicht
        public static bool parallelflag = false;
        public static IDictionary<string, bool> timerparallelstatus = new Dictionary<string, bool>();
        public static List<timer> timerrunningstatus = new List<timer>();

        public Start()
        {
            InitializeComponent();
            SetQuickslots();
            Fillcb();
            AllTimersStatus();
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

        //Ermitteln eines Dictionaries mit allen vorhandenen Timern und dem Parallel-Status:
        void AllTimersStatus()
        {
            sqladapter adapter = new sqladapter();
            timerparallelstatus = adapter.AllTimersParallelStatus();
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
            string timername;

            if (cbTimerSelection.SelectedItem != null)
            {
                timername = cbTimerSelection.SelectedItem.ToString();
                bool check = checkFormStatus(timername);

                if (check != true)
                {
                    bool timertype = timerparallelstatus[timername];
                    timer[] temptimers = timerrunningstatus.ToArray();

                    //timertype = true --> Single Timer; alle laufenden Timer beenden
                    if (timertype == false)
                    {
                        foreach (timer t in temptimers)
                        {
                            t.ExternalClosing();
                            timerrunningstatus.Remove(t);
                        }
                        timer OpenForm = new timer(timername);
                        timerrunningstatus.Add(OpenForm);
                        OpenForm.Show();
                    }
                    else //Parallel Timer; Prüfung, ob ein laufender Single-Timer beendet werden muss
                    {
                        foreach (timer t in temptimers)
                        {
                            if (timerparallelstatus[t.Text] == false)
                            {
                                t.ExternalClosing();
                                timerrunningstatus.Remove(t);
                            }
                        }
                        //timerrunningstatus.Add(timername);
                        timer OpenForm = new timer(timername);
                        timerrunningstatus.Add(OpenForm);
                        OpenForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Timer ist schon geöffnet.", "Information", MessageBoxButtons.OK);
                }
            }
            else
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
                //timerrunningstatus.Add(btnQTimer1.Text);
                timer OpenForm = new timer(btnQTimer1.Text);
                timerrunningstatus.Add(OpenForm);
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
                //timerrunningstatus.Add(btnQTimer2.Text);
                timer OpenForm = new timer(btnQTimer2.Text);
                timerrunningstatus.Add(OpenForm);
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
                //timerrunningstatus.Add(btnQTimer3.Text);
                timer OpenForm = new timer(btnQTimer3.Text);
                timerrunningstatus.Add(OpenForm);
                OpenForm.Show();
            }
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings OpenForm = new Settings();
            OpenForm.Show();
        }

        private void neuerTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_edit OpenForm = new timer_edit(1);
            OpenForm.Show();
        }

        private void timerBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_edit OpenForm = new timer_edit(2);
            OpenForm.Show();
        }

        private void timerLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_edit OpenForm = new timer_edit(3);
            OpenForm.Show();
        }

        private void zeitenBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timelist OpenForm = new timelist();
            OpenForm.Show();
        }

        private void auswertungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            results OpenForm = new results();
            OpenForm.Show();
        }
    }
}
