using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingSystem;

namespace ParkingSystem
{
    static class Program
    {
        public static List<Node> nodes = new List<Node>();
        public static MainForm form;
        public static System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Thread));
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            thread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new MainForm();
            Application.Run(form);
        }

        /// <summary>
        /// Thread class that counts how many parking spots there are in total, the number occupied and the number free.
        /// </summary>
        private static void Thread()
        {
            while (true)
            {
                try
                {
                    form.tParkingSpotsNo = 0;
                    form.oParkingSpotsNo = 0;
                    form.fParkingSpotsNo = 0;
                    foreach (Node n in nodes)
                    { 
                        foreach (Slot s in n.GetSlots)
                        {
                            foreach (ParkingSpot p in s.GetParkingSpots)
                            {
                                form.tParkingSpotsNo++;
                                if (p.IsOccupied)
                                    form.oParkingSpotsNo++;
                                else
                                    form.fParkingSpotsNo++;
                            }
                        }
                    }
                    form.Updater();
                }
                catch (Exception) { }
            }
        }
    }
}
