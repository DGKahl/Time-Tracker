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
    public partial class Settings : Form
    {
        //EVENT UND DELEGATE - Um die gespeicherten Änderungen in der main-Form direkt zu aktualisieren
        public event Formhandler ChangesAreSaved;
        public delegate void Formhandler(Settings f, EventArgs e);

        private void settings_saved(object sender, EventArgs e)
        {
            ChangesAreSaved(this, e);
        }

        public Settings()
        {
            InitializeComponent();
            FillQuickslotcb();
            SetQuickslots();
        }

        void FillQuickslotcb()
        {
            sqladapter adapter = new sqladapter();
            List<string> list = adapter.GetAllTimers();

            foreach (string t in list) {
                cbSlot1.Items.Add(t);
                cbSlot2.Items.Add(t);
                cbSlot3.Items.Add(t);
            }
        }

        void SetQuickslots()
        {
            sqladapter dbaccess = new sqladapter();
            List<string> qs_items = dbaccess.GetQuickslots();

            cbSlot1.SelectedItem = qs_items[0];
            cbSlot2.SelectedItem = qs_items[1];
            cbSlot3.SelectedItem = qs_items[2];
        }

        //Quickslots neu zuweisen (dazu die ausgewählten Elemente je Combobox als string mitgeben)
        private void btnSlotsOK_Click(object sender, EventArgs e)
        {
            //Eingabe prüfen -> Keine Doppelbelegung der Quickslots!
            if (cbSlot1.SelectedItem == cbSlot2.SelectedItem || cbSlot1.SelectedItem == cbSlot3.SelectedItem || cbSlot2.SelectedItem == cbSlot3.SelectedItem)
            {
                MessageBox.Show("Doppelte Belegung der Quickslots nicht erlaubt.", "Warnung", MessageBoxButtons.OK);
            }
            else
            {
                sqladapter dbaccess = new sqladapter();
                dbaccess.UpdateQuickslots(cbSlot1.SelectedItem.ToString(), cbSlot2.SelectedItem.ToString(), cbSlot3.SelectedItem.ToString());
                ChangesAreSaved(this, e);
            }
        }
    }
}
