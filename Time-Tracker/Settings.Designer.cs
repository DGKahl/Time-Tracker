
namespace Time_Tracker
{
    partial class Settings
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
            this.lblSlot1 = new System.Windows.Forms.Label();
            this.lblSlot2 = new System.Windows.Forms.Label();
            this.lblSlot3 = new System.Windows.Forms.Label();
            this.gbQuickslots = new System.Windows.Forms.GroupBox();
            this.cbSlot1 = new System.Windows.Forms.ComboBox();
            this.cbSlot2 = new System.Windows.Forms.ComboBox();
            this.cbSlot3 = new System.Windows.Forms.ComboBox();
            this.btnSlotsOK = new System.Windows.Forms.Button();
            this.gbQuickslots.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSlot1
            // 
            this.lblSlot1.AutoSize = true;
            this.lblSlot1.Location = new System.Drawing.Point(6, 28);
            this.lblSlot1.Name = "lblSlot1";
            this.lblSlot1.Size = new System.Drawing.Size(40, 13);
            this.lblSlot1.TabIndex = 0;
            this.lblSlot1.Text = "Slot 1: ";
            // 
            // lblSlot2
            // 
            this.lblSlot2.AutoSize = true;
            this.lblSlot2.Location = new System.Drawing.Point(6, 54);
            this.lblSlot2.Name = "lblSlot2";
            this.lblSlot2.Size = new System.Drawing.Size(40, 13);
            this.lblSlot2.TabIndex = 1;
            this.lblSlot2.Text = "Slot 2: ";
            // 
            // lblSlot3
            // 
            this.lblSlot3.AutoSize = true;
            this.lblSlot3.Location = new System.Drawing.Point(6, 80);
            this.lblSlot3.Name = "lblSlot3";
            this.lblSlot3.Size = new System.Drawing.Size(40, 13);
            this.lblSlot3.TabIndex = 2;
            this.lblSlot3.Text = "Slot 3: ";
            // 
            // gbQuickslots
            // 
            this.gbQuickslots.Controls.Add(this.btnSlotsOK);
            this.gbQuickslots.Controls.Add(this.cbSlot3);
            this.gbQuickslots.Controls.Add(this.cbSlot2);
            this.gbQuickslots.Controls.Add(this.cbSlot1);
            this.gbQuickslots.Controls.Add(this.lblSlot3);
            this.gbQuickslots.Controls.Add(this.lblSlot2);
            this.gbQuickslots.Controls.Add(this.lblSlot1);
            this.gbQuickslots.Location = new System.Drawing.Point(13, 13);
            this.gbQuickslots.Name = "gbQuickslots";
            this.gbQuickslots.Size = new System.Drawing.Size(273, 117);
            this.gbQuickslots.TabIndex = 0;
            this.gbQuickslots.TabStop = false;
            this.gbQuickslots.Text = "Quickslots";
            // 
            // cbSlot1
            // 
            this.cbSlot1.FormattingEnabled = true;
            this.cbSlot1.Location = new System.Drawing.Point(52, 25);
            this.cbSlot1.Name = "cbSlot1";
            this.cbSlot1.Size = new System.Drawing.Size(145, 21);
            this.cbSlot1.TabIndex = 3;
            // 
            // cbSlot2
            // 
            this.cbSlot2.FormattingEnabled = true;
            this.cbSlot2.Location = new System.Drawing.Point(52, 51);
            this.cbSlot2.Name = "cbSlot2";
            this.cbSlot2.Size = new System.Drawing.Size(145, 21);
            this.cbSlot2.TabIndex = 4;
            // 
            // cbSlot3
            // 
            this.cbSlot3.FormattingEnabled = true;
            this.cbSlot3.Location = new System.Drawing.Point(52, 77);
            this.cbSlot3.Name = "cbSlot3";
            this.cbSlot3.Size = new System.Drawing.Size(145, 21);
            this.cbSlot3.TabIndex = 5;
            // 
            // btnSlotsOK
            // 
            this.btnSlotsOK.Location = new System.Drawing.Point(208, 25);
            this.btnSlotsOK.Name = "btnSlotsOK";
            this.btnSlotsOK.Size = new System.Drawing.Size(51, 73);
            this.btnSlotsOK.TabIndex = 6;
            this.btnSlotsOK.Text = "OK";
            this.btnSlotsOK.UseVisualStyleBackColor = true;
            this.btnSlotsOK.Click += new System.EventHandler(this.btnSlotsOK_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 559);
            this.Controls.Add(this.gbQuickslots);
            this.Name = "Settings";
            this.Text = "Settings";
            this.gbQuickslots.ResumeLayout(false);
            this.gbQuickslots.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSlot1;
        private System.Windows.Forms.Label lblSlot2;
        private System.Windows.Forms.Label lblSlot3;
        private System.Windows.Forms.GroupBox gbQuickslots;
        private System.Windows.Forms.Button btnSlotsOK;
        private System.Windows.Forms.ComboBox cbSlot3;
        private System.Windows.Forms.ComboBox cbSlot2;
        private System.Windows.Forms.ComboBox cbSlot1;
    }
}