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
    public partial class FrmTakeTest : Form
    {
        private int _TestAppointmentID = -1;
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        clsTest _Test;
        
        public FrmTakeTest(int TestAppointmentID,clsTestTypes.enTestType TestTypeID)
        {
            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
            InitializeComponent();
        }

        private void FrmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestType = _TestTypeID;
            ctrlScheduledTest1.LoadInfo(_TestAppointmentID);

            if (ctrlScheduledTest1.TestAppointmentID == -1)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;

            int _TestID = ctrlScheduledTest1.TestID;

            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);
                if (_Test.TestResult == true)
                    rbPass.Checked = true;
                else
                    rbPass.Checked = true;

                rbPass.Enabled = false;
                rbFail.Enabled = false;

                txtNotes.Text = _Test.Notes;
                lblUserMessage.Visible = true;
            }
            else
                _Test = new clsTest();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                      "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
             )
            {
                return;
            }

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = 1;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
