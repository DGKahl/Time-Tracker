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
    public partial class timer_edit : Form
    {
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


            //Modus: Anlage
            if (btnOK.Text == "Anlegen")
            {
                sqladapter dbaccess = new sqladapter();
                dbaccess.AddTimer(this.txtName.Text, this.txtInfo.Text, test);
                btnOK.Text = "OK!";
            } else if (btnOK.Text == "Ändern")
            { 
            //Modus: Ändern
                sqladapter dbaccess = new sqladapter();
                dbaccess.EditTimer(this.cbSelection.SelectedItem.ToString(), this.txtInfo.Text, test);
                btnOK.Text = "OK!";
            } else if (btnOK.Text == "Löschen")
            {
                //Modus: Löschen (archivieren oder hard-delete alles?)
                if (MessageBox.Show("Möchten Sie den Eintrag archivieren (Nein), oder den Timer und alle hinterlegten Zeiten unwiderruflich löschen (Ja)?","Warnung",MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    //ALLES LÖSCHEN
                    sqladapter dbaccess = new sqladapter();
                    dbaccess.DeleteTimer(this.cbSelection.SelectedItem.ToString());
                    btnOK.Text = "OK!";

                } else if (MessageBox.Show("Möchten Sie den Eintrag archivieren (Nein), oder den Timer und alle hinterlegten Zeiten unwiderruflich löschen (Ja)?", "Warnung", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                {
                    //Nur archiveren
                    sqladapter dbaccess = new sqladapter();
                    dbaccess.ArchiveTimer(this.cbSelection.SelectedItem.ToString());
                    btnOK.Text = "OK!";
                } else
                {
                    //User hat "Cancel" geklickt. Nichts machen.
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
    }
}
