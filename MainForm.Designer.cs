namespace ParkingSystem
{
    partial class MainForm
    {
        /// <summary>                       
        /// Required designer variable.     
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.TreeViewPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonControlsPannel = new System.Windows.Forms.Panel();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addNode = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addSlot = new System.Windows.Forms.Button();
            this.addParkingSpot = new System.Windows.Forms.Button();
            this.parkingStats = new System.Windows.Forms.Panel();
            this.fParkingSpotsTextBox = new System.Windows.Forms.TextBox();
            this.oParkingSpotsTextBox = new System.Windows.Forms.TextBox();
            this.tParkingSpotsTextBox = new System.Windows.Forms.TextBox();
            this.fParkingSpots = new System.Windows.Forms.Label();
            this.oParkingSpots = new System.Windows.Forms.Label();
            this.tParkingSpots = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDevModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randamizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ContentPanel.SuspendLayout();
            this.TreeViewPanel.SuspendLayout();
            this.buttonControlsPannel.SuspendLayout();
            this.parkingStats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.TreeViewPanel);
            this.ContentPanel.Controls.Add(this.buttonControlsPannel);
            this.ContentPanel.Controls.Add(this.parkingStats);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 28);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(722, 431);
            this.ContentPanel.TabIndex = 0;
            // 
            // TreeViewPanel
            // 
            this.TreeViewPanel.Controls.Add(this.treeView1);
            this.TreeViewPanel.Location = new System.Drawing.Point(278, 12);
            this.TreeViewPanel.Name = "TreeViewPanel";
            this.TreeViewPanel.Size = new System.Drawing.Size(432, 407);
            this.TreeViewPanel.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(432, 407);
            this.treeView1.TabIndex = 0;
            // 
            // buttonControlsPannel
            // 
            this.buttonControlsPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonControlsPannel.Controls.Add(this.removeItemButton);
            this.buttonControlsPannel.Controls.Add(this.loadButton);
            this.buttonControlsPannel.Controls.Add(this.saveButton);
            this.buttonControlsPannel.Controls.Add(this.addNode);
            this.buttonControlsPannel.Controls.Add(this.exitButton);
            this.buttonControlsPannel.Controls.Add(this.addSlot);
            this.buttonControlsPannel.Controls.Add(this.addParkingSpot);
            this.buttonControlsPannel.Location = new System.Drawing.Point(13, 109);
            this.buttonControlsPannel.Name = "buttonControlsPannel";
            this.buttonControlsPannel.Size = new System.Drawing.Size(258, 310);
            this.buttonControlsPannel.TabIndex = 1;
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.removeItemButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemButton.Location = new System.Drawing.Point(5, 166);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(246, 49);
            this.removeItemButton.TabIndex = 6;
            this.removeItemButton.Text = "Remove";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Location = new System.Drawing.Point(4, 220);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(126, 40);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(136, 220);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 40);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addNode
            // 
            this.addNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.addNode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.addNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNode.Location = new System.Drawing.Point(4, 112);
            this.addNode.Name = "addNode";
            this.addNode.Size = new System.Drawing.Size(246, 49);
            this.addNode.TabIndex = 3;
            this.addNode.Text = "Add Node";
            this.addNode.UseVisualStyleBackColor = false;
            this.addNode.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(4, 265);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(246, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // addSlot
            // 
            this.addSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.addSlot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.addSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSlot.Location = new System.Drawing.Point(4, 58);
            this.addSlot.Name = "addSlot";
            this.addSlot.Size = new System.Drawing.Size(246, 49);
            this.addSlot.TabIndex = 1;
            this.addSlot.Text = "Add Slot";
            this.addSlot.UseVisualStyleBackColor = false;
            this.addSlot.Click += new System.EventHandler(this.AddSlot_Click);
            // 
            // addParkingSpot
            // 
            this.addParkingSpot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.addParkingSpot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.addParkingSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addParkingSpot.Location = new System.Drawing.Point(4, 4);
            this.addParkingSpot.Name = "addParkingSpot";
            this.addParkingSpot.Size = new System.Drawing.Size(247, 49);
            this.addParkingSpot.TabIndex = 0;
            this.addParkingSpot.Text = "Add Parking Spot";
            this.addParkingSpot.UseVisualStyleBackColor = false;
            this.addParkingSpot.Click += new System.EventHandler(this.AddParkingSpot_Click);
            // 
            // parkingStats
            // 
            this.parkingStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parkingStats.Controls.Add(this.fParkingSpotsTextBox);
            this.parkingStats.Controls.Add(this.oParkingSpotsTextBox);
            this.parkingStats.Controls.Add(this.tParkingSpotsTextBox);
            this.parkingStats.Controls.Add(this.fParkingSpots);
            this.parkingStats.Controls.Add(this.oParkingSpots);
            this.parkingStats.Controls.Add(this.tParkingSpots);
            this.parkingStats.Location = new System.Drawing.Point(12, 12);
            this.parkingStats.Name = "parkingStats";
            this.parkingStats.Size = new System.Drawing.Size(259, 90);
            this.parkingStats.TabIndex = 0;
            // 
            // fParkingSpotsTextBox
            // 
            this.fParkingSpotsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fParkingSpotsTextBox.Location = new System.Drawing.Point(173, 58);
            this.fParkingSpotsTextBox.Name = "fParkingSpotsTextBox";
            this.fParkingSpotsTextBox.ReadOnly = true;
            this.fParkingSpotsTextBox.Size = new System.Drawing.Size(79, 22);
            this.fParkingSpotsTextBox.TabIndex = 5;
            // 
            // oParkingSpotsTextBox
            // 
            this.oParkingSpotsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oParkingSpotsTextBox.Location = new System.Drawing.Point(173, 32);
            this.oParkingSpotsTextBox.Name = "oParkingSpotsTextBox";
            this.oParkingSpotsTextBox.ReadOnly = true;
            this.oParkingSpotsTextBox.Size = new System.Drawing.Size(79, 22);
            this.oParkingSpotsTextBox.TabIndex = 4;
            // 
            // tParkingSpotsTextBox
            // 
            this.tParkingSpotsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tParkingSpotsTextBox.Location = new System.Drawing.Point(173, 6);
            this.tParkingSpotsTextBox.Name = "tParkingSpotsTextBox";
            this.tParkingSpotsTextBox.ReadOnly = true;
            this.tParkingSpotsTextBox.Size = new System.Drawing.Size(79, 22);
            this.tParkingSpotsTextBox.TabIndex = 3;
            // 
            // fParkingSpots
            // 
            this.fParkingSpots.AutoSize = true;
            this.fParkingSpots.Location = new System.Drawing.Point(3, 58);
            this.fParkingSpots.Name = "fParkingSpots";
            this.fParkingSpots.Size = new System.Drawing.Size(91, 17);
            this.fParkingSpots.TabIndex = 2;
            this.fParkingSpots.Text = "Number Free";
            // 
            // oParkingSpots
            // 
            this.oParkingSpots.AutoSize = true;
            this.oParkingSpots.Location = new System.Drawing.Point(3, 32);
            this.oParkingSpots.Name = "oParkingSpots";
            this.oParkingSpots.Size = new System.Drawing.Size(122, 17);
            this.oParkingSpots.TabIndex = 1;
            this.oParkingSpots.Text = "Number Occupied";
            // 
            // tParkingSpots
            // 
            this.tParkingSpots.AutoSize = true;
            this.tParkingSpots.Location = new System.Drawing.Point(3, 6);
            this.tParkingSpots.Name = "tParkingSpots";
            this.tParkingSpots.Size = new System.Drawing.Size(163, 17);
            this.tParkingSpots.TabIndex = 0;
            this.tParkingSpots.Text = "Number of parking spots";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Renderer = new System.Windows.Forms.ToolStripProfessionalRenderer(new LightToolStripRenderer());
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDevModeToolStripMenuItem,
            this.randamizeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItem1.Text = "DevMode";
            // 
            // enableDevModeToolStripMenuItem
            // 
            this.enableDevModeToolStripMenuItem.Name = "enableDevModeToolStripMenuItem";
            this.enableDevModeToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.enableDevModeToolStripMenuItem.Text = "Enable Dev mode";
            this.enableDevModeToolStripMenuItem.Click += new System.EventHandler(this.EnableDevModeToolStripMenuItem_Click);
            // 
            // randamizeToolStripMenuItem
            // 
            this.randamizeToolStripMenuItem.Name = "randamizeToolStripMenuItem";
            this.randamizeToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.randamizeToolStripMenuItem.Text = "Randamize";
            this.randamizeToolStripMenuItem.Click += new System.EventHandler(this.RandamizeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "Save";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 459);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ContentPanel.ResumeLayout(false);
            this.TreeViewPanel.ResumeLayout(false);
            this.buttonControlsPannel.ResumeLayout(false);
            this.parkingStats.ResumeLayout(false);
            this.parkingStats.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel ContentPanel;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Panel parkingStats;
        public System.Windows.Forms.Label tParkingSpots;
        public System.Windows.Forms.Label fParkingSpots;
        public System.Windows.Forms.Label oParkingSpots;
        public System.Windows.Forms.TextBox tParkingSpotsTextBox;
        public System.Windows.Forms.TextBox fParkingSpotsTextBox;
        public System.Windows.Forms.TextBox oParkingSpotsTextBox;
        public System.Windows.Forms.Panel buttonControlsPannel;
        public System.Windows.Forms.Button addSlot;
        public System.Windows.Forms.Button addParkingSpot;
        public System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Button addNode;
        public System.Windows.Forms.Panel TreeViewPanel;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.Button loadButton;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        public System.Windows.Forms.Button removeItemButton;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem enableDevModeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem randamizeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
    }
}

