namespace DVLD
{
    partial class FrmListDetainedLisense
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
            this.cmReleaseMode = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvDetainedLiceseList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetainLicenseNumbers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReleaseLicense = new System.Windows.Forms.Button();
            this.btnDetainedLicense = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageReleaseDetaiLicesne = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLiceseList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmReleaseMode
            // 
            this.cmReleaseMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmReleaseMode.FormattingEnabled = true;
            this.cmReleaseMode.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmReleaseMode.Location = new System.Drawing.Point(289, 167);
            this.cmReleaseMode.Name = "cmReleaseMode";
            this.cmReleaseMode.Size = new System.Drawing.Size(100, 24);
            this.cmReleaseMode.TabIndex = 20;
            this.cmReleaseMode.SelectedIndexChanged += new System.EventHandler(this.cmReleaseMode_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(289, 160);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(165, 31);
            this.txtFilterValue.TabIndex = 19;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
            this.cmbFilterBy.Location = new System.Drawing.Point(88, 162);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(176, 29);
            this.cmbFilterBy.TabIndex = 18;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // dgvDetainedLiceseList
            // 
            this.dgvDetainedLiceseList.AllowUserToAddRows = false;
            this.dgvDetainedLiceseList.AllowUserToDeleteRows = false;
            this.dgvDetainedLiceseList.AllowUserToOrderColumns = true;
            this.dgvDetainedLiceseList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLiceseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLiceseList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLiceseList.Location = new System.Drawing.Point(12, 197);
            this.dgvDetainedLiceseList.Name = "dgvDetainedLiceseList";
            this.dgvDetainedLiceseList.ReadOnly = true;
            this.dgvDetainedLiceseList.RowHeadersWidth = 51;
            this.dgvDetainedLiceseList.RowTemplate.Height = 26;
            this.dgvDetainedLiceseList.Size = new System.Drawing.Size(1302, 467);
            this.dgvDetainedLiceseList.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(400, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "List Detained License";
            // 
            // lblDetainLicenseNumbers
            // 
            this.lblDetainLicenseNumbers.AutoSize = true;
            this.lblDetainLicenseNumbers.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblDetainLicenseNumbers.Location = new System.Drawing.Point(159, 678);
            this.lblDetainLicenseNumbers.Name = "lblDetainLicenseNumbers";
            this.lblDetainLicenseNumbers.Size = new System.Drawing.Size(27, 30);
            this.lblDetainLicenseNumbers.TabIndex = 21;
            this.lblDetainLicenseNumbers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(24, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "# Records: ";
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.Location = new System.Drawing.Point(1002, 139);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.Size = new System.Drawing.Size(126, 52);
            this.btnReleaseLicense.TabIndex = 23;
            this.btnReleaseLicense.Text = "Release License";
            this.btnReleaseLicense.UseVisualStyleBackColor = true;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // btnDetainedLicense
            // 
            this.btnDetainedLicense.Location = new System.Drawing.Point(1152, 138);
            this.btnDetainedLicense.Name = "btnDetainedLicense";
            this.btnDetainedLicense.Size = new System.Drawing.Size(126, 52);
            this.btnDetainedLicense.TabIndex = 23;
            this.btnDetainedLicense.Text = "Detained License";
            this.btnDetainedLicense.UseVisualStyleBackColor = true;
            this.btnDetainedLicense.Click += new System.EventHandler(this.btnDetainedLicense_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.PageReleaseDetaiLicesne});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 128);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // PageReleaseDetaiLicesne
            // 
            this.PageReleaseDetaiLicesne.Name = "PageReleaseDetaiLicesne";
            this.PageReleaseDetaiLicesne.Size = new System.Drawing.Size(264, 24);
            this.PageReleaseDetaiLicesne.Text = "Release Detain License";
            this.PageReleaseDetaiLicesne.Click += new System.EventHandler(this.PageReleaseDetaiLicesne_Click);
            // 
            // FrmListDetainedLisense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 717);
            this.Controls.Add(this.btnDetainedLicense);
            this.Controls.Add(this.btnReleaseLicense);
            this.Controls.Add(this.lblDetainLicenseNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmReleaseMode);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.dgvDetainedLiceseList);
            this.Controls.Add(this.label1);
            this.Name = "FrmListDetainedLisense";
            this.Text = "FrmListDetainedLisense";
            this.Load += new System.EventHandler(this.FrmListDetainedLisense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLiceseList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmReleaseMode;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.DataGridView dgvDetainedLiceseList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetainLicenseNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReleaseLicense;
        private System.Windows.Forms.Button btnDetainedLicense;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PageReleaseDetaiLicesne;
    }
}