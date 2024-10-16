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
    public partial class frmNewLocalDrivingLicense : Form
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;

        int _PersonID = 0;
        int _LocalDrivingLicenseID= 0;
        clsLocalDrivingLicenseApplication _LocalDrivingLicense;

        public frmNewLocalDrivingLicense()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmNewLocalDrivingLicense(int LocalDrivingLicenseID)
        {
            this._LocalDrivingLicenseID = LocalDrivingLicenseID;
            Mode = enMode.Update;
            InitializeComponent();
        }

        private void _FillComboBoxLicenseClass()
        {
            DataTable dataTable = clsLicenseClass.GetAllLicenseClasss();

            foreach (DataRow item in dataTable.Rows)
            {
                cbLicenseClass.Items.Add(item["ClassName"]);
            }
        }
        private void _LoadData()
        {
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseID);
            if(_LocalDrivingLicense == null)
            {
                MessageBox.Show("No Application with ID= " +_LocalDrivingLicense,
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicense.ApplicantPersonID);
            lblDVAppID.Text = _LocalDrivingLicense.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text=_LocalDrivingLicense.ApplicationDate.ToShortDateString();
            //lblCreatedBy.Text=_LocalDrivingLicense.UserInfo.UserName;
            lblCreatedBy.Text = "Mamdouh";
            lblApplicaitonFees.Text=_LocalDrivingLicense.PaidFees.ToString();
            cbLicenseClass.SelectedIndex =cbLicenseClass.FindString(_LocalDrivingLicense.LicenseClass.ClassName);

         }

        private void _ResetDefaultValue()
        {
            _FillComboBoxLicenseClass();

            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Adding New Local Driving Licesne Application";
                this.Text = "Adding New Local Driving Licesne Application";
                tpApplicatoinInfo.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
                cbLicenseClass.SelectedIndex = 2;

                _LocalDrivingLicense = new clsLocalDrivingLicenseApplication();
                lblApplicationDate.Text= DateTime.Now.ToShortDateString();
                lblCreatedBy.Text = "Mamdouh";
                lblApplicaitonFees.Text= clsApplicationTypes.Find((int)clsApplication.enApplicaitonType.NewDrivingLicense).ApplicationFees.ToString();
            }
            else
            {
                lblTitle.Text = "Update Local Driving Licesne Application";
                this.Text = "Update Local Driving Licesne Application";
                btnSave.Enabled = true;
                tpApplicatoinInfo.Enabled = true;
            }


        }

        private void frmNewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
            if(Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tcNewLocalDriving.SelectedIndex = 1;
                tpApplicatoinInfo.Enabled = true;
            }


            if (ctrlPersonCardWithFilter1.PersonID != -1) 
            {
                btnSave.Enabled = true;
                tcNewLocalDriving.SelectedIndex = 1;
                tpApplicatoinInfo.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("You Should Choose person First", "Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseClass = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;

            int ActiveApplication = clsApplication.GetActiveApplicationIDForLicenseClass
                (_PersonID, clsApplication.enApplicaitonType.NewDrivingLicense, LicenseClass);

            if (ActiveApplication != -1)
            {
                MessageBox.Show("Choose Another Licese Class,The Selected Person Already Exist",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsLicenseClass.IsLicenseClassExistByPersonID
                (ctrlPersonCardWithFilter1.PersonID, LicenseClass))
            {
                MessageBox.Show("Person already  Have Licesne with the same applied driving License",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _LocalDrivingLicense.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonID;
            _LocalDrivingLicense.CreatedByUserID = 1;
            _LocalDrivingLicense.LicenseClassID = LicenseClass;
            _LocalDrivingLicense.LastStatusDate = DateTime.Now;
            _LocalDrivingLicense.ApplicationDate = DateTime.Now;
            _LocalDrivingLicense.ApplicationTypeID = 1;
            _LocalDrivingLicense.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicense.PaidFees = Convert.ToSingle(lblApplicaitonFees.Text);

            if (_LocalDrivingLicense.Save())        
            {
                Mode = enMode.Update;
                lblDVAppID.Text = _LocalDrivingLicense.LocalDrivingLicenseApplicationID.ToString();
                MessageBox.Show("Data Saved Successfully", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
        }

        private void frmNewLocalDrivingLicense_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}
