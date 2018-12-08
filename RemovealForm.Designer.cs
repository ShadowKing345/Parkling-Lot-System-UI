namespace ParkingSystem
{
    partial class RemovealForm
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
            this.NodeLabel = new System.Windows.Forms.Label();
            this.nodeIndexUpDown = new System.Windows.Forms.NumericUpDown();
            this.SlotLabel = new System.Windows.Forms.Label();
            this.ParkingSpotLabel = new System.Windows.Forms.Label();
            this.slotIndexUpDown = new System.Windows.Forms.NumericUpDown();
            this.parkingSlotUpDown = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nodeIndexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotIndexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlotUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NodeLabel
            // 
            this.NodeLabel.AutoSize = true;
            this.NodeLabel.Location = new System.Drawing.Point(13, 13);
            this.NodeLabel.Name = "NodeLabel";
            this.NodeLabel.Size = new System.Drawing.Size(46, 17);
            this.NodeLabel.TabIndex = 0;
            this.NodeLabel.Text = "Node:";
            // 
            // nodeIndexUpDown
            // 
            this.nodeIndexUpDown.Location = new System.Drawing.Point(112, 11);
            this.nodeIndexUpDown.Name = "nodeIndexUpDown";
            this.nodeIndexUpDown.Size = new System.Drawing.Size(90, 22);
            this.nodeIndexUpDown.TabIndex = 1;
            this.nodeIndexUpDown.ValueChanged += new System.EventHandler(this.nodeIndexUpDown_ValueChanged);
            this.nodeIndexUpDown.Maximum = Program.nodes.Count;
            // 
            // SlotLabel
            // 
            this.SlotLabel.AutoSize = true;
            this.SlotLabel.Location = new System.Drawing.Point(13, 39);
            this.SlotLabel.Name = "SlotLabel";
            this.SlotLabel.Size = new System.Drawing.Size(36, 17);
            this.SlotLabel.TabIndex = 2;
            this.SlotLabel.Text = "Slot:";
            // 
            // ParkingSpotLabel
            // 
            this.ParkingSpotLabel.AutoSize = true;
            this.ParkingSpotLabel.Location = new System.Drawing.Point(13, 67);
            this.ParkingSpotLabel.Name = "ParkingSpotLabel";
            this.ParkingSpotLabel.Size = new System.Drawing.Size(93, 17);
            this.ParkingSpotLabel.TabIndex = 3;
            this.ParkingSpotLabel.Text = "Parking Spot:";
            // 
            // slotIndexUpDown
            // 
            this.slotIndexUpDown.Location = new System.Drawing.Point(112, 39);
            this.slotIndexUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.slotIndexUpDown.Name = "slotIndexUpDown";
            this.slotIndexUpDown.Size = new System.Drawing.Size(90, 22);
            this.slotIndexUpDown.TabIndex = 4;
            this.slotIndexUpDown.ValueChanged += new System.EventHandler(this.slotIndexUpDown_ValueChanged);
            // 
            // parkingSlotUpDown
            // 
            this.parkingSlotUpDown.Location = new System.Drawing.Point(112, 67);
            this.parkingSlotUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.parkingSlotUpDown.Name = "parkingSlotUpDown";
            this.parkingSlotUpDown.Size = new System.Drawing.Size(90, 22);
            this.parkingSlotUpDown.TabIndex = 5;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(13, 95);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(90, 30);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(112, 95);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 30);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemovealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 138);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.parkingSlotUpDown);
            this.Controls.Add(this.slotIndexUpDown);
            this.Controls.Add(this.ParkingSpotLabel);
            this.Controls.Add(this.SlotLabel);
            this.Controls.Add(this.nodeIndexUpDown);
            this.Controls.Add(this.NodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "RemovealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemovealForm";
            ((System.ComponentModel.ISupportInitialize)(this.nodeIndexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotIndexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlotUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NodeLabel;
        private System.Windows.Forms.NumericUpDown nodeIndexUpDown;
        private System.Windows.Forms.Label SlotLabel;
        private System.Windows.Forms.Label ParkingSpotLabel;
        private System.Windows.Forms.NumericUpDown slotIndexUpDown;
        private System.Windows.Forms.NumericUpDown parkingSlotUpDown;
        private System.Windows.Forms.Button ConfirmButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}