namespace DVLD
{
    partial class ctrlDriverLicenses
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PgLocal = new System.Windows.Forms.TabPage();
            this.lblLocalLicensesRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pgInterNational = new System.Windows.Forms.TabPage();
            this.lblInternationalLicenseDriverNumbers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInterNationalLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PgLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pgInterNational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterNationalLicenses)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PgLocal);
            this.tabControl1.Controls.Add(this.pgInterNational);
            this.tabControl1.Location = new System.Drawing.Point(19, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // PgLocal
            // 
            this.PgLocal.Controls.Add(this.lblLocalLicensesRecords);
            this.PgLocal.Controls.Add(this.label3);
            this.PgLocal.Controls.Add(this.label2);
            this.PgLocal.Controls.Add(this.dgvLocalLicensesHistory);
            this.PgLocal.Location = new System.Drawing.Point(4, 33);
            this.PgLocal.Name = "PgLocal";
            this.PgLocal.Padding = new System.Windows.Forms.Padding(3);
            this.PgLocal.Size = new System.Drawing.Size(1065, 300);
            this.PgLocal.TabIndex = 0;
            this.PgLocal.Text = "Local";
            this.PgLocal.UseVisualStyleBackColor = true;
            // 
            // lblLocalLicensesRecords
            // 
            this.lblLocalLicensesRecords.AutoSize = true;
            this.lblLocalLicensesRecords.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblLocalLicensesRecords.Location = new System.Drawing.Point(153, 263);
            this.lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            this.lblLocalLicensesRecords.Size = new System.Drawing.Size(27, 30);
            this.lblLocalLicensesRecords.TabIndex = 17;
            this.lblLocalLicensesRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(28, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "#Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local Licenses History:";
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesHistory.AllowUserToOrderColumns = true;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(0, 56);
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.RowHeadersWidth = 51;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 26;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(1059, 194);
            this.dgvLocalLicensesHistory.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 28);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.fToolStripMenuItem.Text = "Show License Info";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // pgInterNational
            // 
            this.pgInterNational.Controls.Add(this.lblInternationalLicenseDriverNumbers);
            this.pgInterNational.Controls.Add(this.label5);
            this.pgInterNational.Controls.Add(this.label1);
            this.pgInterNational.Controls.Add(this.dgvInterNationalLicenses);
            this.pgInterNational.Location = new System.Drawing.Point(4, 33);
            this.pgInterNational.Name = "pgInterNational";
            this.pgInterNational.Padding = new System.Windows.Forms.Padding(3);
            this.pgInterNational.Size = new System.Drawing.Size(1065, 300);
            this.pgInterNational.TabIndex = 1;
            this.pgInterNational.Text = "InterNational";
            this.pgInterNational.UseVisualStyleBackColor = true;
            // 
            // lblInternationalLicenseDriverNumbers
            // 
            this.lblInternationalLicenseDriverNumbers.AutoSize = true;
            this.lblInternationalLicenseDriverNumbers.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblInternationalLicenseDriverNumbers.Location = new System.Drawing.Point(159, 267);
            this.lblInternationalLicenseDriverNumbers.Name = "lblInternationalLicenseDriverNumbers";
            this.lblInternationalLicenseDriverNumbers.Size = new System.Drawing.Size(27, 30);
            this.lblInternationalLicenseDriverNumbers.TabIndex = 19;
            this.lblInternationalLicenseDriverNumbers.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(34, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "#Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "InterNational Licenses History:";
            // 
            // dgvInterNationalLicenses
            // 
            this.dgvInterNationalLicenses.AllowUserToAddRows = false;
            this.dgvInterNationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInterNationalLicenses.AllowUserToOrderColumns = true;
            this.dgvInterNationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterNationalLicenses.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvInterNationalLicenses.Location = new System.Drawing.Point(6, 57);
            this.dgvInterNationalLicenses.Name = "dgvInterNationalLicenses";
            this.dgvInterNationalLicenses.ReadOnly = true;
            this.dgvInterNationalLicenses.RowHeadersWidth = 51;
            this.dgvInterNationalLicenses.RowTemplate.Height = 26;
            this.dgvInterNationalLicenses.Size = new System.Drawing.Size(1048, 194);
            this.dgvInterNationalLicenses.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(197, 28);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1125, 409);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.PgLocal.ResumeLayout(false);
            this.PgLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pgInterNational.ResumeLayout(false);
            this.pgInterNational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterNationalLicenses)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PgLocal;
        private System.Windows.Forms.TabPage pgInterNational;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInterNationalLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.Label lblLocalLicensesRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInternationalLicenseDriverNumbers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
