using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    class CheatersClass
    {
        private static Random random = new Random();
        public static bool IsDevEnabled { get; set; }

        /// <summary>
        /// Will Randamize the state of all parking spots.
        /// </summary>
        public static void Randamize()
        {
            for (int n = 0; n < Program.nodes.Count; n++)
                for (int s = 0; s < Program.nodes[n].GetSlots.Count; s++)
                    for (int p = 0; p < Program.nodes[n].GetSlots[s].GetParkingSpots.Count; p++)
                        if (random.Next(1, 101) >= 50)
                        {
                            Program.nodes[n].GetSlots[s].GetParkingSpots[p].SetOccupied(false);
                            Program.form.treeView1.Nodes[n].Nodes[s + 2].Nodes[p + 2].Nodes[2].Text = "isOccupied: " + false.ToString();
                        }
                        else
                        {
                            Program.nodes[n].GetSlots[s].GetParkingSpots[p].SetOccupied(true);
                            Program.form.treeView1.Nodes[n].Nodes[s + 2].Nodes[p + 2].Nodes[2].Text = "isOccupied: " + true.ToString();
                        }
        }
    }
}
