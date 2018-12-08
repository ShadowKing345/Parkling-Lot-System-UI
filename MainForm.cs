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
using Newtonsoft.Json;

namespace ParkingSystem
{
    public partial class MainForm : Form
    {
        public int tParkingSpotsNo = 0;
        public int oParkingSpotsNo = 0;
        public int fParkingSpotsNo = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Kill Switches

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        #endregion

        #region Adding/Removeing Nodes, Slots, Parking Spots

        /// <summary>
        /// Event fired on button click, will create a parking spot add it to a list of inside the main class with a given node index and slot index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddParkingSpot_Click(object sender, EventArgs e)
        {
            if (Program.nodes.Count <= 0)
            {
                MessageBox.Show("Please create a node before you create a slot.", "Error");
                return;
            }
            else if (Program.nodes[0].GetSlots.Count <= 0)
            {
                MessageBox.Show("Please create a slot before you create a slot.", "Error");
                return;
            }


            using (var form = new ParkingSpotCreationForm())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String name = form.SpotName;
                    int nodeIndex = form.NodeIndex;
                    int slotIndex = form.SlotIndex;
                    bool isOccupied = form.IsOccupied;

                    TreeNode treeNode;
                    ParkingSystem.ParkingSpot spot = new ParkingSystem.ParkingSpot(name, isOccupied);

                    Program.nodes[nodeIndex].GetSlots[slotIndex].GetParkingSpots.Add(spot);
                    if (name != "")
                        treeNode = new TreeNode(name);
                    else
                        treeNode = new TreeNode(Program.nodes[nodeIndex].GetSlots[slotIndex].GetParkingSpots.Count.ToString());
                    this.treeView1.Nodes[nodeIndex].Nodes[slotIndex + 2].Nodes.Add(treeNode);
                    this.treeView1.Nodes[nodeIndex].Nodes[slotIndex + 2].Nodes[this.treeView1.Nodes[nodeIndex].Nodes[slotIndex + 2].Nodes.IndexOf(treeNode)].Nodes.Add("Name: " + name);
                    this.treeView1.Nodes[nodeIndex].Nodes[slotIndex + 2].Nodes[this.treeView1.Nodes[nodeIndex].Nodes[slotIndex + 2].Nodes.IndexOf(treeNode)].Nodes.Add("UUID: " + spot.GetUUID);
                    this.treeView1.Nodes[nodeIndex].Nodes[slotIndex + 2].Nodes[this.treeView1.Nodes[nodeIndex].Nodes[slotIndex + 2].Nodes.IndexOf(treeNode)].Nodes.Add("Is Occupied: " + spot.IsOccupied);
                }
            }
        }

        /// <summary>
        /// Event fired on button click, will create a node add it to a list of inside the main class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNode_Click(object sender, EventArgs e)
        {
            using (var form = new NodeCreationForm())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String name = form.NodeName;
                    ParkingSystem.Node node = new ParkingSystem.Node(name);
                    TreeNode treeNode;
                    Program.nodes.Add(node);
                    if (name != "")
                        treeNode = new TreeNode(name);
                    else
                        treeNode = new TreeNode(Program.nodes.Count.ToString());
                    this.treeView1.Nodes.Add(treeNode);
                    this.treeView1.Nodes[this.treeView1.Nodes.IndexOf(treeNode)].Nodes.Add("Name: " + name);
                    this.treeView1.Nodes[this.treeView1.Nodes.IndexOf(treeNode)].Nodes.Add("UUID: " + node.GetUUID);
                }
            }
        }

        /// <summary>
        /// Event fired on button click, will create a slot add it to a list of inside the main class with a given node index .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSlot_Click(object sender, EventArgs e)
        {
            if (Program.nodes.Count <= 0)
            {
                MessageBox.Show("Please create a node before you create a slot.", "Error");
                return;
            }

            using (var form = new SlotCreationForm())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String name = form.SlotName;
                    int index = form.Index;

                    TreeNode treeNode;
                    ParkingSystem.Slot slot = new ParkingSystem.Slot(name);

                    Program.nodes[index].GetSlots.Add(new ParkingSystem.Slot(name));
                    if (name != "")
                        treeNode = new TreeNode(name);
                    else
                        treeNode = new TreeNode(Program.nodes[index].GetSlots.Count.ToString());
                    this.treeView1.Nodes[index].Nodes.Add(treeNode);
                    this.treeView1.Nodes[index].Nodes[this.treeView1.Nodes[index].Nodes.IndexOf(treeNode)].Nodes.Add("Name: " + name);
                    this.treeView1.Nodes[index].Nodes[this.treeView1.Nodes[index].Nodes.IndexOf(treeNode)].Nodes.Add("UUID: " + slot.GetUUID);
                }
            }
        }

        /// <summary>
        /// Event fired when the removeItemButton is clicked on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            Remove();
        }

        #endregion

        #region Save and Load

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Load();
        }
       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load();
        }

        #endregion

        #region Functions with multiple uses.

        /// <summary>
        /// Opens the save dialog box and calls the Save function in SaveAndLoad class
        /// </summary>
        private void Save()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveAndLoad.Save(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Opens the open dialog box and calls the Load function in SaveAndLoad class
        /// </summary>
        private new void Load()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveAndLoad.Load(openFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Called to kill any threads and closes the form.
        /// </summary>
        private void Exit()
        {
            try
            {
                Program.thread.Abort();
#pragma warning disable CS0168 // Variable is declared but never used
            }
            catch (System.Threading.ThreadAbortException ex) { }
#pragma warning restore CS0168 // Variable is declared but never used
            this.Close();
        }


        /// <summary>
        /// Function that will update the textboxes in parking stats panel.
        /// </summary>
        public void Updater()
        {
            if (this.tParkingSpotsTextBox.InvokeRequired)
                this.tParkingSpotsTextBox.Invoke((MethodInvoker)delegate ()
                {
                    this.tParkingSpotsTextBox.Text = tParkingSpotsNo.ToString();
                });
            if (this.oParkingSpotsTextBox.InvokeRequired)
                this.oParkingSpotsTextBox.Invoke((MethodInvoker)delegate ()
                {
                    this.oParkingSpotsTextBox.Text = oParkingSpotsNo.ToString();
                });
            if (this.fParkingSpotsTextBox.InvokeRequired)
                this.fParkingSpotsTextBox.Invoke((MethodInvoker)delegate ()
                {
                    this.fParkingSpotsTextBox.Text = fParkingSpotsNo.ToString();
                });
        }

        /// <summary>
        /// Removes the selected item(s).
        /// </summary>
        public void Remove()
        {
            if (Program.nodes.Count <= 0)
                return;
            using (var form = new RemovealForm())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int nodeIndex = RemovealForm.NodeIndexNumber;
                    int slotIndex = RemovealForm.SlotIndexNumber;
                    int spotIndex = RemovealForm.SpotIndexNumber;
                    try
                    {
                        if (nodeIndex == 0)
                        {
                            Program.nodes.Clear();
                            this.treeView1.Nodes.Clear();
                        }
                        else
                        {
                            if (slotIndex == 0)
                            {
                                Program.nodes[nodeIndex - 1].GetSlots.Clear();
                                while (this.treeView1.Nodes[nodeIndex - 1].Nodes.Count > 2)
                                    this.treeView1.Nodes[nodeIndex - 1].Nodes.RemoveAt(2);
                            }
                            else
                            {
                                if (spotIndex == 0)
                                {
                                    Program.nodes[nodeIndex - 1].GetSlots[slotIndex - 1 + 2].GetParkingSpots.Clear();
                                    while (this.treeView1.Nodes[nodeIndex - 1].Nodes[slotIndex - 1 + 2].Nodes.Count > 2)
                                        this.treeView1.Nodes[nodeIndex - 1].Nodes[slotIndex - 1 + 2].Nodes.RemoveAt(2);
                                }
                                else
                                {
                                    Program.nodes[nodeIndex - 1].GetSlots[slotIndex - 1].GetParkingSpots.RemoveAt(spotIndex - 1);
                                    this.treeView1.Nodes[nodeIndex - 1].Nodes[slotIndex - 1 + 2].Nodes.RemoveAt(spotIndex - 1 + 2);
                                }
                            }
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Error out of bounds exceptions", "Error");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Clears the tree view and the list of nodes in the main class.
        /// </summary>
        /// <param name="overideQuestion">pass true to ignore the question asked before clearing.</param>
        public void ClearAll(bool overideQuestion)
        {
            if (Program.nodes.Count <= 0)
                return;
            if (!overideQuestion)
                if (MessageBox.Show("Are you sure you want to clear everything?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    return;
            Program.nodes.Clear();
            this.treeView1.Nodes.Clear();
            if (!overideQuestion)
                MessageBox.Show("The board has been cleared.", "Done");
        }

        #endregion

        #region Edditing

        /// <summary>
        /// Event fired when tool strip item is clicked. Calls the ClearAll function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll(false);
        }

        /// <summary>
        /// Event fired when the tool strip item is clicked. Calls Remove.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        #region Dev Mode

        private void EnableDevModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (enableDevModeToolStripMenuItem.Checked == false)
                {
                    CheatersClass.IsDevEnabled = true;
                    enableDevModeToolStripMenuItem.Checked = true;
                }
                else
                {
                    CheatersClass.IsDevEnabled = true;
                    enableDevModeToolStripMenuItem.Checked = true;
                }
            }
            catch (Exception) { }
        }

        private void RandamizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheatersClass.IsDevEnabled)
                    CheatersClass.Randamize();
            }
            catch (Exception) { }
        }

        #endregion

        #endregion

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.darkToolStripMenuItem.Checked == false)
            {
                this.darkToolStripMenuItem.Checked = true;
                Display.DarkMode();
            }
            else
            {
                this.darkToolStripMenuItem.Checked = false;
                Display.LightMode();
            }
        }
    }
}
