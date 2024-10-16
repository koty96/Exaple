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
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicesneID)
        {
            Action<int> Handler = OnLicenseSelected;
            if (Handler != null)
                Handler(LicenseID);
        }



        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                gpFilter.Enabled = _FilterEnabled;

            }
        }

        private int _LicenseID = -1;
        public int LicenseID
        {
            get { return ctrlDriverLicenseInfo1.LicenseID; }
        }

        public clsLicense License
        {
            get { return ctrlDriverLicenseInfo1.License; }
        }

        private void FindNow()
        {
            ctrlDriverLicenseInfo1.LoadLicenseInfo(int.Parse(txtFilterValue.Text));

            if (OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(ctrlDriverLicenseInfo1.LicenseID);
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtFilterValue.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadLicenseInfo(LicenseID);
            _LicenseID = ctrlDriverLicenseInfo1.LicenseID;

            if (OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(_LicenseID);

        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This Field is requird");

            }
            else
                errorProvider1.SetError(txtFilterValue, null);
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Thing Error ", "Error");
                return;
            }
            _LicenseID = int.Parse(txtFilterValue.Text.Trim());
            LoadLicenseInfo(_LicenseID);
        }

        public void txtLicenseFocus()
        {
            txtFilterValue.Focus();
        }

        private void ctrlDriverLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {
           txtLicenseFocus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if(e.KeyChar == (char)13)
            {
                btnsearch.PerformClick();
            }
        }
    }
}
