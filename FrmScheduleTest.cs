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
    public partial class FrmScheduleTest : Form
    {
        private int _LocalDrivingLicenseID = -1, _TestAppoinmentID = -1;
        private clsTestTypes.enTestType TesttypeID = clsTestTypes.enTestType.VisionTest;

        public FrmScheduleTest(int LocalDrivingLIcenseID,clsTestTypes.enTestType TestTypeID,int TestAppoinmentID)
        {
            this.TesttypeID = TestTypeID;
            this._LocalDrivingLicenseID = LocalDrivingLIcenseID;
            this._TestAppoinmentID = TestAppoinmentID;
            InitializeComponent();
        }

                      
        private void FrmScheduleTest_Load_1(object sender, EventArgs e)
        {
            ctrlScheduleTest1.TestType = TesttypeID;
            ctrlScheduleTest1.LoadInfo(_LocalDrivingLicenseID, _TestAppoinmentID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
