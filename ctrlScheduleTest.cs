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
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule = 0, ReTakeTestSchedule = 1 }
        enCreationMode CreationMode = enCreationMode.FirstTimeSchedule;

        public ctrlScheduleTest()
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
                switch(_TestTypeID)
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

        clsLocalDrivingLicenseApplication _LocalDrivingLicense;

        private int _LocalDrivingLicenseAppID = -1;

        clsTestAppointment _TestAppointment;

        private int _TestAppointmentID = -1;


        public void LoadInfo(int LocalDrivingLicenseID, int TestAppointmentID = -1)
        {
             if (TestAppointmentID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;

            
            this._LocalDrivingLicenseAppID= LocalDrivingLicenseID;
            this._TestAppointmentID= TestAppointmentID;
            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicense==null)
            {
                MessageBox.Show("Error: No Local Driving License Applicaiton with ID " + _LocalDrivingLicenseAppID,
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (_LocalDrivingLicense.DoesAttendTestType((int)_TestTypeID))

                CreationMode = enCreationMode.ReTakeTestSchedule;
            else
                CreationMode = enCreationMode.FirstTimeSchedule;



            if(CreationMode==enCreationMode.ReTakeTestSchedule)
            {
                lblRAppFees.Text = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.ReTakeTest).ApplicationFees.ToString();
                lblTitle.Text = "Schedule ReTake Test";
                gbRetakeTest.Enabled = true;
                lblReTestAppID.Text = "0";
            }
            else
            {
                lblTitle.Text = "Schedule Test";
                lblRAppFees.Text = "0";
                lblReTestAppID.Text = "N/A";
                gbRetakeTest.Enabled = false;
            }
            
            lblDLAppID.Text=_LocalDrivingLicense.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingclass.Text = _LocalDrivingLicense.LicenseClass.ClassName;
            lblFullName.Text = _LocalDrivingLicense.ApplicationFullName;

            lblTrail.Text=_LocalDrivingLicense.TotalTrailPerTest((int)_TestTypeID).ToString();

            if (Mode == enMode.AddNew) 
            {
                dtDate.Value = DateTime.Now;
                lblReTestAppID.Text = "N/A";
                lblFees.Text = clsTestTypes.Find(_TestTypeID).TestTypesFees.ToString();

                _TestAppointment = new clsTestAppointment();
                
            }
            else
            {
                 if(!_LoadTestAppointmentData())
                    return;
            }

            lblTotalFees.Text = Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRAppFees.Text).ToString();

            if(!_handleActiveAppointmentConstraint())
                return; 
            
            if(!_HandleAppointmentLockedConstraint())
                return; 
            
            if(!_HandlePreviousTestConstraint())
                return;


        }

        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.FindByTestAppointmentID(_TestAppointmentID);

            if(_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointemnt With ID = " + _TestAppointmentID
                    , "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtDate.MinDate = DateTime.Now;
            else
                dtDate.MinDate = _TestAppointment.AppointmentDate;

            lblFees.Text=_TestAppointment.PaidFees.ToString();

            if(_TestAppointment.RetakeTestApplicationID !=-1)
            {
                gbRetakeTest.Enabled = true;
                lblReTestAppID.Text=_TestAppointment.RetakeTestApplicationID.ToString();
                lblTitle.Text = "Schedule ReTake Test"; 
            }
            else
            {
                lblRAppFees.Text = "0";
                lblReTestAppID.Text = "N/A";
            }
            return true;

        }

        private bool _handleActiveAppointmentConstraint()
        {
            if(Mode==enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest
                (_LocalDrivingLicenseAppID, _TestAppointmentID))
            {
                btnSave.Enabled = false;
                lblUserMessage.Text = "Person Already have a active appoinment for this Test";
                lblUserMessage.Visible = true;
                dtDate.Enabled = false;
                return false;
            }
            lblUserMessage.Visible = false;
            return true;
        }

        private bool _HandleAppointmentLockedConstraint()
        {
            if(_TestAppointment.IsLocked)
            {
                btnSave.Enabled = false;
                lblUserMessage.Text = "Person Already sat for the test ";
                lblUserMessage.Visible = true;
                dtDate.Enabled = false;
                return false;
            }
            else
                lblUserMessage.Visible = false;
            return true;
        }

        private bool _HandlePreviousTestConstraint()
        {
            switch(_TestTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    lblUserMessage.Visible = false;
                    return true;

                case clsTestTypes.enTestType.writtenTest:
                    if(_LocalDrivingLicense.DoesPassedTestType((int)clsTestTypes.enTestType.VisionTest))
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtDate.Enabled = true;
                        return true;
                    }
                    else
                    {
                        lblUserMessage.Text = "Cann't Schedule ,Vision test should be passed";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtDate.Enabled = false;
                        return false;
                    }

                case clsTestTypes.enTestType.StreetTest:
                    if (_LocalDrivingLicense.DoesPassedTestType((int)clsTestTypes.enTestType.writtenTest))
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtDate.Enabled = true;
                        return true;
                    }
                    else
                    {
                        lblUserMessage.Text = "Cann't Schedule ,Street test should be passed";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtDate.Enabled = false;
                        return false;
                    }
            }
            return false;

        }

        private bool _HandleTestAppointmentForSave()
        {
            if (Mode == enMode.AddNew && CreationMode == enCreationMode.ReTakeTestSchedule)
            {
                clsApplication _RetakeApp = new clsApplication();

                _RetakeApp.ApplicantPersonID = _LocalDrivingLicense.ApplicantPersonID;
                _RetakeApp.ApplicationDate = DateTime.Now;
                _RetakeApp.ApplicationTypeID = (int)clsApplication.enApplicaitonType.ReTakeTest;
                _RetakeApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                _RetakeApp.LastStatusDate = DateTime.Now;
                _RetakeApp.PaidFees = clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.ReTakeTest).ApplicationFees;
                _RetakeApp.CreatedByUserID = 1;

                if(!_RetakeApp.Save())
                {
                    MessageBox.Show("Faild to create application ", "Faild",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _RetakeApp.ApplicaitonID = -1;
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = _RetakeApp.ApplicaitonID;
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleTestAppointmentForSave())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseAppID;
            _TestAppointment.AppointmentDate = dtDate.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lblFees.Text);
            _TestAppointment.CreatedByTestAppointmentID = 1;

            if(_TestAppointment.Save())
            {
                Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data is Not saved Successfully ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
    }
}
