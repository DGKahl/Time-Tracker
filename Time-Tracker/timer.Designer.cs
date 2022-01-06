
namespace Time_Tracker
{
    partial class timer
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
            this.lblStart = new System.Windows.Forms.Label();
            this.gbDauer = new System.Windows.Forms.GroupBox();
            this.lblDurationTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbDauer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(12, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start: ";
            // 
            // gbDauer
            // 
            this.gbDauer.Controls.Add(this.lblDurationTime);
            this.gbDauer.Location = new System.Drawing.Point(15, 44);
            this.gbDauer.Name = "gbDauer";
            this.gbDauer.Size = new System.Drawing.Size(232, 65);
            this.gbDauer.TabIndex = 2;
            this.gbDauer.TabStop = false;
            this.gbDauer.Text = "Dauer";
            // 
            // lblDurationTime
            // 
            this.lblDurationTime.AutoSize = true;
            this.lblDurationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationTime.Location = new System.Drawing.Point(29, 16);
            this.lblDurationTime.Name = "lblDurationTime";
            this.lblDurationTime.Size = new System.Drawing.Size(174, 46);
            this.lblDurationTime.TabIndex = 0;
            this.lblDurationTime.Text = "00:00:00";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(13, 25);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(35, 13);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "label1";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(133, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 29);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 121);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.gbDauer);
            this.Controls.Add(this.lblStart);
            this.Name = "timer";
            this.Text = "timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.timer_FormClosing);
            this.gbDauer.ResumeLayout(false);
            this.gbDauer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.GroupBox gbDauer;
        private System.Windows.Forms.Label lblDurationTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button btnStop;
    }
}