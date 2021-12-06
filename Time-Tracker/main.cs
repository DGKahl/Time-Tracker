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
        public static List<string> timerrunningstatus = new List<string>();

        public Start()
        {
            InitializeComponent();
            SetQuickslots();
            Fillcb();
            AllTimersStatus();
        }

        // !!! Ich "glaube" hier passiert folgendes:
        // Zuordung des Events "Formhandler" zu Delegate "FormIsClosed" --> Verweis auf Methode "EventHappens"
        // ???
        public void Subscriber(timer f)
        {
            f.FormIsClosed += new timer.Formhandler(EventHappens);
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

        // !!! Delegate+Eventhandler in Action!
        public void EventHappens(Form f, GetClosedFormEventArgs e)
        {
            int a = 2;
        }

        //Fall 1: Parallel-Timer laufen --> Es wird ein Single-Timer gestartet; alle Parallel-Timer enden.
        //d.h.: flag = false, newTimer = true.
        //0..n (laufende) Timer enden.


        //Fall 2: Ein Single-Timer läuft --> Es wird ein Single-Timer gestartet; der alte Single-Timer endet.
        //d.h.: flag = true, newTimer = true.
        //1 laufender Timer endet.

        //Fall 3: Ein Single-Timer läuft --> Es wird ein Parallel-Timer gestartet; der alte Single-Timer endet.
        //d.h.: flag = true, newTimer = false.
        //1 laufender Timer endet.

        //[INFO] Fall 4: Parallel-Timer laufen --> Es wird ein Parallel-Timer gestartet; die alten Parallel-Timer laufen weiter.
        //[INFO] d.h.: flag = false, newTimer = false.


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

                if (check == true)
                {
                    MessageBox.Show("Der Timer ist bereits geöffnet.", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    timerrunningstatus.Add(timername);
                    timer OpenForm = new timer(timername);

                    //Subscibing von "main" zur "form", die gerade erstellt wurde!!! <<<<--------- WICHTIG!
                    this.Subscriber(OpenForm);

                    OpenForm.Show();
                }
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
                timerrunningstatus.Add(btnQTimer1.Text);
                timer OpenForm = new timer(btnQTimer1.Text);

                //Subscibing von "main" zur "form", die gerade erstellt wurde!!! <<<<--------- WICHTIG!
                this.Subscriber(OpenForm);

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
                timerrunningstatus.Add(btnQTimer2.Text);
                timer OpenForm = new timer(btnQTimer2.Text);

                //Subscibing von "main" zur "form", die gerade erstellt wurde!!! <<<<--------- WICHTIG!
                this.Subscriber(OpenForm);

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
                timerrunningstatus.Add(btnQTimer3.Text);
                timer OpenForm = new timer(btnQTimer3.Text);

                //Subscibing von "main" zur "form", die gerade erstellt wurde!!! <<<<--------- WICHTIG!
                this.Subscriber(OpenForm);

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
