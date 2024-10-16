using DVLD_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private int _LicenseID = -1;
        clsLicense _License;

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicense License
            { get { return _License; } }

        public void LoadLicenseInfo(int  licenseID)
        {
            _LicenseID = licenseID;
            _License = clsLicense.Find(_LicenseID);

            if(_License ==null)
            {
                MessageBox.Show("No License with ID = " + _LicenseID,"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            lblClass.Text = _License.LicenseClassInfo.ClassName;
            lblName.Text = _License.DriverInfo.PersonInfo.FullName();
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo.ToString();
            lblGender.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblEmail.Text = _License.DriverInfo.PersonInfo.Email;
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = _License.Notes == "" ? "Not Notes Yet" : _License.Notes;
            lblIsActive.Text = _License.IsActive == true ? "Yes" : "No";
            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblIsDetained.Text = _License.IsLicenseDetaint ? "Yes" : "NO";

            _LoadPersonImage();

        }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
                pictureBox1.Image = Properties.Resources.Male_512;
            else
                pictureBox1.Image = Properties.Resources.Female_512;

            if (_License.DriverInfo.PersonInfo.ImagePath != null)
                File.Exists(_License.DriverInfo.PersonInfo.ImagePath);
                pictureBox1.ImageLocation = _License.DriverInfo.PersonInfo.ImagePath;
        }
    }
}
