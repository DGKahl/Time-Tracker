using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        //DELEGATE STUFF
        public void Subscriber(timer f) //Subscriber für Form "timer"
        {
            f.FormIsClosed += new timer.Formhandler(EventHappens);
        }

        public void Subscriber(Settings f) //Subscriber für Form "settings"
        {
            f.ChangesAreSaved += new Settings.Formhandler(RefreshMainEvent);
        }

        public void Subscriber(timer_edit f) //Subscriber für Form "timer_edit"
        {
            f.EditsAreSaved += new timer_edit.Formhandler(UpdateLogEvent);
        }

        // !!! Delegate+Eventhandler in Action!
        public void EventHappens(timer f, GetClosedFormEventArgs e)
        {
            timerrunningstatus.Remove(f);
        }

        public void RefreshMainEvent(Settings f, EventArgs e)
        {
            SetQuickslots();
        }

        public void UpdateLogEvent(timer_edit f, EventArgs e)
        {
            //Ausgabe der aktuellen Logdatei (aktuell alles, neueste Einträge unten; nach jedem Update wird ALLES ausgelesen - TODO)
            //Ziel: Direkt den neuen Eintrag übergeben, oben anfügen, max. 10 Einträge vorhalten.
            rtbLog.Text = "";

            using (StreamReader sr = new StreamReader(@"logfile.txt"))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    rtbLog.Text += s + "\n";
                }
            }
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


        //Prüfung der zu startenden Timer bei Button-Klicks
        private void ExecuteTimerStartCheck(string timername, bool manualselection)
        {
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
                        //timerrunningstatus.Remove(t);
                    }
                    timer OpenForm = new timer(timername);

                    //Subscibing von "main" zur "form", die gerade erstellt wurde!!! <<<<--------- WICHTIG!
                    this.Subscriber(OpenForm);

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
                            //timerrunningstatus.Remove(t);
                        }
                    }
                    //timerrunningstatus.Add(timername);
                    timer OpenForm = new timer(timername);

                    //Subscibing von "main" zur "form", die gerade erstellt wurde!!! <<<<--------- WICHTIG!
                    this.Subscriber(OpenForm);

                    timerrunningstatus.Add(OpenForm);
                    OpenForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Timer ist schon geöffnet.", "Information", MessageBoxButtons.OK);
            }
        }


        //---------------------------------------------------------------------------------------
        // ### KNÖPFE UND INTERAKTION -----------------------------------------------------------
        //---------------------------------------------------------------------------------------

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbTimerSelection.SelectedItem != null)
            {
                this.ExecuteTimerStartCheck(cbTimerSelection.SelectedItem.ToString(), true);
            }
            else
            {
                MessageBox.Show("Kein Timer ausgewählt.", "Information", MessageBoxButtons.OK);
            }
        }

        private void btnQTimer1_Click(object sender, EventArgs e)
        {
            this.ExecuteTimerStartCheck(btnQTimer1.Text, false);
        }

        private void btnQTimer2_Click(object sender, EventArgs e)
        {
            this.ExecuteTimerStartCheck(btnQTimer2.Text, false);
        }

        private void btnQTimer3_Click(object sender, EventArgs e)
        {
            this.ExecuteTimerStartCheck(btnQTimer3.Text, false);
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings OpenForm = new Settings();
            this.Subscriber(OpenForm);
            OpenForm.Show();
        }

        private void neuerTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_edit OpenForm = new timer_edit(1);
            this.Subscriber(OpenForm);
            OpenForm.Show();
        }

        private void timerBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_edit OpenForm = new timer_edit(2);
            this.Subscriber(OpenForm);
            OpenForm.Show();
        }

        private void timerLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_edit OpenForm = new timer_edit(3);
            this.Subscriber(OpenForm);
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

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            timer[] temptimers = timerrunningstatus.ToArray();

            foreach (timer t in temptimers)
            {
                t.ExternalClosing();
                //timerrunningstatus.Remove(t);
            }
        }


        //---------------------------------------------------------------------------------------
        // ### Logfenster -----------------------------------------------------------------------
        //---------------------------------------------------------------------------------------




    }
}
