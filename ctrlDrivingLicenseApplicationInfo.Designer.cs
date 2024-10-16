namespace DVLD
{
    partial class ctrlDrivingLicenseApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.lblAppliedFor = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlApplicationBasicInfo1 = new DVLD.ctrlApplicationBasicInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkLicenseInfo);
            this.groupBox1.Controls.Add(this.lblDLAppID);
            this.groupBox1.Controls.Add(this.lblAppliedFor);
            this.groupBox1.Controls.Add(this.lblPassedTests);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Applicaiton Info";
            // 
            // lnkLicenseInfo
            // 
            this.lnkLicenseInfo.AutoSize = true;
            this.lnkLicenseInfo.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lnkLicenseInfo.Location = new System.Drawing.Point(130, 141);
            this.lnkLicenseInfo.Name = "lnkLicenseInfo";
            this.lnkLicenseInfo.Size = new System.Drawing.Size(216, 30);
            this.lnkLicenseInfo.TabIndex = 1;
            this.lnkLicenseInfo.TabStop = true;
            this.lnkLicenseInfo.Text = "Show License Info";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblDLAppID.Location = new System.Drawing.Point(183, 46);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(57, 30);
            this.lblDLAppID.TabIndex = 0;
            this.lblDLAppID.Text = "[??]";
            // 
            // lblAppliedFor
            // 
            this.lblAppliedFor.AutoSize = true;
            this.lblAppliedFor.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblAppliedFor.Location = new System.Drawing.Point(683, 46);
            this.lblAppliedFor.Name = "lblAppliedFor";
            this.lblAppliedFor.Size = new System.Drawing.Size(57, 30);
            this.lblAppliedFor.TabIndex = 0;
            this.lblAppliedFor.Text = "[??]";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblPassedTests.Location = new System.Drawing.Point(622, 130);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(27, 30);
            this.lblPassedTests.TabIndex = 0;
            this.lblPassedTests.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(462, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Passed Tests:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(411, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Applied For Application:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L App ID:";
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(12, 201);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(1157, 324);
            this.ctrlApplicationBasicInfo1.TabIndex = 1;
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(1170, 525);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkLicenseInfo;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label lblAppliedFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassedTests;
        private ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
    }
}
