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
            sqladapter dbaccess = new sqladapter();
            dbaccess.UpdateQuickslots(cbSlot1.SelectedItem.ToString(), cbSlot2.SelectedItem.ToString(), cbSlot3.SelectedItem.ToString());
        }
    }
}
