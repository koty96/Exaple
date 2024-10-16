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
    public partial class frmUpdateTestFees : Form
    {
        private int _TestTypeID = -1;
        clsTestTypes _TestTypes;
        public frmUpdateTestFees(int TestTypeID)
        {
            _TestTypeID = TestTypeID;
            InitializeComponent();
        }

        private void frmUpdateTestFees_Load(object sender, EventArgs e)
        {
            lblTestTypesID.Text = _TestTypeID.ToString();

            _TestTypes = clsTestTypes.Find((clsTestTypes.enTestType)_TestTypeID);
            if (_TestTypes != null)
            {
                txtTitle.Text = _TestTypes.TestTypesTitle.ToString();
                txtDescription.Text= _TestTypes.TestTypesDescription.ToString();
                txtfees.Text=_TestTypes.TestTypesFees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestTypes.TestTypesTitle = txtTitle.Text;
            _TestTypes.TestTypesDescription = txtDescription.Text;
            _TestTypes.TestTypesFees = Convert.ToSingle(txtfees.Text);

            if (_TestTypes.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Not Successfully", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
