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
    public partial class FrmLocalDrivingLicenseApplicationInfo : Form
    {
        int _ApplicaitonID = -1;
        public FrmLocalDrivingLicenseApplicationInfo(int LocalDrivingID)
        {
            this._ApplicaitonID = LocalDrivingID;
            InitializeComponent();
        }

        private void Examplefrm_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByDrivingAppID(_ApplicaitonID);
        }
    }
}
