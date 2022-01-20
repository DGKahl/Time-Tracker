
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
            this.cbSlot3 = new System.Windows.Forms.ComboBox();
            this.cbSlot2 = new System.Windows.Forms.ComboBox();
            this.cbSlot1 = new System.Windows.Forms.ComboBox();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.gbLogging = new System.Windows.Forms.GroupBox();
            this.btnLogpath = new System.Windows.Forms.Button();
            this.cbLogs = new System.Windows.Forms.CheckBox();
            this.nudLogs = new System.Windows.Forms.NumericUpDown();
            this.lblLogs = new System.Windows.Forms.Label();
            this.rbSession = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.gbQuickslots.SuspendLayout();
            this.gbLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLogs)).BeginInit();
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
            this.gbQuickslots.Controls.Add(this.cbSlot3);
            this.gbQuickslots.Controls.Add(this.cbSlot2);
            this.gbQuickslots.Controls.Add(this.cbSlot1);
            this.gbQuickslots.Controls.Add(this.lblSlot3);
            this.gbQuickslots.Controls.Add(this.lblSlot2);
            this.gbQuickslots.Controls.Add(this.lblSlot1);
            this.gbQuickslots.Location = new System.Drawing.Point(13, 13);
            this.gbQuickslots.Name = "gbQuickslots";
            this.gbQuickslots.Size = new System.Drawing.Size(209, 153);
            this.gbQuickslots.TabIndex = 0;
            this.gbQuickslots.TabStop = false;
            this.gbQuickslots.Text = "Quickslots";
            // 
            // cbSlot3
            // 
            this.cbSlot3.FormattingEnabled = true;
            this.cbSlot3.Location = new System.Drawing.Point(52, 77);
            this.cbSlot3.Name = "cbSlot3";
            this.cbSlot3.Size = new System.Drawing.Size(145, 21);
            this.cbSlot3.TabIndex = 5;
            // 
            // cbSlot2
            // 
            this.cbSlot2.FormattingEnabled = true;
            this.cbSlot2.Location = new System.Drawing.Point(52, 51);
            this.cbSlot2.Name = "cbSlot2";
            this.cbSlot2.Size = new System.Drawing.Size(145, 21);
            this.cbSlot2.TabIndex = 4;
            // 
            // cbSlot1
            // 
            this.cbSlot1.FormattingEnabled = true;
            this.cbSlot1.Location = new System.Drawing.Point(52, 25);
            this.cbSlot1.Name = "cbSlot1";
            this.cbSlot1.Size = new System.Drawing.Size(145, 21);
            this.cbSlot1.TabIndex = 3;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Location = new System.Drawing.Point(247, 181);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(167, 31);
            this.btnSettingsSave.TabIndex = 6;
            this.btnSettingsSave.Text = "Speichern und Schließen";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // gbLogging
            // 
            this.gbLogging.Controls.Add(this.btnLogpath);
            this.gbLogging.Controls.Add(this.cbLogs);
            this.gbLogging.Controls.Add(this.nudLogs);
            this.gbLogging.Controls.Add(this.lblLogs);
            this.gbLogging.Controls.Add(this.rbSession);
            this.gbLogging.Controls.Add(this.rbDaily);
            this.gbLogging.Location = new System.Drawing.Point(247, 12);
            this.gbLogging.Name = "gbLogging";
            this.gbLogging.Size = new System.Drawing.Size(167, 154);
            this.gbLogging.TabIndex = 1;
            this.gbLogging.TabStop = false;
            this.gbLogging.Text = "Log-Dateien";
            // 
            // btnLogpath
            // 
            this.btnLogpath.Location = new System.Drawing.Point(9, 114);
            this.btnLogpath.Name = "btnLogpath";
            this.btnLogpath.Size = new System.Drawing.Size(144, 23);
            this.btnLogpath.TabIndex = 5;
            this.btnLogpath.Text = "zu den Logs...";
            this.btnLogpath.UseVisualStyleBackColor = true;
            // 
            // cbLogs
            // 
            this.cbLogs.AutoSize = true;
            this.cbLogs.Location = new System.Drawing.Point(6, 24);
            this.cbLogs.Name = "cbLogs";
            this.cbLogs.Size = new System.Drawing.Size(73, 17);
            this.cbLogs.TabIndex = 4;
            this.cbLogs.Text = "Aktivieren";
            this.cbLogs.UseVisualStyleBackColor = true;
            this.cbLogs.CheckedChanged += new System.EventHandler(this.cbLogs_CheckedChanged);
            // 
            // nudLogs
            // 
            this.nudLogs.Enabled = false;
            this.nudLogs.Location = new System.Drawing.Point(111, 86);
            this.nudLogs.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudLogs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLogs.Name = "nudLogs";
            this.nudLogs.Size = new System.Drawing.Size(42, 20);
            this.nudLogs.TabIndex = 3;
            this.nudLogs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(6, 88);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(99, 13);
            this.lblLogs.TabIndex = 2;
            this.lblLogs.Text = "Gespeicherte Logs:";
            // 
            // rbSession
            // 
            this.rbSession.AutoSize = true;
            this.rbSession.Enabled = false;
            this.rbSession.Location = new System.Drawing.Point(6, 64);
            this.rbSession.Name = "rbSession";
            this.rbSession.Size = new System.Drawing.Size(106, 17);
            this.rbSession.TabIndex = 1;
            this.rbSession.TabStop = true;
            this.rbSession.Text = "Logs pro Session";
            this.rbSession.UseVisualStyleBackColor = true;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Enabled = false;
            this.rbDaily.Location = new System.Drawing.Point(6, 46);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(123, 17);
            this.rbDaily.TabIndex = 0;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Logs auf Tagesbasis";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 224);
            this.Controls.Add(this.btnSettingsSave);
            this.Controls.Add(this.gbLogging);
            this.Controls.Add(this.gbQuickslots);
            this.Name = "Settings";
            this.Text = "Settings";
            this.gbQuickslots.ResumeLayout(false);
            this.gbQuickslots.PerformLayout();
            this.gbLogging.ResumeLayout(false);
            this.gbLogging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSlot1;
        private System.Windows.Forms.Label lblSlot2;
        private System.Windows.Forms.Label lblSlot3;
        private System.Windows.Forms.GroupBox gbQuickslots;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.ComboBox cbSlot3;
        private System.Windows.Forms.ComboBox cbSlot2;
        private System.Windows.Forms.ComboBox cbSlot1;
        private System.Windows.Forms.GroupBox gbLogging;
        private System.Windows.Forms.Button btnLogpath;
        private System.Windows.Forms.CheckBox cbLogs;
        private System.Windows.Forms.NumericUpDown nudLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.RadioButton rbSession;
        private System.Windows.Forms.RadioButton rbDaily;
    }
}