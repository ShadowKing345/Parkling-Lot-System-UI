using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ParkingSystem
{
    class SaveAndLoad
    {
        /// <summary>
        /// Saves the content of the list of nodes in the Main class in a json format.
        /// </summary>
        /// <param name="dir">the directory and file name</param>
        public static void Save(String dir)
        {
            string data = "{ \"nodes\":[";
            foreach (Node n in Program.nodes)
            {
                data += n.ToString;
            }
            data += "]}";
            File.WriteAllText(dir, data);

            MessageBox.Show("File has been saved.", "Done");
        }

        /// <summary>
        /// Loads a file and adds the nodes, slots and parking spots to the list in the Main class and configures the tree view in MainForm.
        /// </summary>
        /// <param name="dir">The directory and file name</param>
        public static void Load(String dir)
        {
            MainForm form = Program.form;
            string data = File.ReadAllText(dir);

            if (Program.nodes.Count != 0 && form.treeView1.Nodes.Count != 0)
                if (MessageBox.Show("Are you sure you want to clear everything?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            else form.ClearAll(true);

            try
            {
                var json = JsonConvert.DeserializeObject<dynamic>(data);
                var nodes = json.nodes;
                for (int i = 0; i < nodes.Count; i++)
                {
                    TreeNode node;
                    Program.nodes.Add(new Node(nodes[i].name.ToString(), nodes[i].uuid.ToString()));
                    if (nodes[i].name.ToString() == "")
                        node = new TreeNode(Program.nodes.Count.ToString());
                    else
                        node = new TreeNode(nodes[i].name.ToString());
                    form.treeView1.Nodes.Add(node);
                    int indexOfNode = form.treeView1.Nodes.IndexOf(node);
                    form.treeView1.Nodes[indexOfNode].Nodes.Add("Name: " + nodes[i].name.ToString());
                    form.treeView1.Nodes[indexOfNode].Nodes.Add("UUID: " + nodes[i].uuid.ToString());

                    var slots = nodes[i].slots;
                    for (int j = 0; j < slots.Count; j++)
                    {

                        TreeNode slot;
                        Program.nodes[i].GetSlots.Add(new Slot(slots[j].name.ToString(), slots[j].uuid.ToString()));
                        if (slots[j].name.ToString() == "")
                            slot = new TreeNode(Program.nodes[i].GetSlots.Count.ToString());
                        else
                            slot = new TreeNode(slots[j].name.ToString());
                        form.treeView1.Nodes[indexOfNode].Nodes.Add(slot);
                        int indexOfSlot = form.treeView1.Nodes[indexOfNode].Nodes.IndexOf(slot);
                        form.treeView1.Nodes[indexOfNode].Nodes[indexOfSlot].Nodes.Add("Name: " + slots[j].name.ToString());
                        form.treeView1.Nodes[indexOfNode].Nodes[indexOfSlot].Nodes.Add("UUID: " + slots[j].uuid.ToString());

                        var parkingSpots = slots[j].parkingspots;
                        for (int k = 0; k < parkingSpots.Count; k++)
                        {

                            TreeNode spot;
                            Program.nodes[i].GetSlots[j].GetParkingSpots.Add(new ParkingSpot(parkingSpots[k].name.ToString(), parkingSpots[k].uuid.ToString(), (bool)parkingSpots[k].occupied));
                            if (parkingSpots[k].name.ToString() == "")
                                spot = new TreeNode(Program.nodes[i].GetSlots[j].GetParkingSpots.Count.ToString());
                            else
                                spot = new TreeNode(parkingSpots[k].name.ToString());
                            form.treeView1.Nodes[indexOfNode].Nodes[indexOfSlot].Nodes.Add(spot);
                            int indexOfSpot = form.treeView1.Nodes[indexOfNode].Nodes[indexOfSlot].Nodes.IndexOf(spot);
                            form.treeView1.Nodes[indexOfNode].Nodes[indexOfSlot].Nodes[indexOfSpot].Nodes.Add("Name: " + parkingSpots[k].name.ToString());
                            form.treeView1.Nodes[indexOfNode].Nodes[indexOfSlot].Nodes[indexOfSpot].Nodes.Add("UUID: " + parkingSpots[k].uuid.ToString());
                            form.treeView1.Nodes[indexOfNode].Nodes[indexOfSlot].Nodes[indexOfSpot].Nodes.Add("isOccupied: " + parkingSpots[k].occupied.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                form.treeView1.Nodes.Add(new TreeNode("We have an issue: " + ex.ToString()));
            }

            MessageBox.Show("File has been loaded.", "Done");
        }
    }
}
