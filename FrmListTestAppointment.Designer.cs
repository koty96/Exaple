namespace DVLD
{
    partial class FrmListTestAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLicenseTestAppointments = new System.Windows.Forms.DataGridView();
            this.pcTestType = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbTestType = new System.Windows.Forms.GroupBox();
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.ctrlDrivingLicenseApplicationInfo();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTestType)).BeginInit();
            this.gbTestType.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(0, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(973, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAppointments
            // 
            this.dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenseTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLicenseTestAppointments.Location = new System.Drawing.Point(0, 496);
            this.dgvLicenseTestAppointments.Name = "dgvAppointments";
            this.dgvLicenseTestAppointments.RowHeadersWidth = 51;
            this.dgvLicenseTestAppointments.RowTemplate.Height = 26;
            this.dgvLicenseTestAppointments.Size = new System.Drawing.Size(1102, 234);
            this.dgvLicenseTestAppointments.TabIndex = 4;
            // 
            // pcTestType
            // 
            this.pcTestType.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pcTestType.Location = new System.Drawing.Point(396, 14);
            this.pcTestType.Name = "pcTestType";
            this.pcTestType.Size = new System.Drawing.Size(200, 124);
            this.pcTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcTestType.TabIndex = 0;
            this.pcTestType.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(367, 141);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Schedule Test";
            // 
            // gbTestType
            // 
            this.gbTestType.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.gbTestType.Controls.Add(this.button1);
            this.gbTestType.Controls.Add(this.dgvLicenseTestAppointments);
            this.gbTestType.Controls.Add(this.lblRecordCount);
            this.gbTestType.Controls.Add(this.label1);
            this.gbTestType.Controls.Add(this.lblTitle);
            this.gbTestType.Controls.Add(this.pcTestType);
            this.gbTestType.Location = new System.Drawing.Point(12, 12);
            this.gbTestType.Name = "gbTestType";
            this.gbTestType.Size = new System.Drawing.Size(1114, 736);
            this.gbTestType.TabIndex = 1;
            this.gbTestType.TabStop = false;
            this.gbTestType.Text = "Vision Test";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Tahoma", 4F);
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(21, 193);
            this.ctrlDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(878, 275);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 5;
            // 
            // lblTotalTestType
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordCount.Location = new System.Drawing.Point(72, 469);
            this.lblRecordCount.Name = "lblTotalTestType";
            this.lblRecordCount.Size = new System.Drawing.Size(21, 24);
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // FrmListTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 757);
            this.Controls.Add(this.gbTestType);
            this.Name = "FrmListTestAppointment";
            this.Text = "FrmListTestAppointment";
            this.Load += new System.EventHandler(this.FrmListTestAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTestType)).EndInit();
            this.gbTestType.ResumeLayout(false);
            this.gbTestType.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLicenseTestAppointments;
        private System.Windows.Forms.PictureBox pcTestType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbTestType;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}