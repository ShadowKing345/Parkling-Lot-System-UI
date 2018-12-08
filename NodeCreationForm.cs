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
    public partial class NodeCreationForm : Form
    {
        public String NodeName { get; set; }

        public NodeCreationForm()
        {
            InitializeComponent();
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
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            NodeName = this.NameTextBox.Text;
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
