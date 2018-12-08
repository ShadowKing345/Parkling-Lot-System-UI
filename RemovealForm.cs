using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class RemovealForm : Form
    {
        public static int NodeIndexNumber { get; set; }
        public static int SlotIndexNumber { get; set; }
        public static int SpotIndexNumber { get; set; }

        public RemovealForm()
        { 
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure you wish to remove the selected items? They cannot be recovered.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                NodeIndexNumber = (int)this.nodeIndexUpDown.Value;
                SlotIndexNumber = (int)this.slotIndexUpDown.Value;
                SpotIndexNumber = (int)this.parkingSlotUpDown.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nodeIndexUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.slotIndexUpDown.Maximum = Program.nodes[(int)nodeIndexUpDown.Value - 1].GetSlots.Count;
            }
            catch (ArgumentOutOfRangeException)
            {
                this.slotIndexUpDown.Maximum = 0;
            }
        }

        private void slotIndexUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.parkingSlotUpDown.Maximum = Program.nodes[(int)nodeIndexUpDown.Value - 1].GetSlots[(int)slotIndexUpDown.Value - 1].GetParkingSpots.Count ;
            }
            catch (ArgumentOutOfRangeException)
            {
                this.parkingSlotUpDown.Maximum = 0;
            }
        }
    }
}
