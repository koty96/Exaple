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
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private clsApplication _Application;
        public clsApplication Application
            { get { return _Application; } }
        
        int _ApplicationID = -1;

        public int ApplicationID
        { get { return _ApplicationID; } }
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.FindBaseApplicaiton(ApplicationID);

            if(_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application With ApplicationID = " + _ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillApplicationInfo();
        }

        public void ResetApplicationInfo()
        {
            lblAppID.Text = "[???]";
            lblStatus.Text = "[???]";
            lblFees.Text = "[???]";
            lblType.Text = "[???]";
            lblApplicant.Text = "[???]";
            lblDate.Text = "[???]";
            lblStatusDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        private void _FillApplicationInfo()
        {
            lblAppID.Text = _Application.ApplicaitonID.ToString();
            lblStatus.Text=_Application.StausText;
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.ApplicationTypeTitle;
            lblApplicant.Text = _Application.ApplicationFullName;
            lblDate.Text=_Application.ApplicationDate.ToShortDateString();
            lblStatusDate.Text=_Application.LastStatusDate.ToShortDateString();
            lblCreatedBy.Text=_Application.UserInfo.UserName;
        }

        private void lnkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditFrm frm = new AddEditFrm(_Application.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
