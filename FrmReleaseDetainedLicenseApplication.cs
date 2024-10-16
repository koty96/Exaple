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
    public partial class FrmReleaseDetainedLicenseApplication : Form
    {
        public FrmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
        }

        public FrmReleaseDetainedLicenseApplication(int LicenseID)
        {
            _SelectedLicenseID = LicenseID;
            InitializeComponent();

            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private int _SelectedLicenseID = -1;
        private int _DetainedLicenseID = -1;
        private void FrmReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseFocus();

            lblCreatedBy.Text = clsUser.FindByUserID(1).UserName;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
            {
                return;
            }

            if (!ctrlDriverLicenseInfoWithFilter1.License.IsLicenseDetaint)
            {
                MessageBox.Show("Selected License is already Not detained,Choose another one",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            lblLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.License.LicenseID.ToString();
            lblDetainID.Text = ctrlDriverLicenseInfoWithFilter1.License.DetainedInfo.DetainID.ToString();
            lblDetainDate.Text = ctrlDriverLicenseInfoWithFilter1.License.DetainedInfo.DetainDate.ToShortDateString();
            lblApplicationFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.ReleasedDetainedDrivingLicense).ApplicationFees.ToString();
            lblFineFees.Text = ctrlDriverLicenseInfoWithFilter1.License.DetainedInfo.fineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();
            btnDetain.Enabled = true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            int ApplicationID = 1;
            if (ctrlDriverLicenseInfoWithFilter1.License.
                ReleaseDetaintedLicense(1, ref ApplicationID))
            {
                lblApplicationID.Text = ApplicationID.ToString();
                MessageBox.Show("Detained License released Successfully",
                    "Detained License Released", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show("Not Successfully","Failed", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);

            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowDriverLicenseInfo frm =
                new FrmShowDriverLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowPersonLicenseHistory frm = new
                FrmShowPersonLicenseHistory
                ((int)ctrlDriverLicenseInfoWithFilter1.License.DriverInfo.PersonID);

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
