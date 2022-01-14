
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbParallel = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbSelection = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.gbType.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 49);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(34, 13);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Info:  ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(15, 65);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(216, 20);
            this.txtInfo.TabIndex = 4;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbParallel);
            this.gbType.Controls.Add(this.rbSingle);
            this.gbType.Location = new System.Drawing.Point(15, 91);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(135, 46);
            this.gbType.TabIndex = 5;
            this.gbType.TabStop = false;
            this.gbType.Text = "Typ";
            // 
            // rbParallel
            // 
            this.rbParallel.AutoSize = true;
            this.rbParallel.Location = new System.Drawing.Point(67, 19);
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
            this.rbSingle.Location = new System.Drawing.Point(7, 19);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(54, 17);
            this.rbSingle.TabIndex = 0;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(156, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 46);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Speichern";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbSelection
            // 
            this.cbSelection.FormattingEnabled = true;
            this.cbSelection.Location = new System.Drawing.Point(15, 26);
            this.cbSelection.Name = "cbSelection";
            this.cbSelection.Size = new System.Drawing.Size(216, 21);
            this.cbSelection.TabIndex = 7;
            this.cbSelection.SelectedIndexChanged += new System.EventHandler(this.cbSelection_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(7, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(54, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Anlegen";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.btnDelete);
            this.gbMode.Controls.Add(this.btnEdit);
            this.gbMode.Controls.Add(this.btnNew);
            this.gbMode.Location = new System.Drawing.Point(15, 201);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(216, 53);
            this.gbMode.TabIndex = 10;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Modus";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Entf.";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(81, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Ändern";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.btnPickColor);
            this.gbColor.Location = new System.Drawing.Point(15, 143);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(216, 52);
            this.gbColor.TabIndex = 11;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Farbe";
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(7, 19);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(203, 23);
            this.btnPickColor.TabIndex = 1;
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // timer_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 267);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.cbSelection);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblName);
            this.Name = "timer_edit";
            this.Text = "timer_edit";
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbParallel;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbSelection;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}