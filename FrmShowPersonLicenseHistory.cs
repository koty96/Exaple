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
    public partial class FrmShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        public FrmShowPersonLicenseHistory(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        public FrmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }

        private void FrmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {

            if (_PersonID == -1)
            {
                ctrlPersonCardWithFilter1.FilterEnabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);

                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }

            
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;

            if(_PersonID == -1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
                ctrlDriverLicenses1.LoadInfoByPersonID(obj);
        }
    }
}
