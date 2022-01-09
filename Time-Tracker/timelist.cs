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
        //zum Aktualisieren der Anzeigen bei erfolgter Speicherung.
        Timer mytimer = new Timer();

        public timelist()
        {
            InitializeComponent();
            Fillcb();

            //initialize Timer_Tick:
            mytimer.Interval = (3000); // 1 secs
            mytimer.Tick += new EventHandler(timer_Tick);

            //Deaktiviere alle Eingaben, bevor nicht ein Eintrag aus der Dropbox für "Timer" gewählt wurde...
            BlockEditing();
        }

        //Methode zum refreshen über den Timer-Tick
        private void timer_Tick(object sender, EventArgs e)
        {
            lblStatusWert.Text = "wartend...";
            mytimer.Stop();
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
            btnSaveChange.Enabled = false;
            btnSaveNew.Enabled = false;
            dgvTimerTimes.Enabled = false;
            dtpDateEnd.Enabled = false;
            dtpDate.Enabled = false;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
        }

        public void EnableEditing()
        {
            btnDeleteSelection.Enabled = true;
            btnSaveChange.Enabled = true;
            btnSaveNew.Enabled = true;
            dgvTimerTimes.Enabled = true;
            dtpDateEnd.Enabled = true;
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

        //Datagridview befüllen - nur auf Basis des Datums
        private void LoadTimerTimes(string timername, DateTime starttime, DateTime endtime)
        {
            //Datetimes übersetzen: starttime --> mit Uhrzeit 00:00:00, endtime mit Uhrzeit 23:59:59
            TimeSpan ts = new TimeSpan(00, 00, 00);
            starttime = starttime.Date + ts;
            ts = new TimeSpan(23, 59, 59);
            endtime = endtime.Date + ts;

            sqladapter dbaccess = new sqladapter();
            dgvTimerTimes.DataSource = dbaccess.GetTimerData(timername, starttime, endtime);
        }

        //Update Start/Ende nach Klick auf Eintrag
        private void dgvTimerTimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpStartDateSave.Value = DateTime.Parse(dgvTimerTimes.CurrentRow.Cells[0].Value.ToString());
            dtpStart.Value = DateTime.Parse(dgvTimerTimes.CurrentRow.Cells[1].Value.ToString());
            dtpEndDateSave.Value = DateTime.Parse(dgvTimerTimes.CurrentRow.Cells[2].Value.ToString());
            dtpEnd.Value = DateTime.Parse(dgvTimerTimes.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnDeleteSelection_Click(object sender, EventArgs e)
        {
            if (dgvTimerTimes.RowCount > 0)
            {
                sqladapter dbaccess = new sqladapter();
                dbaccess.deletetime(dgvTimerTimes.CurrentRow.Cells[5].Value.ToString());
                LoadTimerTimes(cbTimerSelection.SelectedItem.ToString(), dtpDate.Value, dtpDateEnd.Value);
                if (dgvTimerTimes.RowCount > 0)
                {
                    dtpStart.Value = DateTime.Parse(dgvTimerTimes.Rows[0].Cells[1].Value.ToString());
                    dtpEnd.Value = DateTime.Parse(dgvTimerTimes.Rows[0].Cells[3].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Es wurde nichts zum Ändern ausgewählt, duh!", "Info an den Dödel", MessageBoxButtons.OK);
            }
            
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (dgvTimerTimes.RowCount > 0)
            {
                sqladapter dbaccess = new sqladapter();
                bool choice = dbaccess.CheckExistingTime(dtpStartDateSave.Value, dtpStart.Value, dtpEndDateSave.Value, dtpEnd.Value);
                if (choice == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Eintrag bereits für einen Single-Timer vorhanden! Trotzdem speichern?", "Hinweis", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // TODO - Unsinnige Eingaben (Dauer = 0, negative Dauern) abfangen
                        dbaccess.edittime(cbTimerSelection.SelectedItem.ToString(), dtpStartDateSave.Value, dtpStartDateSave.Value, dtpEndDateSave.Value, dtpEndDateSave.Value, dgvTimerTimes.CurrentRow.Cells[5].Value.ToString());
                        lblStatusWert.Text = "Neuer Eintrag wurde gespeichert!";
                        mytimer.Start();
                        LoadTimerTimes(cbTimerSelection.SelectedItem.ToString(), dtpDate.Value, dtpDateEnd.Value);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //break
                    }
                }
                else
                {
                    dbaccess.edittime(cbTimerSelection.SelectedItem.ToString(), dtpStartDateSave.Value, dtpStart.Value, dtpEndDateSave.Value, dtpEnd.Value, dgvTimerTimes.CurrentRow.Cells[5].Value.ToString());
                    lblStatusWert.Text = "Neuer Eintrag wurde gespeichert!";
                    mytimer.Start();
                    LoadTimerTimes(cbTimerSelection.SelectedItem.ToString(), dtpDate.Value, dtpDateEnd.Value);
                }
            } else
            {
                MessageBox.Show("Es wurde nichts zum Ändern ausgewählt, duh!", "Info an den Dödel", MessageBoxButtons.OK);
            }
        }


        //Dient nur dazu, eine spezfische Spalte beim Zuweisen des DataTables zum Datagridview auszublenden
        private void dgvTimerTimes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvTimerTimes.Columns["TimesID"].Visible = false;

        }

        private void btnLoadTimes_Click(object sender, EventArgs e)
        {
            if (cbTimerSelection.SelectedItem != null) {
                LoadTimerTimes(cbTimerSelection.SelectedItem.ToString(), dtpDate.Value, dtpDateEnd.Value);
            } else
            {
                //do nothing
            }
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}
