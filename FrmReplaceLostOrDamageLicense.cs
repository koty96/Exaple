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
    public partial class FrmReplaceLostOrDamageLicense : Form
    {
        private int NewLicenseID = -1;
        public FrmReplaceLostOrDamageLicense()
        {
            InitializeComponent();
        }

        private void FrmReplaceLostOrDamageLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseFocus();

            lblAppDate.Text = DateTime.Now.ToShortDateString();

            /*if(rbDamagedLicense.Checked)
                lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.ReplaceDamgedDrivingLicense).ApplicationFees.ToString();
            else
                lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.ReplaceLostDrivingLicense).ApplicationFees.ToString();*/

            lblCreatedBy.Text = clsUser.FindByUserID(1).UserName;
            rbDamagedLicense.Checked = true;

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowDriverLicenseInfo frm =
                new FrmShowDriverLicenseInfo(NewLicenseID);
            frm.ShowDialog();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int _LicenseID = obj;

            lblOldLicenseID.Text = _LicenseID.ToString();

            if (obj == -1)
                return;

            if (!ctrlDriverLicenseInfoWithFilter1.License.IsActive)
            {
                MessageBox.Show("Selected License is not active ,Choose Another License Active  ", "Not Allowed",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueRepacement.Enabled = false;
                return;
            }

            btnIssueRepacement.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure you want to Replace the license?", "Confirm",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsLicense NewLicense;
                if (rbDamagedLicense.Checked)
                    NewLicense = ctrlDriverLicenseInfoWithFilter1.License.Replace(clsLicense.enIssueReason.DamagedReplacement, 1);
                else
                    NewLicense = ctrlDriverLicenseInfoWithFilter1.License.Replace(clsLicense.enIssueReason.LostReplacement, 1);

                if (NewLicense == null)
                {
                    MessageBox.Show("Failed to Replace the license", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NewLicenseID = NewLicense.LicenseID;
                lblReplaceLicenseID.Text = NewLicense.LicenseClassID.ToString();
                lblDLAppID.Text = NewLicense.ApplicaitonID.ToString();
                MessageBox.Show("License Renew Successfully with ID = " + NewLicense.LicenseID, "License Issued",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssueRepacement.Enabled = false;
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                llShowLicenseInfo.Enabled = true;
                gbReplacement.Enabled = false;
            }
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Replacement for Damaged License";
            lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.ReplaceDamgedDrivingLicense).ApplicationFees.ToString();

        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Replacement for Lost License";
            lblAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.ReplaceLostDrivingLicense).ApplicationFees.ToString();

        }
    }
}
