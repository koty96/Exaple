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
    public partial class AddUpdateUserFrm : Form
    {
        public AddUpdateUserFrm()
        {

            Mode = enMode.AddNew;
            InitializeComponent();
        }

        public AddUpdateUserFrm(int UserID)
        {
            Mode = enMode.Update;
            this._UserID = UserID;
            InitializeComponent();
        }

        enum enMode { AddNew=0, Update=1};
        enMode Mode =enMode.AddNew;
        private int _PersonID=0;
        private int _UserID=0;
        clsUser _User;

        private void _ResetDefualtValues()
        {
            tabControl1.TabPages[1].Enabled = false;

            if (Mode==enMode.AddNew)
            {
                lblAddEditUser.Text = "Adding New User";
                //this.Text = "Adding New User";
                _User = new clsUser();
                
                
            }
            else
            {
                lblAddEditUser.Text = "Updating User ";
                this.Text = "Updating User ";

                tabPage2.Enabled = true;
                btnSave.Enabled = true;
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPssword.Text = "";
            checkBox1.Checked = true;

        }

        private void _LoadData()
        {
            if (Mode == enMode.Update)
            {
                lblAddEditUser.Text = "Updating Person ";
                _User = clsUser.FindByUserID(_UserID);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
            }

            if (_User == null)
            {
                MessageBox.Show("User Not Found Something is Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text= _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPssword.Text = _User.Password;
            checkBox1.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);


        }

        private void AddUpdateUserFrm_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (Mode == enMode.Update)
                _LoadData();

            /*tabControl1.TabPages[1].Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPssword.Enabled = false;*/

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tabControl1.TabPages[1].Enabled = true;
                tabControl1.SelectedIndex = 1;
                return;
            }

            if (_PersonID != -1)
            {
                if (clsUser.IsUserExistForPersonID(_PersonID))
                    MessageBox.Show("Selected Person already has a User,choose another one.", "Selected Another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    btnSave.Enabled = true;
                    tabControl1.TabPages[1].Enabled = true;
                    tabControl1.SelectedIndex = 1;
                 
                }
            }
            else
                MessageBox.Show("Please Select a Person","Select a Person",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
          _PersonID = obj;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field Are not valid!");
                return;
            }
            _User.PersonID = _PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = checkBox1.Checked;

            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                
                Mode = enMode.Update;
                lblAddEditUser.Text = "Update Person";
                this.Text = "Updaet Person";

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("error:Date Is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temb=sender as TextBox;

            if (string.IsNullOrEmpty(Temb.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temb, "This field is required!");
            }
            else
                errorProvider1.SetError(Temb, null);

            
        }

        private void txtConfirmPssword_Validating(object sender, CancelEventArgs e)
        {
             if(string.IsNullOrEmpty(txtConfirmPssword.Text.Trim()))
             {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPssword, "This field is required!");
             }
            if (txtConfirmPssword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPssword, "The Password not Confirmed");
            }
            else
                errorProvider1.SetError(txtConfirmPssword, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
