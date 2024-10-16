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
    public partial class FrmListTestAppointment : Form
    {
        private int _LocalDrivingLicenseID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicense;
        private DataTable _dtLicenseTestAppointment;
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;


        public FrmListTestAppointment(int _localdrivingLicenseID,clsTestTypes.enTestType TestTypeID)
        {
            _LocalDrivingLicenseID= _localdrivingLicenseID;
            _TestTypeID= TestTypeID;

            InitializeComponent();
        }


        private void _LoadTestTypeImageandTitle()
        {
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

        private void FrmListTestAppointment_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageandTitle();

            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByDrivingAppID
                (_LocalDrivingLicenseID);

            _dtLicenseTestAppointment=clsTestAppointment.
                GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseID,
                (int)_TestTypeID);

            dgvLicenseTestAppointments.DataSource = _dtLicenseTestAppointment;
            lblRecordCount.Text = dgvLicenseTestAppointments.Rows.Count.ToString();

            if(dgvLicenseTestAppointments.Rows.Count > 0 )
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseID);


            if (_LocalDrivingLicense.IsThereAnActiveScheduledTest((int)_TestTypeID))
            {
                MessageBox.Show("Person Aleady have an active appointment for this test," +
                    "You cannot add new appointment","Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmScheduleTest frm = new FrmScheduleTest
                (_LocalDrivingLicenseID, _TestTypeID,-1);
            frm.ShowDialog();

            FrmListTestAppointment_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScheduleTest frm = new FrmScheduleTest
                (_LocalDrivingLicenseID, _TestTypeID,
                (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            FrmListTestAppointment_Load(null, null);
        }
    }
}
