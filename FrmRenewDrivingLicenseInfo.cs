using DVLD_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FrmRenewDrivingLicenseInfo : Form
    {
        private int _LicenseID = -1;
        private int NewLicenseID = -1;

        public FrmRenewDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            lblOldLicenseID.Text = _LicenseID.ToString();

            if (obj == -1)
                return;

            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.License.LicenseClassInfo.DefaultValidityLength;
            lblLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1.License.LicenseClassInfo.ClassFees.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(DefaultValidityLength).ToShortDateString();
            lblTotalFees.Text = (Convert.ToSingle(lblAppFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFilter1.License.Notes;

            if (!ctrlDriverLicenseInfoWithFilter1.License.IsLicenseExpired())
            {
                btnRenew.Enabled = false;
                MessageBox.Show("Selected License is Not yet expaired,It will " +
                    "Expore on: " + ctrlDriverLicenseInfoWithFilter1.License.ExpirationDate.ToShortDateString(), "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!ctrlDriverLicenseInfoWithFilter1.License.IsActive)
            {
                MessageBox.Show("Selected License is not active ,Choose Another License Active  ", "Not Allowed",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            btnRenew.Enabled = true;
        }

        private void FrmRenewDrivingLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseFocus();

            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblISsueDate.Text = lblAppDate.Text;

            lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.RenewDrivingLicense).ApplicationFees.ToString();
            lblCreatedBy.Text = clsUser.FindByUserID(1).UserName;
        }

        private void btnRenew_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are You sure you want to Renew the license?", "Confirm",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
                clsLicense NewLicense = ctrlDriverLicenseInfoWithFilter1.License.RenewLicense(txtNotes.Text.Trim(), 1);
            if (NewLicense == null)
            {
                MessageBox.Show("Failed to renew the license","Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            NewLicenseID=NewLicense.LicenseID;
            lblRenewLicenseID.Text = NewLicense.LicenseClassID.ToString();
            lblDLAppID.Text = NewLicense.ApplicaitonID.ToString();
            MessageBox.Show("License Renew Successfully with ID = " + NewLicense.LicenseID, "License Issued",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            btnRenew.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;

            }
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowDriverLicenseInfo frm =
                new FrmShowDriverLicenseInfo(NewLicenseID);
            frm.ShowDialog();
        }
    }
}
