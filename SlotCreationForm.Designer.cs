﻿namespace ParkingSystem
{
    partial class SlotCreationForm
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
            this.NameLable = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.atNode = new System.Windows.Forms.Label();
            this.atNodeIndex = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.atNodeIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(15, 15);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(49, 17);
            this.NameLable.TabIndex = 0;
            this.NameLable.Text = "Name:";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(5, 96);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(95, 30);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(110, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 30);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(101, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(98, 22);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // atNode
            // 
            this.atNode.AutoSize = true;
            this.atNode.Location = new System.Drawing.Point(15, 36);
            this.atNode.Name = "atNode";
            this.atNode.Size = new System.Drawing.Size(63, 17);
            this.atNode.TabIndex = 4;
            this.atNode.Text = "At Node:";
            // 
            // atNodeIndex
            // 
            this.atNodeIndex.Location = new System.Drawing.Point(101, 36);
            this.atNodeIndex.Maximum = new decimal(new int[] {
            Program.nodes.Count,
            0,
            0,
            0});
            this.atNodeIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.atNodeIndex.Name = "atNodeIndex";
            this.atNodeIndex.Size = new System.Drawing.Size(98, 22);
            this.atNodeIndex.TabIndex = 5;
            this.atNodeIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SlotCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(210, 130);
            this.Controls.Add(this.atNodeIndex);
            this.Controls.Add(this.atNode);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.NameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlotCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NodeCreationForn";
            ((System.ComponentModel.ISupportInitialize)(this.atNodeIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label atNode;
        private System.Windows.Forms.NumericUpDown atNodeIndex;
    }
}