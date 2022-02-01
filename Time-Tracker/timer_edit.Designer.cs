
namespace Time_Tracker
{
    partial class timer_edit
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
            this.lblNote = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.rbParallel = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbSelection = new System.Windows.Forms.ComboBox();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbSelection = new System.Windows.Forms.GroupBox();
            this.bDetails = new System.Windows.Forms.GroupBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbSelection.SuspendLayout();
            this.bDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(6, 62);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(34, 13);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Info:  ";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(53, 59);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(251, 20);
            this.txtInfo.TabIndex = 4;
            // 
            // rbParallel
            // 
            this.rbParallel.AutoSize = true;
            this.rbParallel.Location = new System.Drawing.Point(53, 115);
            this.rbParallel.Name = "rbParallel";
            this.rbParallel.Size = new System.Drawing.Size(59, 17);
            this.rbParallel.TabIndex = 1;
            this.rbParallel.TabStop = true;
            this.rbParallel.Text = "Parallel";
            this.rbParallel.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(53, 92);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(54, 17);
            this.rbSingle.TabIndex = 0;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Speichern";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbSelection
            // 
            this.cbSelection.FormattingEnabled = true;
            this.cbSelection.Location = new System.Drawing.Point(6, 19);
            this.cbSelection.Name = "cbSelection";
            this.cbSelection.Size = new System.Drawing.Size(136, 21);
            this.cbSelection.TabIndex = 7;
            this.cbSelection.SelectedIndexChanged += new System.EventHandler(this.cbSelection_SelectedIndexChanged);
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(164, 112);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(140, 23);
            this.btnPickColor.TabIndex = 1;
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(148, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Bearbeiten";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(229, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "Neu...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbSelection
            // 
            this.gbSelection.Controls.Add(this.cbSelection);
            this.gbSelection.Controls.Add(this.btnNew);
            this.gbSelection.Controls.Add(this.btnSelect);
            this.gbSelection.Location = new System.Drawing.Point(12, 12);
            this.gbSelection.Name = "gbSelection";
            this.gbSelection.Size = new System.Drawing.Size(317, 51);
            this.gbSelection.TabIndex = 14;
            this.gbSelection.TabStop = false;
            this.gbSelection.Text = "Auswahl";
            // 
            // bDetails
            // 
            this.bDetails.Controls.Add(this.btnPickColor);
            this.bDetails.Controls.Add(this.lblColour);
            this.bDetails.Controls.Add(this.rbParallel);
            this.bDetails.Controls.Add(this.lbltype);
            this.bDetails.Controls.Add(this.rbSingle);
            this.bDetails.Controls.Add(this.txtName);
            this.bDetails.Controls.Add(this.lblName);
            this.bDetails.Controls.Add(this.lblNote);
            this.bDetails.Controls.Add(this.txtInfo);
            this.bDetails.Location = new System.Drawing.Point(12, 81);
            this.bDetails.Name = "bDetails";
            this.bDetails.Size = new System.Drawing.Size(317, 154);
            this.bDetails.TabIndex = 15;
            this.bDetails.TabStop = false;
            this.bDetails.Text = "Details";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(216, 96);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(37, 13);
            this.lblColour.TabIndex = 18;
            this.lblColour.Text = "Farbe:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(6, 92);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(28, 13);
            this.lbltype.TabIndex = 17;
            this.lbltype.Text = "Typ:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 20);
            this.txtName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(254, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // timer_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 282);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bDetails);
            this.Controls.Add(this.gbSelection);
            this.Controls.Add(this.btnOK);
            this.Name = "timer_edit";
            this.Text = "timer_edit";
            this.gbSelection.ResumeLayout(false);
            this.bDetails.ResumeLayout(false);
            this.bDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.RadioButton rbParallel;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbSelection;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbSelection;
        private System.Windows.Forms.GroupBox bDetails;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
    }
}