using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ParkingSystem
{ 
    class Display
    {
        public static bool IsDarkMode { get; set; } = false;

        public static Color TextColor_Dark = Color.FromArgb(230, 230, 230);
        public static Color BGColor_Dark = Color.FromArgb(30, 30, 30);
        public static Color InnerPanelBGColor_Dark = Color.FromArgb(50, 50, 50);
        public static Color ComponentBGColor_Dark = Color.FromArgb(40, 40, 40);
        public static Color ComponentBorderColor_Dark = Color.FromArgb(25, 25, 25);

        public static Color TextColor_Light = SystemColors.WindowText;
        public static Color BGColor_Light = SystemColors.Control;
        public static Color InnerPanelBGColor_Light = SystemColors.Control;
        public static Color ComponentBGColor_Light = SystemColors.Control;
        public static Color ComponentBorderColor_Light = SystemColors.Control;

        public static void DarkMode()
        {
            MainForm form = Program.form;

            form.BackColor = BGColor_Dark;

            form.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new DarkToolStripRenderer());
            for (int i = 0; i < form.menuStrip1.Items.Count; i++)
            {
                ToolStripMenuItem m = (ToolStripMenuItem) form.menuStrip1.Items[i];
                m.ForeColor = TextColor_Dark;
                for (int j = 0; j < m.DropDownItems.Count; j++)
                {
                    if (m.DropDownItems[j] is ToolStripSeparator)
                        continue;
                    ToolStripMenuItem s = (ToolStripMenuItem) m.DropDownItems[j];
                    s.ForeColor = TextColor_Dark;
                    for (int k = 0; k < s.DropDownItems.Count; k++)
                    {
                        if (s.DropDownItems[k] is ToolStripSeparator)
                            continue;
                        ToolStripMenuItem d = (ToolStripMenuItem)s.DropDownItems[k];
                        d.ForeColor = TextColor_Dark;
                    }
                }
            }

            form.ContentPanel.BackColor = BGColor_Dark;

            form.parkingStats.BackColor = InnerPanelBGColor_Dark;
            for (int i = 0; i < form.parkingStats.Controls.Count; i++)
            {
                Control control = form.parkingStats.Controls[i];
                if (control is Label)
                    control.ForeColor = TextColor_Dark;

                if (control is TextBox)
                {
                    control.ForeColor = TextColor_Dark;
                    control.BackColor = ComponentBGColor_Dark;
                }
            }

            form.TreeViewPanel.BackColor = InnerPanelBGColor_Dark;
            form.treeView1.BackColor = InnerPanelBGColor_Dark;
            form.treeView1.ForeColor = TextColor_Dark;

            form.buttonControlsPannel.BackColor = InnerPanelBGColor_Dark;
            foreach (Button b in form.buttonControlsPannel.Controls)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = ComponentBGColor_Dark;
                b.FlatAppearance.BorderSize = 2;
                b.FlatAppearance.BorderColor = ComponentBorderColor_Dark;
                b.ForeColor = TextColor_Dark;
            }
            IsDarkMode = true;
        }

        public static void LightMode()
        {
            MainForm form = Program.form;

            form.BackColor = BGColor_Light;

            form.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new LightToolStripRenderer());
            for (int i = 0; i < form.menuStrip1.Items.Count; i++)
            {
                ToolStripMenuItem m = (ToolStripMenuItem)form.menuStrip1.Items[i];
                m.ForeColor = TextColor_Light;
                for (int j = 0; j < m.DropDownItems.Count; j++)
                {
                    if (m.DropDownItems[j] is ToolStripSeparator)
                        continue;
                    ToolStripMenuItem s = (ToolStripMenuItem)m.DropDownItems[j];
                    s.ForeColor = TextColor_Light;
                    for (int k = 0; k < s.DropDownItems.Count; k++)
                    {
                        if (s.DropDownItems[k] is ToolStripSeparator)
                            continue;
                        ToolStripMenuItem d = (ToolStripMenuItem)s.DropDownItems[k];
                        d.ForeColor = TextColor_Light;
                    }
                }
            }

            form.ContentPanel.BackColor = BGColor_Light;

            form.parkingStats.BackColor = InnerPanelBGColor_Light;
            for (int i = 0; i < form.parkingStats.Controls.Count; i++)
            {
                Control control = form.parkingStats.Controls[i];
                if (control is Label)
                    control.ForeColor = TextColor_Light;

                if (control is TextBox)
                {
                    control.ForeColor = TextColor_Light;
                    control.BackColor = ComponentBGColor_Light;
                }
            }

            form.TreeViewPanel.BackColor = InnerPanelBGColor_Light;
            form.treeView1.BackColor = InnerPanelBGColor_Light;
            form.treeView1.ForeColor = TextColor_Light;

            form.buttonControlsPannel.BackColor = InnerPanelBGColor_Light;
            foreach (Button b in form.buttonControlsPannel.Controls)
            {
                b.FlatStyle = default(FlatStyle);
                b.BackColor = Color.FromArgb(225,225,225);
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
                b.ForeColor = TextColor_Light;
            }
            IsDarkMode = false;
        }
    }

    public class DarkToolStripRenderer : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground => Display.InnerPanelBGColor_Dark ;

        public override Color ImageMarginGradientBegin => Display.InnerPanelBGColor_Dark;

        public override Color ImageMarginGradientMiddle => Display.InnerPanelBGColor_Dark;

        public override Color ImageMarginGradientEnd => Display.InnerPanelBGColor_Dark;

        public override Color MenuBorder => Color.Black;

        public override Color MenuItemBorder => Color.Black;

        public override Color MenuItemSelected => Display.ComponentBGColor_Dark;

        public override Color MenuStripGradientBegin => Display.InnerPanelBGColor_Dark;

        public override Color MenuStripGradientEnd => Color.DarkBlue;
  
        public override Color MenuItemSelectedGradientBegin => Display.ComponentBGColor_Dark;

        public override Color MenuItemSelectedGradientEnd => Display.ComponentBGColor_Dark;

        public override Color MenuItemPressedGradientBegin => Display.ComponentBGColor_Dark;

        public override Color MenuItemPressedGradientEnd => Display.ComponentBGColor_Dark;

        public override Color CheckBackground => Display.ComponentBGColor_Dark;
    }

    public class LightToolStripRenderer : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground => Display.InnerPanelBGColor_Light;

        public override Color ImageMarginGradientBegin => Display.InnerPanelBGColor_Light;

        public override Color ImageMarginGradientMiddle => Display.InnerPanelBGColor_Light;

        public override Color ImageMarginGradientEnd => Display.InnerPanelBGColor_Light;

        public override Color MenuBorder => Color.Black;

        public override Color MenuItemBorder => Color.Black;

        public override Color MenuItemSelected => Display.ComponentBGColor_Light;

        public override Color MenuStripGradientBegin => Color.FromArgb(230,230,230);

        public override Color MenuStripGradientEnd => Color.FromArgb(230,230,230);

        public override Color MenuItemSelectedGradientBegin => Display.ComponentBGColor_Light;

        public override Color MenuItemSelectedGradientEnd => Display.ComponentBGColor_Light;

        public override Color MenuItemPressedGradientBegin => Display.ComponentBGColor_Light;

        public override Color MenuItemPressedGradientEnd => Display.ComponentBGColor_Light;

        public override Color CheckBackground => Display.ComponentBGColor_Light;
    }
}
