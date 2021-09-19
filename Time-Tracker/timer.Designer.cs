
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
            this.lblEnd = new System.Windows.Forms.Label();
            this.gbDauer = new System.Windows.Forms.GroupBox();
            this.lblDurationTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbDauer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start: ";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 32);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(38, 13);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Ende: ";
            // 
            // gbDauer
            // 
            this.gbDauer.Controls.Add(this.lblDurationTime);
            this.gbDauer.Location = new System.Drawing.Point(15, 58);
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
            this.lblStartTime.Location = new System.Drawing.Point(54, 9);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(35, 13);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "label1";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(54, 32);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(35, 13);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "label2";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(158, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 26);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(196, 38);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(51, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "running...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 134);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.gbDauer);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Name = "timer";
            this.Text = "timer";
            this.gbDauer.ResumeLayout(false);
            this.gbDauer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.GroupBox gbDauer;
        private System.Windows.Forms.Label lblDurationTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
    }
}