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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {

        private clsLocalDrivingLicenseApplication _LocalDrivingLicense;

        public clsLocalDrivingLicenseApplication LocalDrivingLicense
        {
            get { return _LocalDrivingLicense;}

        }

         private int _LocalDrivingLicenseID = -1;

        public int LocalDrivingLicenseID
        { get { return _LocalDrivingLicenseID; } }

        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfoByDrivingAppID(int localDrivingLicenseID)
        {
            _LocalDrivingLicenseID = localDrivingLicenseID;
            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.Find(localDrivingLicenseID);
            if(_LocalDrivingLicense == null)
            {
                ResetLocalDrivingLicense();
                MessageBox.Show("No Application With ApplicationID = " + _LocalDrivingLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicense();
        }

        public void LoadApplicaotinInfobyApplicatoinID(int ApplicationID)
        {
            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.FindByApplicationID
                (ApplicationID);
            if (_LocalDrivingLicense == null)
            {
                ResetLocalDrivingLicense();
                MessageBox.Show("No Application With ApplicationID = " + _LocalDrivingLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicense();
        }

        private void ResetLocalDrivingLicense()
        {
            _LocalDrivingLicenseID = -1;
            lblDLAppID.Text = "[???]";
            lblAppliedFor.Text = "[???]";
            ctrlApplicationBasicInfo1.ResetApplicationInfo();

        }

        private void _FillLocalDrivingLicense()
        {
            lblDLAppID.Text = _LocalDrivingLicense.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedFor.Text = clsLicenseClass.Find(_LocalDrivingLicense.LicenseClassID).ClassName;
            lblPassedTests.Text = clsTest.GetPassedTestCount(LocalDrivingLicenseID).ToString() + "/3";
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicense.ApplicaitonID);

        }


        
    }
}
