
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cbTimerSelection = new System.Windows.Forms.ComboBox();
            this.gbNew = new System.Windows.Forms.GroupBox();
            this.dtpEndDateSave = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateSave = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnDeleteSelection = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.dgvTimerTimes = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusWert = new System.Windows.Forms.Label();
            this.btnLoadTimes = new System.Windows.Forms.Button();
            this.gbNew.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimerTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(13, 13);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(42, 13);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Timer:";
            // 
            // cbTimerSelection
            // 
            this.cbTimerSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimerSelection.FormattingEnabled = true;
            this.cbTimerSelection.Location = new System.Drawing.Point(55, 10);
            this.cbTimerSelection.Name = "cbTimerSelection";
            this.cbTimerSelection.Size = new System.Drawing.Size(121, 21);
            this.cbTimerSelection.TabIndex = 1;
            this.cbTimerSelection.SelectedIndexChanged += new System.EventHandler(this.cbTimerSelection_SelectedIndexChanged);
            // 
            // gbNew
            // 
            this.gbNew.Controls.Add(this.dtpEndDateSave);
            this.gbNew.Controls.Add(this.dtpStartDateSave);
            this.gbNew.Controls.Add(this.lblEndDate);
            this.gbNew.Controls.Add(this.btnDeleteSelection);
            this.gbNew.Controls.Add(this.btnSaveChange);
            this.gbNew.Controls.Add(this.dtpEnd);
            this.gbNew.Controls.Add(this.dtpStart);
            this.gbNew.Controls.Add(this.btnSaveNew);
            this.gbNew.Controls.Add(this.lblStartDate);
            this.gbNew.Location = new System.Drawing.Point(16, 50);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(160, 250);
            this.gbNew.TabIndex = 2;
            this.gbNew.TabStop = false;
            this.gbNew.Text = "Zeiten bearbeiten";
            // 
            // dtpEndDateSave
            // 
            this.dtpEndDateSave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDateSave.Location = new System.Drawing.Point(48, 83);
            this.dtpEndDateSave.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpEndDateSave.Name = "dtpEndDateSave";
            this.dtpEndDateSave.Size = new System.Drawing.Size(94, 20);
            this.dtpEndDateSave.TabIndex = 11;
            // 
            // dtpStartDateSave
            // 
            this.dtpStartDateSave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateSave.Location = new System.Drawing.Point(48, 19);
            this.dtpStartDateSave.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpStartDateSave.Name = "dtpStartDateSave";
            this.dtpStartDateSave.Size = new System.Drawing.Size(94, 20);
            this.dtpStartDateSave.TabIndex = 10;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(7, 89);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(35, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "Ende:";
            // 
            // btnDeleteSelection
            // 
            this.btnDeleteSelection.Location = new System.Drawing.Point(10, 214);
            this.btnDeleteSelection.Name = "btnDeleteSelection";
            this.btnDeleteSelection.Size = new System.Drawing.Size(138, 27);
            this.btnDeleteSelection.TabIndex = 2;
            this.btnDeleteSelection.Text = "Eintrag löschen";
            this.btnDeleteSelection.UseVisualStyleBackColor = true;
            this.btnDeleteSelection.Click += new System.EventHandler(this.btnDeleteSelection_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(10, 181);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(138, 27);
            this.btnSaveChange.TabIndex = 7;
            this.btnSaveChange.Text = "Änderung speichern";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(48, 109);
            this.dtpEnd.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(94, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(48, 45);
            this.dtpStart.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(94, 20);
            this.dtpStart.TabIndex = 4;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(10, 148);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(138, 27);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "Neuen Eintrag speichern";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(7, 25);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(32, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start:";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(380, 11);
            this.dtpDateEnd.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(94, 20);
            this.dtpDateEnd.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(242, 10);
            this.dtpDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(94, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(355, 14);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(23, 13);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.Text = "bis:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(212, 13);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(28, 13);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "von:";
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.dgvTimerTimes);
            this.gbEdit.Location = new System.Drawing.Point(204, 50);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(382, 272);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Zeitenübersicht (zum Datum)";
            // 
            // dgvTimerTimes
            // 
            this.dgvTimerTimes.AllowUserToAddRows = false;
            this.dgvTimerTimes.AllowUserToDeleteRows = false;
            this.dgvTimerTimes.AllowUserToResizeColumns = false;
            this.dgvTimerTimes.AllowUserToResizeRows = false;
            this.dgvTimerTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimerTimes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimerTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimerTimes.Location = new System.Drawing.Point(7, 19);
            this.dgvTimerTimes.MultiSelect = false;
            this.dgvTimerTimes.Name = "dgvTimerTimes";
            this.dgvTimerTimes.ReadOnly = true;
            this.dgvTimerTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimerTimes.Size = new System.Drawing.Size(368, 247);
            this.dgvTimerTimes.TabIndex = 0;
            this.dgvTimerTimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimerTimes_CellClick);
            this.dgvTimerTimes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTimerTimes_DataBindingComplete);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(42, 303);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusWert
            // 
            this.lblStatusWert.AutoSize = true;
            this.lblStatusWert.Location = new System.Drawing.Point(95, 303);
            this.lblStatusWert.Name = "lblStatusWert";
            this.lblStatusWert.Size = new System.Drawing.Size(45, 13);
            this.lblStatusWert.TabIndex = 5;
            this.lblStatusWert.Text = "wartend";
            // 
            // btnLoadTimes
            // 
            this.btnLoadTimes.Location = new System.Drawing.Point(489, 10);
            this.btnLoadTimes.Name = "btnLoadTimes";
            this.btnLoadTimes.Size = new System.Drawing.Size(97, 34);
            this.btnLoadTimes.TabIndex = 9;
            this.btnLoadTimes.Text = "Laden";
            this.btnLoadTimes.UseVisualStyleBackColor = true;
            this.btnLoadTimes.Click += new System.EventHandler(this.btnLoadTimes_Click);
            // 
            // timelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 334);
            this.Controls.Add(this.btnLoadTimes);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.lblStatusWert);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbNew);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbTimerSelection);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
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
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridView dgvTimerTimes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusWert;
        private System.Windows.Forms.Button btnDeleteSelection;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnLoadTimes;
        private System.Windows.Forms.DateTimePicker dtpEndDateSave;
        private System.Windows.Forms.DateTimePicker dtpStartDateSave;
    }
}