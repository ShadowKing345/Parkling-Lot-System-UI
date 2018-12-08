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
    public partial class ParkingSpotCreationForm : Form
    {
        public String SpotName { get; set; }
        public int NodeIndex { get; set; }
        public int SlotIndex { get; set; }
        public bool IsOccupied { get; set; }

        public ParkingSpotCreationForm()
        {
            foreach (Node n in Program.nodes)
            {
                slotCount += n.GetSlots.Count;
            }
            InitializeComponent();
            this.atSlotIndex.Maximum = slotCount;
            if (Display.IsDarkMode)
            {
                this.BackColor = Display.BGColor_Dark;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is Label)
                        this.Controls[i].ForeColor = Display.TextColor_Dark;

                    if (this.Controls[i] is Button)
                    {
                        ((Button)this.Controls[i]).FlatStyle = FlatStyle.Flat;
                        ((Button)this.Controls[i]).BackColor = Display.ComponentBGColor_Dark;
                        ((Button)this.Controls[i]).FlatAppearance.BorderSize = 2;
                        ((Button)this.Controls[i]).FlatAppearance.BorderColor = Display.ComponentBorderColor_Dark;
                        ((Button)this.Controls[i]).ForeColor = Display.TextColor_Dark;
                    }

                    if (this.Controls[i] is TextBox)
                    {
                        ((TextBox)this.Controls[i]).BackColor = Display.InnerPanelBGColor_Dark;
                        ((TextBox)this.Controls[i]).ForeColor = Display.TextColor_Dark;
                        ((TextBox)this.Controls[i]).BorderStyle = BorderStyle.None;
                    }

                    if (this.Controls[i] is NumericUpDown)
                    {
                        ((NumericUpDown)this.Controls[i]).BackColor = Display.InnerPanelBGColor_Dark;
                        ((NumericUpDown)this.Controls[i]).ForeColor = Display.TextColor_Dark;
                        ((NumericUpDown)this.Controls[i]).BorderStyle = BorderStyle.None;
                    }
                }
                this.isOccupiedCheckBox.ForeColor = Display.TextColor_Dark;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SpotName = this.NameTextBox.Text;
            NodeIndex = (int)this.atNodeIndex.Value - 1;
            SlotIndex = (int)this.atSlotIndex.Value - 1;
            IsOccupied = this.isOccupiedCheckBox.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                if (this.NameTextBox.Text == "")
                    return;
                ConfirmButton_Click(sender, e);
            }
        }
    }
}
