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
    public partial class frmUdateApplicationTypes : Form
    {
        private int _ApplicationTypesID=-1;
        clsApplicationTypes _AppTypes;
        public frmUdateApplicationTypes(int ApplicationTypesID)
        {
            this._ApplicationTypesID = ApplicationTypesID;
            InitializeComponent();
        }

        private void LoadData()
        {
            txtTitle.Text = "";
            txtFees.Text = "";

            _AppTypes = clsApplicationTypes.Find(_ApplicationTypesID);
            if (_AppTypes != null )
            {
                lblAppTypesID.Text = _AppTypes.ApplicationTypesID.ToString();
                txtTitle.Text=_AppTypes.ApplicationTypeTitle.ToString();
                txtFees.Text=Convert.ToInt32(_AppTypes.ApplicationFees).ToString();
            }
            else
                MessageBox.Show("Not Successfully", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void frmUdateApplicationTypes_Load(object sender, EventArgs e)
        {
            //LoadData();
            lblAppTypesID.Text = _ApplicationTypesID.ToString();

            _AppTypes = clsApplicationTypes.Find(_ApplicationTypesID);
            if (_AppTypes != null)
            {
                txtTitle.Text = _AppTypes.ApplicationTypeTitle.ToString();
                txtFees.Text = Convert.ToInt32(_AppTypes.ApplicationFees).ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _AppTypes.ApplicationTypeTitle= txtTitle.Text;
            _AppTypes.ApplicationFees = Convert.ToSingle(txtFees.Text);

            if (_AppTypes.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Not Successfully", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
