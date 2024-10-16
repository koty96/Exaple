namespace DVLD
{
    partial class frmListLocalDrivingLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblLocalLicenseNumbers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicaitonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showApplicationDetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.seToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(355, 167);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(197, 31);
            this.txtFilterValue.TabIndex = 23;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "LD.LAppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cmbFilterBy.Location = new System.Drawing.Point(141, 167);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(208, 29);
            this.cmbFilterBy.TabIndex = 22;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filter By:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 7F);
            this.btnAddUser.Location = new System.Drawing.Point(1263, 146);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(111, 47);
            this.btnAddUser.TabIndex = 20;
            this.btnAddUser.Text = "New Local License";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblLocalLicenseNumbers
            // 
            this.lblLocalLicenseNumbers.AutoSize = true;
            this.lblLocalLicenseNumbers.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblLocalLicenseNumbers.Location = new System.Drawing.Point(172, 694);
            this.lblLocalLicenseNumbers.Name = "lblLocalLicenseNumbers";
            this.lblLocalLicenseNumbers.Size = new System.Drawing.Size(27, 30);
            this.lblLocalLicenseNumbers.TabIndex = 18;
            this.lblLocalLicenseNumbers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(37, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "# Records: ";
            // 
            // dgvLocalDrivingList
            // 
            this.dgvLocalDrivingList.AllowUserToAddRows = false;
            this.dgvLocalDrivingList.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingList.AllowUserToOrderColumns = true;
            this.dgvLocalDrivingList.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalDrivingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDrivingList.Location = new System.Drawing.Point(42, 199);
            this.dgvLocalDrivingList.Name = "dgvLocalDrivingList";
            this.dgvLocalDrivingList.ReadOnly = true;
            this.dgvLocalDrivingList.RowHeadersWidth = 51;
            this.dgvLocalDrivingList.RowTemplate.Height = 26;
            this.dgvLocalDrivingList.Size = new System.Drawing.Size(1354, 483);
            this.dgvLocalDrivingList.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicaitonDetailsToolStripMenuItem,
            this.showApplicationDetaToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.seToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 124);
            // 
            // showApplicaitonDetailsToolStripMenuItem
            // 
            this.showApplicaitonDetailsToolStripMenuItem.Name = "showApplicaitonDetailsToolStripMenuItem";
            this.showApplicaitonDetailsToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.showApplicaitonDetailsToolStripMenuItem.Text = "Show Applicaiton Details";
            this.showApplicaitonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicaitonDetailsToolStripMenuItem_Click);
            // 
            // showApplicationDetaToolStripMenuItem
            // 
            this.showApplicationDetaToolStripMenuItem.Name = "showApplicationDetaToolStripMenuItem";
            this.showApplicationDetaToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.showApplicationDetaToolStripMenuItem.Text = "Edit Application ";
            this.showApplicationDetaToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetaToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "Local Driving License Application";
            // 
            // seToolStripMenuItem
            // 
            this.seToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.scheduleToolStripMenuItem1});
            this.seToolStripMenuItem.Name = "seToolStripMenuItem";
            this.seToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.seToolStripMenuItem.Text = "Schedule Test";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.scheduleToolStripMenuItem.Text = "Schedule written Test";
            // 
            // scheduleToolStripMenuItem1
            // 
            this.scheduleToolStripMenuItem1.Name = "scheduleToolStripMenuItem1";
            this.scheduleToolStripMenuItem1.Size = new System.Drawing.Size(232, 26);
            this.scheduleToolStripMenuItem1.Text = "Schedule Street Test";
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 794);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblLocalLicenseNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalDrivingList);
            this.Controls.Add(this.label1);
            this.Name = "frmListLocalDrivingLicenseApplications";
            this.Text = "frmListLocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblLocalLicenseNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalDrivingList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicaitonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem1;
    }
}