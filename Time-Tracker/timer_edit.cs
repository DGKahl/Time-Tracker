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
    public partial class timer_edit : Form
    {
        //EVENT UND DELEGATE - Um die gespeicherten Änderungen in der main-Form direkt zu aktualisieren
        public event Formhandler EditsAreSaved;
        public delegate void Formhandler(timer_edit f, EventArgs e);

        public timer_edit()
        {
            InitializeComponent();
            resetData();
            Fillcb();
            btnOK.Enabled = false;
            btnDelete.Enabled = false;
            btnSelect.Enabled = false;
        }

        //Resetten aller Informationen
        void resetData()
        {
            txtName.Text = "";
            txtName.Enabled = false;
            txtInfo.Text = "";
            txtInfo.Enabled = false;
            rbSingle.Checked = true;
            rbSingle.Enabled = false;
            rbParallel.Enabled = false;
            btnPickColor.BackColor = default;
            btnPickColor.Enabled = false;
            cbSelection.Enabled = true;
            btnOK.Enabled = false;
            btnDelete.Enabled = false;
            btnSelect.Enabled = false;
        }

        //für das schnelle "enablen" aller Felder
        void enable_editing()
        {
            txtName.Enabled = true;
            txtInfo.Enabled = true;
            rbSingle.Enabled = true;
            rbParallel.Enabled = true;
            btnPickColor.Enabled = true;
            cbSelection.Enabled = true;
            btnOK.Enabled = true;
            btnDelete.Enabled = true;
        }

        void Fillcb()
        {
            cbSelection.Items.Clear();
            sqladapter adapter = new sqladapter();
            List<string> list = adapter.GetAllTimers();

            foreach (string t in list)
            {
                cbSelection.Items.Add(t);
            }
        }

        //Logik für den Bestätigungsbutton --> je nach gewähltem Modus anders!
        private void btnOK_Click(object sender, EventArgs e)
        {
            sqladapter dbaccess = new sqladapter();
            List<string> log = dbaccess.GetCurrentLogSettings();
            bool logflag = Boolean.Parse(log[0]);

            //Prüfen des Radio-Nuttons
            bool test;

            if (rbParallel.Checked == true)
            {
                test = true;
            }
            else
            {
                test = false;
            }


            //Modus: Anlage ----------------------------
            if (btnNew.Text == "Abbruch")
            {
                //Prüfung, ob Namensfeld befüllt
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bitte Namen für neuen Timer eingeben!", "Speichern nicht möglich", MessageBoxButtons.OK);
                }
                else if (btnPickColor.BackColor == default) //Prüfung, ob Farbe gewählt
                {
                    MessageBox.Show("Bitte Namen für neuen Timer eingeben!", "Speichern nicht möglich", MessageBoxButtons.OK);

                }
                else //Minimaleingaben vorhanden --> Speichern.
                {
                    //Prüfung, ob Timer schon existiert:
                    List<string> list = new List<string>();
                    list = dbaccess.GetAllTimers();
                    if (list.Contains(this.txtName.Text))
                    {
                        MessageBox.Show("Timer mit gleichem Namen existiert bereits!", "Speichern nicht möglich", MessageBoxButtons.OK);
                    }
                    else
                    {
                        dbaccess.AddTimer(this.txtName.Text, this.txtInfo.Text, test, btnPickColor.BackColor.ToArgb());
                        log_action(logflag);               //Logfile updaten.
                        EditsAreSaved(this, e);            //Logfenster in main aktualisieren (Subscriber).
                        resetData();
                        Fillcb();
                        btnNew.Text = "Neu...";
                    }
                }

            } else if (btnNew.Text == "Neu...")
            {
                //Modus: Ändern ----------------------------
                if (txtName.Text == "") //Prüfung, ob Namensfeld befüllt
                {
                    MessageBox.Show("Bitte Namen für neuen Timer eingeben!", "Speichern nicht möglich", MessageBoxButtons.OK);
                }
                else if (btnPickColor.BackColor == default) //Prüfung, ob Farbe gewählt
                {
                    MessageBox.Show("Bitte Namen für neuen Timer eingeben!", "Speichern nicht möglich", MessageBoxButtons.OK);

                } else //Minimaleingaben vorhanden --> Speichern.
                { 
                    dbaccess.EditTimer(this.cbSelection.SelectedItem.ToString(), this.txtInfo.Text, test, btnPickColor.BackColor.ToArgb());
                    log_action(logflag);               //Logfile updaten.    
                    EditsAreSaved(this, e);            //Logfenster in main aktualisieren (Subscriber).
                    resetData();
                    Fillcb(); //TODO - Leeren des gewählten Timers im Dropdown Fenster nach Speichern der Änderung.
                }
            }
        }

        private void cbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
            resetData();
            enable_editing();
            sqladapter dbaccess = new sqladapter();
            timeobject mytimer = new timeobject();
            string selectedtimer = cbSelection.SelectedItem.ToString();
            int id = sqladapter.getTimerID(selectedtimer);
            mytimer = dbaccess.mytimer(id);
            btnPickColor.BackColor = ColorTranslator.FromHtml(mytimer.getColor().ToString());
            txtName.Text = mytimer.getName();
            txtInfo.Text = mytimer.getDescr();
            if (mytimer.getParallel() == true)
            {
                rbParallel.Checked = true;
            } else
            {
                rbSingle.Checked = true;
            }
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.AllowFullOpen = true;
            colorDlg.SolidColorOnly = false;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                btnPickColor.BackColor = colorDlg.Color;
            }
        }

        //Logging der Aktionen -- erster Versuch (TODO)
        private void log_action(bool flag)
        {
            if (flag == true)
            {

                //Logeintrag "bauen"
                string logentry = "";

                if (btnOK.Text == "Anlegen")
                {
                    logentry = "[" + DateTime.Now + "]: Timer '" + txtName.Text + "' wurde angelegt.";
                }
                else if (btnOK.Text == "Ändern")
                {

                    logentry = "[" + DateTime.Now + "]: Timer '" + cbSelection.SelectedItem.ToString() + "' wurde geändert.";
                }
                else if (btnOK.Text == "Löschen")
                {
                    logentry = "[" + DateTime.Now + "]: Timer '" + cbSelection.SelectedItem.ToString() + "' wurde gelöscht.";
                }

                //Eintrag speichern (fügt aktuell neue Zeilen unten an - TODO)
                using (StreamWriter sw = new StreamWriter(@"logfile.txt", true))
                {
                    sw.WriteLine(logentry);
                    sw.Flush();
                }

            } else
            {
                //nichts machen; Logging deaktiviert.
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqladapter dbaccess = new sqladapter();
            List<string> log = dbaccess.GetCurrentLogSettings();
            bool logflag = Boolean.Parse(log[0]);

            //Prüfung, ob ein Timer zum Löschen gewählt wurde
            if (this.cbSelection.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Bitte Timer auswählen!", "Löschen nicht möglich", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Möchten Sie den Eintrag archivieren (Nein), oder den Timer und alle hinterlegten Zeiten unwiderruflich löschen (Ja)?", "Warnung", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    //ALLES LÖSCHEN
                    dbaccess.DeleteTimer(this.cbSelection.SelectedItem.ToString());
                    log_action(logflag);           //Logfile updaten.
                    EditsAreSaved(this, e);        //Logfenster in main aktualisieren (Subscriber).
                    resetData();
                    Fillcb();
                }
                else if (MessageBox.Show("Möchten Sie den Eintrag archivieren (Nein), oder den Timer und alle hinterlegten Zeiten unwiderruflich löschen (Ja)?", "Warnung", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                {
                    //Nur archiveren
                    dbaccess.ArchiveTimer(this.cbSelection.SelectedItem.ToString());
                    log_action(logflag);           //Logfile updaten.
                    EditsAreSaved(this, e);        //Logfenster in main aktualisieren (Subscriber).
                    resetData();
                    Fillcb();
                }
                else
                {
                    //User hat "Cancel" geklickt. Nichts machen.
                    resetData();
                    Fillcb();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Start - Alle Eingaben löschen, Dropdown deaktiviert, Button = "Abbruch"
            if (btnNew.Text == "Neu...")
            {
                Fillcb();
                resetData();
                enable_editing();
                cbSelection.Enabled = false;
                btnNew.Text = "Abbruch";

            } else
            {
                //Abbruch -> Alles resetten
                resetData();
                btnNew.Text = "Neu...";
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}

