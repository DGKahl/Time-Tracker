
namespace Time_Tracker
{
    partial class Start
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
            this.cbTimerSelection = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQTimer1 = new System.Windows.Forms.Button();
            this.btnQTimer2 = new System.Windows.Forms.Button();
            this.btnQTimer3 = new System.Windows.Forms.Button();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTimerSelection
            // 
            this.cbTimerSelection.FormattingEnabled = true;
            this.cbTimerSelection.Location = new System.Drawing.Point(12, 28);
            this.cbTimerSelection.Name = "cbTimerSelection";
            this.cbTimerSelection.Size = new System.Drawing.Size(166, 21);
            this.cbTimerSelection.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(184, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerTimerToolStripMenuItem,
            this.timerBearbeitenToolStripMenuItem,
            this.auswertungToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dateiToolStripMenuItem.Text = "Menü";
            // 
            // neuerTimerToolStripMenuItem
            // 
            this.neuerTimerToolStripMenuItem.Name = "neuerTimerToolStripMenuItem";
            this.neuerTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuerTimerToolStripMenuItem.Text = "Neuer Timer...";
            // 
            // auswertungToolStripMenuItem
            // 
            this.auswertungToolStripMenuItem.Name = "auswertungToolStripMenuItem";
            this.auswertungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.auswertungToolStripMenuItem.Text = "Auswertung...";
            // 
            // timerBearbeitenToolStripMenuItem
            // 
            this.timerBearbeitenToolStripMenuItem.Name = "timerBearbeitenToolStripMenuItem";
            this.timerBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timerBearbeitenToolStripMenuItem.Text = "Timer bearbeiten...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQTimer3);
            this.groupBox1.Controls.Add(this.btnQTimer2);
            this.groupBox1.Controls.Add(this.btnQTimer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Timer";
            // 
            // btnQTimer1
            // 
            this.btnQTimer1.Location = new System.Drawing.Point(6, 19);
            this.btnQTimer1.Name = "btnQTimer1";
            this.btnQTimer1.Size = new System.Drawing.Size(75, 49);
            this.btnQTimer1.TabIndex = 5;
            this.btnQTimer1.Text = "n/a";
            this.btnQTimer1.UseVisualStyleBackColor = true;
            // 
            // btnQTimer2
            // 
            this.btnQTimer2.Location = new System.Drawing.Point(87, 19);
            this.btnQTimer2.Name = "btnQTimer2";
            this.btnQTimer2.Size = new System.Drawing.Size(75, 49);
            this.btnQTimer2.TabIndex = 6;
            this.btnQTimer2.Text = "n/a";
            this.btnQTimer2.UseVisualStyleBackColor = true;
            // 
            // btnQTimer3
            // 
            this.btnQTimer3.Location = new System.Drawing.Point(168, 19);
            this.btnQTimer3.Name = "btnQTimer3";
            this.btnQTimer3.Size = new System.Drawing.Size(75, 49);
            this.btnQTimer3.TabIndex = 7;
            this.btnQTimer3.Text = "n/a";
            this.btnQTimer3.UseVisualStyleBackColor = true;
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(18, 55);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(49, 13);
            this.lblRuntime.TabIndex = 5;
            this.lblRuntime.Text = "00:00:00";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 175);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbTimerSelection);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Übersicht";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTimerSelection;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswertungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerBearbeitenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQTimer3;
        private System.Windows.Forms.Button btnQTimer2;
        private System.Windows.Forms.Button btnQTimer1;
        private System.Windows.Forms.Label lblRuntime;
    }
}

