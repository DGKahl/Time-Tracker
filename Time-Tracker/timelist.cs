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
    public partial class timelist : Form
    {
        public timelist()
        {
            InitializeComponent();
            Fillcb();

            //Deaktiviere alle Eingaben, bevor nicht ein Eintrag aus der Dropbox für "Timer" gewählt wurde...
            BlockEditing();
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

        public void BlockEditing()
        {
            btnDeleteSelection.Enabled = false;
            btnRefresh.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnSaveTime.Enabled = false;
            dgvTimerTimes.Enabled = false;
            dtpDate.Enabled = false;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
        }

        public void EnableEditing()
        {
            btnDeleteSelection.Enabled = true;
            btnRefresh.Enabled = true;
            btnSaveChanges.Enabled = true;
            btnSaveTime.Enabled = true;
            dgvTimerTimes.Enabled = true;
            dtpDate.Enabled = true;
            dtpStart.Enabled = true;
            dtpEnd.Enabled = true;
        }

        //Aktiviere Bearbeitung nach Auswahl eines Timers in der Dropbox:
        private void cbTimerSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimerSelection.SelectedItem.ToString() != "")
            {
                EnableEditing();
            } else
            {
                BlockEditing();
            }
        }

        private void btnSaveTime_Click(object sender, EventArgs e)
        {
            sqladapter dbaccess = new sqladapter();
            bool choice = dbaccess.CheckExistingTime(dtpDate.Value.ToShortDateString(), dtpStart.Value.ToShortTimeString(), dtpEnd.Value.ToShortTimeString());

            if (choice == true)
            {
                MessageBox.Show("Eintrag bereits für einen anderen Single-Timer vorhanden!", "Fehler", MessageBoxButtons.OK);
            } else
            {
                dbaccess.savetime(cbTimerSelection.SelectedItem.ToString(), dtpDate.Value, dtpStart.Value, dtpEnd.Value);
            }
        }
    }
}
