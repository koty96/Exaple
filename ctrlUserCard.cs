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
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }

        private int _UserID = -1;

        public int UserID
        { get { return _UserID; } }

        clsUser _User;

        public clsUser User
        { get { return _User; } }

        private void ResetUserInfo()
        {
            ctrPersonCard1.ResetPersonInfo();
            lblUserID.Text = "";
            lblUserName.Text = "";
            lblIsActive.Text = "";
        }

        private void _FillUserInfo()
        {    
            ctrPersonCard1.LoadPesonInfo(_User.PersonID);
            _UserID = _User.UserID;
            lblUserName.Text = _User.UserName;
            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "NO";
            
        }

        public void LoadUserInfo(int userID)
        {
            _User = clsUser.FindByUserID(userID);
            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("No User With UserID = " + _User.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();
        }
    }
}
