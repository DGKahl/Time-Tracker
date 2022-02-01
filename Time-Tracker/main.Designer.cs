
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
            this.timerBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeitenBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswertungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQTimer3 = new System.Windows.Forms.Button();
            this.btnQTimer2 = new System.Windows.Forms.Button();
            this.btnQTimer1 = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTimerSelection
            // 
            this.cbTimerSelection.FormattingEnabled = true;
            this.cbTimerSelection.Location = new System.Drawing.Point(12, 28);
            this.cbTimerSelection.Name = "cbTimerSelection";
            this.cbTimerSelection.Size = new System.Drawing.Size(248, 21);
            this.cbTimerSelection.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 55);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
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
            this.timerLöschenToolStripMenuItem,
            this.zeitenBearbeitenToolStripMenuItem,
            this.auswertungToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dateiToolStripMenuItem.Text = "Menü";
            // 
            // neuerTimerToolStripMenuItem
            // 
            this.neuerTimerToolStripMenuItem.Name = "neuerTimerToolStripMenuItem";
            this.neuerTimerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.neuerTimerToolStripMenuItem.Text = "Neuer Timer...";
            this.neuerTimerToolStripMenuItem.Click += new System.EventHandler(this.neuerTimerToolStripMenuItem_Click);
            // 
            // timerBearbeitenToolStripMenuItem
            // 
            this.timerBearbeitenToolStripMenuItem.Name = "timerBearbeitenToolStripMenuItem";
            this.timerBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.timerBearbeitenToolStripMenuItem.Text = "Timer bearbeiten...";
            this.timerBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.timerBearbeitenToolStripMenuItem_Click);
            // 
            // timerLöschenToolStripMenuItem
            // 
            this.timerLöschenToolStripMenuItem.Name = "timerLöschenToolStripMenuItem";
            this.timerLöschenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.timerLöschenToolStripMenuItem.Text = "Timer löschen...";
            this.timerLöschenToolStripMenuItem.Click += new System.EventHandler(this.timerLöschenToolStripMenuItem_Click);
            // 
            // zeitenBearbeitenToolStripMenuItem
            // 
            this.zeitenBearbeitenToolStripMenuItem.Name = "zeitenBearbeitenToolStripMenuItem";
            this.zeitenBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.zeitenBearbeitenToolStripMenuItem.Text = "Zeiten...";
            this.zeitenBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.zeitenBearbeitenToolStripMenuItem_Click);
            // 
            // auswertungToolStripMenuItem
            // 
            this.auswertungToolStripMenuItem.Name = "auswertungToolStripMenuItem";
            this.auswertungToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.auswertungToolStripMenuItem.Text = "Auswertung...";
            this.auswertungToolStripMenuItem.Click += new System.EventHandler(this.auswertungToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bearbeitenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten...";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQTimer3);
            this.groupBox1.Controls.Add(this.btnQTimer2);
            this.groupBox1.Controls.Add(this.btnQTimer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Timer";
            // 
            // btnQTimer3
            // 
            this.btnQTimer3.Location = new System.Drawing.Point(168, 22);
            this.btnQTimer3.Name = "btnQTimer3";
            this.btnQTimer3.Size = new System.Drawing.Size(75, 43);
            this.btnQTimer3.TabIndex = 7;
            this.btnQTimer3.Text = "n/a";
            this.btnQTimer3.UseVisualStyleBackColor = true;
            this.btnQTimer3.Click += new System.EventHandler(this.btnQTimer3_Click);
            // 
            // btnQTimer2
            // 
            this.btnQTimer2.Location = new System.Drawing.Point(87, 22);
            this.btnQTimer2.Name = "btnQTimer2";
            this.btnQTimer2.Size = new System.Drawing.Size(75, 43);
            this.btnQTimer2.TabIndex = 6;
            this.btnQTimer2.Text = "n/a";
            this.btnQTimer2.UseVisualStyleBackColor = true;
            this.btnQTimer2.Click += new System.EventHandler(this.btnQTimer2_Click);
            // 
            // btnQTimer1
            // 
            this.btnQTimer1.Location = new System.Drawing.Point(6, 22);
            this.btnQTimer1.Name = "btnQTimer1";
            this.btnQTimer1.Size = new System.Drawing.Size(75, 43);
            this.btnQTimer1.TabIndex = 5;
            this.btnQTimer1.Text = "n/a";
            this.btnQTimer1.UseVisualStyleBackColor = true;
            this.btnQTimer1.Click += new System.EventHandler(this.btnQTimer1_Click);
            // 
            // btnStopAll
            // 
            this.btnStopAll.Location = new System.Drawing.Point(140, 55);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(120, 27);
            this.btnStopAll.TabIndex = 6;
            this.btnStopAll.Text = "Alle stoppen";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.rtbLog);
            this.gbLog.Location = new System.Drawing.Point(12, 184);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(248, 91);
            this.gbLog.TabIndex = 7;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.Location = new System.Drawing.Point(7, 20);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(236, 65);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 283);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.btnStopAll);
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
            this.gbLog.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeitenBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerLöschenToolStripMenuItem;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

