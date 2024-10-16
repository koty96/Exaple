namespace DVLD
{
    partial class FrmReplaceLostOrDamageLicense
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
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.ctrlDriverLicenseInfoWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblReplaceLicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.lblDriverLicenseAppID = new System.Windows.Forms.Label();
            this.btnIssueRepacement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbReplacement = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbReplacement.SuspendLayout();
            this.SuspendLayout();
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(326, 735);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(273, 29);
            this.llShowLicenseInfo.TabIndex = 18;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show New Licenses Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-5, 4);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1087, 527);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 17;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAppFees);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAppDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblReplaceLicenseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDLAppID);
            this.groupBox1.Controls.Add(this.lblDriverLicenseAppID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(36, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 164);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application New License Info";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblAppFees.Location = new System.Drawing.Point(222, 121);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(53, 29);
            this.lblAppFees.TabIndex = 10;
            this.lblAppFees.Text = "[??]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Application Fees:";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblAppDate.Location = new System.Drawing.Point(222, 86);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(53, 29);
            this.lblAppDate.TabIndex = 10;
            this.lblAppDate.Text = "[??]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Application Date:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblCreatedBy.Location = new System.Drawing.Point(703, 97);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(53, 29);
            this.lblCreatedBy.TabIndex = 10;
            this.lblCreatedBy.Text = "[??]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label8.Location = new System.Drawing.Point(487, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Created By:";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblOldLicenseID.Location = new System.Drawing.Point(703, 59);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(53, 29);
            this.lblOldLicenseID.TabIndex = 10;
            this.lblOldLicenseID.Text = "[??]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label10.Location = new System.Drawing.Point(487, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Old License ID:";
            // 
            // lblReplaceLicenseID
            // 
            this.lblReplaceLicenseID.AutoSize = true;
            this.lblReplaceLicenseID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblReplaceLicenseID.Location = new System.Drawing.Point(770, 28);
            this.lblReplaceLicenseID.Name = "lblReplaceLicenseID";
            this.lblReplaceLicenseID.Size = new System.Drawing.Size(53, 29);
            this.lblReplaceLicenseID.TabIndex = 10;
            this.lblReplaceLicenseID.Text = "[??]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.Location = new System.Drawing.Point(487, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Replacement License ID:";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblDLAppID.Location = new System.Drawing.Point(222, 42);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(53, 29);
            this.lblDLAppID.TabIndex = 10;
            this.lblDLAppID.Text = "[??]";
            // 
            // lblDriverLicenseAppID
            // 
            this.lblDriverLicenseAppID.AutoSize = true;
            this.lblDriverLicenseAppID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblDriverLicenseAppID.Location = new System.Drawing.Point(6, 42);
            this.lblDriverLicenseAppID.Name = "lblDriverLicenseAppID";
            this.lblDriverLicenseAppID.Size = new System.Drawing.Size(210, 29);
            this.lblDriverLicenseAppID.TabIndex = 11;
            this.lblDriverLicenseAppID.Text = "D.L Application ID:";
            // 
            // btnIssueRepacement
            // 
            this.btnIssueRepacement.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnIssueRepacement.Location = new System.Drawing.Point(923, 735);
            this.btnIssueRepacement.Name = "btnIssueRepacement";
            this.btnIssueRepacement.Size = new System.Drawing.Size(173, 46);
            this.btnIssueRepacement.TabIndex = 14;
            this.btnIssueRepacement.Text = "Issue Replacement";
            this.btnIssueRepacement.UseVisualStyleBackColor = true;
            this.btnIssueRepacement.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Location = new System.Drawing.Point(795, 735);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 46);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbReplacement
            // 
            this.gbReplacement.Controls.Add(this.rbLostLicense);
            this.gbReplacement.Controls.Add(this.rbDamagedLicense);
            this.gbReplacement.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbReplacement.Location = new System.Drawing.Point(682, 4);
            this.gbReplacement.Name = "gbReplacement";
            this.gbReplacement.Size = new System.Drawing.Size(400, 130);
            this.gbReplacement.TabIndex = 0;
            this.gbReplacement.TabStop = false;
            this.gbReplacement.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(39, 83);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(140, 28);
            this.rbLostLicense.TabIndex = 0;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(39, 40);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(196, 28);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License:";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // FrmReplaceLostOrDamageLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 795);
            this.Controls.Add(this.gbReplacement);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIssueRepacement);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmReplaceLostOrDamageLicense";
            this.Text = "FrmReplaceLostOrDamageLicense";
            this.Load += new System.EventHandler(this.FrmReplaceLostOrDamageLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbReplacement.ResumeLayout(false);
            this.gbReplacement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblReplaceLicenseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label lblDriverLicenseAppID;
        private System.Windows.Forms.Button btnIssueRepacement;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbReplacement;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
    }
}