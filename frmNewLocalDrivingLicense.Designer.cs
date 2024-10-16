namespace DVLD
{
    partial class frmNewLocalDrivingLicense
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcNewLocalDriving = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD.ctrlPersonCardWithFilter();
            this.tpApplicatoinInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicaitonFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblDVAppID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcNewLocalDriving.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpApplicatoinInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(95, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(822, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Local Driving Licesne Application";
            // 
            // tcNewLocalDriving
            // 
            this.tcNewLocalDriving.Controls.Add(this.tpPersonInfo);
            this.tcNewLocalDriving.Controls.Add(this.tpApplicatoinInfo);
            this.tcNewLocalDriving.Location = new System.Drawing.Point(62, 79);
            this.tcNewLocalDriving.Name = "tcNewLocalDriving";
            this.tcNewLocalDriving.SelectedIndex = 0;
            this.tcNewLocalDriving.Size = new System.Drawing.Size(1155, 585);
            this.tcNewLocalDriving.TabIndex = 2;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpPersonInfo.Size = new System.Drawing.Size(1147, 556);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNext.Location = new System.Drawing.Point(886, 493);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(175, 48);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AddPerson = true;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1141, 503);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // tpApplicatoinInfo
            // 
            this.tpApplicatoinInfo.Controls.Add(this.cbLicenseClass);
            this.tpApplicatoinInfo.Controls.Add(this.lblCreatedBy);
            this.tpApplicatoinInfo.Controls.Add(this.lblApplicaitonFees);
            this.tpApplicatoinInfo.Controls.Add(this.lblApplicationDate);
            this.tpApplicatoinInfo.Controls.Add(this.lblDVAppID);
            this.tpApplicatoinInfo.Controls.Add(this.label6);
            this.tpApplicatoinInfo.Controls.Add(this.label5);
            this.tpApplicatoinInfo.Controls.Add(this.label4);
            this.tpApplicatoinInfo.Controls.Add(this.label3);
            this.tpApplicatoinInfo.Controls.Add(this.label2);
            this.tpApplicatoinInfo.Location = new System.Drawing.Point(4, 25);
            this.tpApplicatoinInfo.Name = "tpApplicatoinInfo";
            this.tpApplicatoinInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicatoinInfo.Size = new System.Drawing.Size(1147, 556);
            this.tpApplicatoinInfo.TabIndex = 1;
            this.tpApplicatoinInfo.Text = "Application Info";
            this.tpApplicatoinInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(285, 217);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(370, 36);
            this.cbLicenseClass.TabIndex = 1;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCreatedBy.Location = new System.Drawing.Point(280, 379);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(69, 30);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "[???]";
            // 
            // lblApplicaitonFees
            // 
            this.lblApplicaitonFees.AutoSize = true;
            this.lblApplicaitonFees.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblApplicaitonFees.Location = new System.Drawing.Point(280, 296);
            this.lblApplicaitonFees.Name = "lblApplicaitonFees";
            this.lblApplicaitonFees.Size = new System.Drawing.Size(69, 30);
            this.lblApplicaitonFees.TabIndex = 0;
            this.lblApplicaitonFees.Text = "[???]";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblApplicationDate.Location = new System.Drawing.Point(280, 134);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(69, 30);
            this.lblApplicationDate.TabIndex = 0;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lblDVAppID
            // 
            this.lblDVAppID.AutoSize = true;
            this.lblDVAppID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblDVAppID.Location = new System.Drawing.Point(280, 62);
            this.lblDVAppID.Name = "lblDVAppID";
            this.lblDVAppID.Size = new System.Drawing.Size(69, 30);
            this.lblDVAppID.TabIndex = 0;
            this.lblDVAppID.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.Location = new System.Drawing.Point(132, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(72, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Applicaiton Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(107, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "License Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(71, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = " D.L ApplicationID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Location = new System.Drawing.Point(952, 721);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Location = new System.Drawing.Point(1149, 721);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 817);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcNewLocalDriving);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmNewLocalDrivingLicense";
            this.Activated += new System.EventHandler(this.frmNewLocalDrivingLicense_Activated);
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicense_Load);
            this.tcNewLocalDriving.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpApplicatoinInfo.ResumeLayout(false);
            this.tpApplicatoinInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcNewLocalDriving;
        private System.Windows.Forms.TabPage tpApplicatoinInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDVAppID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicaitonFees;
    }
}