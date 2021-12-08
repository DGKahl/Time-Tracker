
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
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.dgvTimerTimes = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusWert = new System.Windows.Forms.Label();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.btnDeleteSelection = new System.Windows.Forms.Button();
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
            this.gbNew.Controls.Add(this.btnDeleteSelection);
            this.gbNew.Controls.Add(this.btnSaveChange);
            this.gbNew.Controls.Add(this.dtpEnd);
            this.gbNew.Controls.Add(this.dtpStart);
            this.gbNew.Controls.Add(this.btnSaveNew);
            this.gbNew.Controls.Add(this.dtpDate);
            this.gbNew.Controls.Add(this.lblEnd);
            this.gbNew.Controls.Add(this.lblStart);
            this.gbNew.Controls.Add(this.lblDate);
            this.gbNew.Location = new System.Drawing.Point(16, 50);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(160, 209);
            this.gbNew.TabIndex = 2;
            this.gbNew.TabStop = false;
            this.gbNew.Text = "Zeiten bearbeiten";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(9, 110);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(138, 27);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "Neuen Eintrag speichern";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveTime_Click);
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
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(53, 28);
            this.dtpDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(94, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
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
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(6, 59);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(28, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "von:";
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
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.dgvTimerTimes);
            this.gbEdit.Location = new System.Drawing.Point(204, 50);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(382, 209);
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
            this.dgvTimerTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTimerTimes.Size = new System.Drawing.Size(368, 184);
            this.dgvTimerTimes.TabIndex = 0;
            this.dgvTimerTimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimerTimes_CellClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(201, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusWert
            // 
            this.lblStatusWert.AutoSize = true;
            this.lblStatusWert.Location = new System.Drawing.Point(249, 13);
            this.lblStatusWert.Name = "lblStatusWert";
            this.lblStatusWert.Size = new System.Drawing.Size(45, 13);
            this.lblStatusWert.TabIndex = 5;
            this.lblStatusWert.Text = "wartend";
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(9, 143);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(138, 27);
            this.btnSaveChange.TabIndex = 7;
            this.btnSaveChange.Text = "Änderung speichern";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelection
            // 
            this.btnDeleteSelection.Location = new System.Drawing.Point(9, 176);
            this.btnDeleteSelection.Name = "btnDeleteSelection";
            this.btnDeleteSelection.Size = new System.Drawing.Size(138, 27);
            this.btnDeleteSelection.TabIndex = 2;
            this.btnDeleteSelection.Text = "Eintrag löschen";
            this.btnDeleteSelection.UseVisualStyleBackColor = true;
            // 
            // timelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 270);
            this.Controls.Add(this.lblStatusWert);
            this.Controls.Add(this.lblStatus);
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
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridView dgvTimerTimes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusWert;
        private System.Windows.Forms.Button btnDeleteSelection;
        private System.Windows.Forms.Button btnSaveChange;
    }
}