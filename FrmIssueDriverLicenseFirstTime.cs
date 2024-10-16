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
    public partial class FrmIssueDriverLicenseFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApp;
        clsLicense NewLicense;
        clsDriver Driver;
        public FrmIssueDriverLicenseFirstTime(int LocalDrivingLicenseApplicationID)
        {
            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            InitializeComponent();
        }

        private void ctrlDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApp == null )
            {
                MessageBox.Show("No Application With ID = "+ _LocalDrivingLicenseApplicationID,"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseID = _LocalDrivingLicenseApp.GetActiveLicenseID();
            if (LicenseID != -1)
            {
                MessageBox.Show("Person Already License Before with license id = "+LicenseID , "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByDrivingAppID(_LocalDrivingLicenseApplicationID);

            


        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = _LocalDrivingLicenseApp.IssueLicenseForTheFirstTime
                (txtNotes.Text.Trim(), 1);

            if(LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID, "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }

            else
            {
                MessageBox.Show("License Was Not Issued ! ", "Faild",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
