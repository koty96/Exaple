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
    public partial class frmChangePassword : Form
    {
        private int UserID = -1;
        clsUser _User;

        public frmChangePassword(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
        }

        private void ResetDefulatValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtconfirmPassword.Text = "";
            txtCurrentPassword.Focus();
           

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ResetDefulatValues();

            _User=clsUser.FindByUserID(UserID);
            if(_User == null)
            {
                MessageBox.Show("Could not Find User with id = " + UserID, "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfo(UserID);
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "The Password is wrong");
                return;
            }
            else
                errorProvider1.SetError(txtCurrentPassword, null);

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "This field is required");
            }
            else
                errorProvider1.SetError(txtCurrentPassword, null);
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This field is required");
            }
            else
                errorProvider1.SetError(txtNewPassword, null);
        }

        private void txtconfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtconfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtconfirmPassword, "This field is required");
            }
            else
                errorProvider1.SetError(txtconfirmPassword, null);
            if (txtconfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtconfirmPassword, "The Password Not Currect");
            }
            else
                errorProvider1.SetError(txtconfirmPassword, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field Are not valid!");
                return;
            }
            _User.Password = txtconfirmPassword.Text;

            if(_User.Save())
            {
                MessageBox.Show("Password Changed Successfully","Saved.",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetDefulatValues();
            }
            else
                MessageBox.Show("An Erro occured","Password did not change.",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
