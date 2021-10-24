﻿
namespace Time_Tracker
{
    partial class timelist
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.cbTimerSelection = new System.Windows.Forms.ComboBox();
            this.gbNew = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.dgvTimerTimes = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteSelection = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbNew.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimerTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(13, 13);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(36, 13);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Timer:";
            // 
            // cbTimerSelection
            // 
            this.cbTimerSelection.FormattingEnabled = true;
            this.cbTimerSelection.Location = new System.Drawing.Point(55, 10);
            this.cbTimerSelection.Name = "cbTimerSelection";
            this.cbTimerSelection.Size = new System.Drawing.Size(121, 21);
            this.cbTimerSelection.TabIndex = 1;
            this.cbTimerSelection.SelectedIndexChanged += new System.EventHandler(this.cbTimerSelection_SelectedIndexChanged);
            // 
            // gbNew
            // 
            this.gbNew.Controls.Add(this.btnSaveTime);
            this.gbNew.Controls.Add(this.dtpEnd);
            this.gbNew.Controls.Add(this.dtpStart);
            this.gbNew.Controls.Add(this.dtpDate);
            this.gbNew.Controls.Add(this.lblEnd);
            this.gbNew.Controls.Add(this.lblStart);
            this.gbNew.Controls.Add(this.lblDate);
            this.gbNew.Location = new System.Drawing.Point(16, 50);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(160, 148);
            this.gbNew.TabIndex = 2;
            this.gbNew.TabStop = false;
            this.gbNew.Text = "Neue Zeit erfassen";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Datum:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(6, 59);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(28, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "von:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(6, 87);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(23, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "bis:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(53, 28);
            this.dtpDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(94, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(53, 56);
            this.dtpStart.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(94, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(53, 84);
            this.dtpEnd.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(94, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.Location = new System.Drawing.Point(9, 115);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(138, 23);
            this.btnSaveTime.TabIndex = 6;
            this.btnSaveTime.Text = "Speichern";
            this.btnSaveTime.UseVisualStyleBackColor = true;
            this.btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnDeleteSelection);
            this.gbEdit.Controls.Add(this.btnSaveChanges);
            this.gbEdit.Controls.Add(this.dgvTimerTimes);
            this.gbEdit.Location = new System.Drawing.Point(204, 50);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(212, 148);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Zeiten bearbeiten";
            // 
            // dgvTimerTimes
            // 
            this.dgvTimerTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimerTimes.Location = new System.Drawing.Point(7, 19);
            this.dgvTimerTimes.Name = "dgvTimerTimes";
            this.dgvTimerTimes.Size = new System.Drawing.Size(198, 90);
            this.dgvTimerTimes.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(6, 115);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(77, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Speichern";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelection
            // 
            this.btnDeleteSelection.Location = new System.Drawing.Point(93, 115);
            this.btnDeleteSelection.Name = "btnDeleteSelection";
            this.btnDeleteSelection.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteSelection.TabIndex = 2;
            this.btnDeleteSelection.Text = "Eintrag löschen";
            this.btnDeleteSelection.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(204, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(212, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // timelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 211);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbNew);
            this.Controls.Add(this.cbTimerSelection);
            this.Controls.Add(this.lblTimer);
            this.Name = "timelist";
            this.Text = "Zeiten bearbeiten";
            this.gbNew.ResumeLayout(false);
            this.gbNew.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimerTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox cbTimerSelection;
        private System.Windows.Forms.GroupBox gbNew;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridView dgvTimerTimes;
        private System.Windows.Forms.Button btnDeleteSelection;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnRefresh;
    }
}