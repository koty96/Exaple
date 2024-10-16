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
    public partial class ctrlScheduledTest : UserControl
    {
        public ctrlScheduledTest()
        {
            InitializeComponent();
        }

        private clsTestTypes.enTestType _TestTypeID;

        public clsTestTypes.enTestType TestType
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;
                switch (_TestTypeID)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        pcTestType.Image = Properties.Resources.Vision_512;
                        gbTestType.Text = "Vision Test";
                        break;

                    case clsTestTypes.enTestType.writtenTest:
                        pcTestType.Image = Properties.Resources.Written_Test_512;
                        gbTestType.Text = "Written Test";
                        break;

                    case clsTestTypes.enTestType.StreetTest:
                        pcTestType.Image = Properties.Resources.driving_test_512;
                        gbTestType.Text = "Street Test";
                        break;
                }
            }
        }

        private int _TestID;

        public int TestID
        { get { return _TestID; } }

        public int TestAppointmentID
            { get { return _TestID; } }

        private int _TestAppointmentID = -1;


        private int _LocalDrivingLicenesApplicaitonID = -1;
        clsTestAppointment _TestAppointment;

        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;

            _TestAppointment = clsTestAppointment.FindByTestAppointmentID(_TestAppointmentID);
            if(_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _TestID= _TestAppointment.TestID;

            _LocalDrivingLicenesApplicaitonID = _TestAppointment.LocalDrivingLicenseApplicationID;

            clsLocalDrivingLicenseApplication _LocalDrvingLicenseApp =
                clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenesApplicaitonID);

            if( _LocalDrvingLicenseApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenesApplicaitonID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDLAppID.Text= _LocalDrvingLicenseApp.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingclass.Text = _LocalDrvingLicenseApp.LicenseClass.ClassName;
            lblFullName.Text = _LocalDrvingLicenseApp.ApplicationFullName;
            lblTrail.Text = _LocalDrvingLicenseApp.TotalTrailPerTest((int)_TestID).ToString();
            lblDate.Text = _TestAppointment.AppointmentDate.ToShortDateString();
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTestID.Text = (_TestID == -1) ? "Not Taken Yet" :_TestAppointment.TestID.ToString();

        }


    }
}
