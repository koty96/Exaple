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
    public partial class FrmDetianLicenseApplication : Form
    {
        public FrmDetianLicenseApplication()
        {
            InitializeComponent();
        }

        private int  _DetainID;
        private int _SelectedLicenseID = -1;

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            llShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
            {
                return;
            }

            if(ctrlDriverLicenseInfoWithFilter1.License.IsLicenseDetaint)
            {
              MessageBox.Show("Selected License is already detained,Choose another one",
                  "Not Allowed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            lblLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.License.LicenseID.ToString();
            txtFineFees.Focus();
            btnDetain.Enabled = true;
            lblDetainID.Text = ctrlDriverLicenseInfoWithFilter1.License.DriverInfo.PersonID.ToString();


        }

        private void FrmDetianLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseFocus();

            lblDetainDate.Text = DateTime.Now.ToShortDateString();

            lblCreatedBy.Text = clsUser.FindByUserID(1).UserName;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            clsDetaintedLicense _DetainLicense = new clsDetaintedLicense();

            _DetainLicense.LicenseID = _SelectedLicenseID;
            _DetainLicense.CreatedByUserID = 1;
            _DetainLicense.fineFees = Convert.ToSingle(txtFineFees.Text);
            _DetainLicense.DetainDate = DateTime.Now;

            if(_DetainLicense.Save())
            {
                _DetainID = _DetainLicense.DetainID;
                MessageBox.Show("License Detainted Successfully with id = "+_DetainLicense.DetainID,
                    "License Issued",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Not Successfully = ",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
            txtFineFees.Enabled = false;

        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "You Should Enter Positive Number");
            }
            else
                e.Cancel = false;
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
            {
                btnDetain.PerformClick();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                (ctrlDriverLicenseInfoWithFilter1.License.DriverInfo.PersonID);

            frm.ShowDialog();
        }
    }
}
