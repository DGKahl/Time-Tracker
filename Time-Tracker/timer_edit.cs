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
        }

        public timer_edit(int i)
        {
            InitializeComponent();

            switch (i)
            {
                case 1: //neuen Timer anlegen
                    cbSelection.Hide();
                    btnNew.BackColor = Color.Green;
                    btnEdit.BackColor = Color.Red;
                    btnDelete.BackColor = Color.Red;
                    btnOK.Text = "Anlegen";
                    rbSingle.Checked = true;
                    break;
                case 2: //Timer wählen und bearbeiten
                    txtName.Hide();
                    Fillcb();
                    btnNew.BackColor = Color.Red;
                    btnEdit.BackColor = Color.Green;
                    btnDelete.BackColor = Color.Red;
                    btnOK.Text = "Ändern";
                    break;
                case 3: //TImer wählen und löschen
                    txtName.Hide();
                    Fillcb();
                    btnNew.BackColor = Color.Red;
                    btnEdit.BackColor = Color.Red;
                    btnDelete.BackColor = Color.Green;
                    btnOK.Text = "Löschen";
                    break;
                default:
                    break;
            }
        }

        //Resetten aller Informationen
        void resetData()
        {
            txtName.Clear();
            cbSelection.Items.Add("");
            cbSelection.SelectedItem = "";
            cbSelection.Items.Clear();
            txtInfo.Clear();
            rbParallel.Checked = false;
            rbSingle.Checked = false;
            btnPickColor.Enabled = false;
            rbSingle.Checked = true;
        }

        void Fillcb()
        {
            sqladapter adapter = new sqladapter();
            List<string> list = adapter.GetAllTimers();

            foreach (string t in list)
            {
                cbSelection.Items.Add(t);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            resetData();
            cbSelection.Hide();
            txtName.Visible = true;
            btnPickColor.Enabled = true;
            btnNew.BackColor = Color.Green;
            btnEdit.BackColor = Color.Red;
            btnDelete.BackColor = Color.Red;
            btnOK.Text = "Anlegen";
            rbSingle.Checked = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            resetData();
            txtName.Hide();
            cbSelection.Visible = true;
            btnPickColor.Enabled = true;
            btnNew.BackColor = Color.Red;
            btnEdit.BackColor = Color.Green;
            btnDelete.BackColor = Color.Red;
            btnOK.Text = "Ändern";
            Fillcb();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            resetData();
            txtName.Hide();
            cbSelection.Visible = true;
            btnNew.BackColor = Color.Red;
            btnEdit.BackColor = Color.Red;
            btnDelete.BackColor = Color.Green;
            btnOK.Text = "Löschen";
            Fillcb();
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
            if (btnOK.Text == "Anlegen")
            {
                //Prüfung, ob Namensfeld befüllt
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bitte Namen für neuen Timer eingeben!", "Speichern nicht möglich", MessageBoxButtons.OK);
                }
                else
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
                        dbaccess.AddTimer(this.txtName.Text, this.txtInfo.Text, test);
                        log_action(logflag);               //Logfile updaten.
                                                           //btnOK.Text = "OK!";
                        EditsAreSaved(this, e);         //Logfenster in main aktualisieren (Subscriber).
                        resetData();
                        Fillcb();
                    }
                }

            } else if (btnOK.Text == "Ändern")
            {
                //Modus: Ändern ----------------------------
                //Prüfung, ob Namensfeld befüllt
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bitte Namen für neuen Timer eingeben!", "Speichern nicht möglich", MessageBoxButtons.OK);
                }
                else
                {
                    //sqladapter dbaccess = new sqladapter();
                    dbaccess.EditTimer(this.cbSelection.SelectedItem.ToString(), this.txtInfo.Text, test);
                    log_action(logflag);               //Logfile updaten.
                                                       //btnOK.Text = "OK!";        
                    EditsAreSaved(this, e);         //Logfenster in main aktualisieren (Subscriber).
                    resetData();
                    Fillcb();
                }

            } else if (btnOK.Text == "Löschen")
            {
                //Modus: Löschen (archivieren oder hard-delete alles?) ------------------------------
                //Prüfung, ob Namensfeld befüllt
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bitte Namen für neuen Timer eingeben!", "Speichern nicht möglich", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Möchten Sie den Eintrag archivieren (Nein), oder den Timer und alle hinterlegten Zeiten unwiderruflich löschen (Ja)?", "Warnung", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        //ALLES LÖSCHEN
                        //sqladapter dbaccess = new sqladapter();
                        dbaccess.DeleteTimer(this.cbSelection.SelectedItem.ToString());
                        log_action(logflag);           //Logfile updaten.
                                                       //btnOK.Text = "OK!";
                        EditsAreSaved(this, e);     //Logfenster in main aktualisieren (Subscriber).
                        resetData();
                        Fillcb();

                    }
                    else if (MessageBox.Show("Möchten Sie den Eintrag archivieren (Nein), oder den Timer und alle hinterlegten Zeiten unwiderruflich löschen (Ja)?", "Warnung", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                    {
                        //Nur archiveren
                        //sqladapter dbaccess = new sqladapter();
                        dbaccess.ArchiveTimer(this.cbSelection.SelectedItem.ToString());
                        log_action(logflag);           //Logfile updaten.
                                                       //btnOK.Text = "OK!";
                        EditsAreSaved(this, e);     //Logfenster in main aktualisieren (Subscriber).
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
        }

        private void cbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqladapter dbaccess = new sqladapter();
            timeobject mytimer = new timeobject();
            string selectedtimer = cbSelection.SelectedItem.ToString();
            int id = sqladapter.getTimerID(selectedtimer);
            mytimer = dbaccess.mytimer(id);
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

                //TODO Color über sqladapter für Timer speichern!
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


        //Zum Editieren des Namens eines vorhandenen Timers
        private void btnNameEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
