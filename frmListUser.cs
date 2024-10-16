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
    public partial class frmListUser : Form
    {
        public frmListUser()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllUsers;

        private void frmListUser_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAllUsers();
           dgvUserList.DataSource = _dtAllUsers;
            lblUserNumbers.Text=dgvUserList.Rows.Count.ToString();
            cmbFilterBy.SelectedIndex = 0;

            if (dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Columns[0].HeaderText = "User ID";
                dgvUserList.Columns[0].Width = 150;

                dgvUserList.Columns[1].HeaderText = "Person ID";
                dgvUserList.Columns[1].Width = 150;

                dgvUserList.Columns[2].HeaderText = "Full Name";
                dgvUserList.Columns[2].Width = 250;

                dgvUserList.Columns[3].HeaderText = "User Name";
                dgvUserList.Columns[3].Width = 150;

                dgvUserList.Columns[4].HeaderText = "Password";
                dgvUserList.Columns[4].Width = 150;

                dgvUserList.Columns[5].HeaderText = "Is Active";
                dgvUserList.Columns[5].Width = 150;

            }
        }


        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ItemName = "";
            switch (cmbFilterBy.Text)
            {
                case "User ID":
                    ItemName = "UserID";
                    break;
                case "User Name":
                    ItemName = "UserName";
                    break;
                case "Full Name":
                    ItemName = "FullName";
                    break;
                case "Person ID":
                    ItemName = "PersonID";
                    break;
                default:
                    ItemName = "None";
                    break;
            }

            if (ItemName == "None" || txtFilterValue.Text.Trim() == "")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblUserNumbers.Text = dgvUserList.Rows.Count.ToString();
                return;
            }
            if (ItemName == "PersonID")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", ItemName, txtFilterValue.Text.Trim());
            if (ItemName == "UserID")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", ItemName, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ItemName, txtFilterValue.Text.Trim());
            
            lblUserNumbers.Text = dgvUserList.Rows.Count.ToString();
        }

        private void cmActiveMode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";
            
            switch(cmActiveMode.Text)
            {
                case "All":
                    break;
                case "Yes":
                    FilterColumn = "1";
                    break;
                case "No":
                    FilterColumn = "0";
                    break;
            }

            if (cmActiveMode.Text == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}","IsActive" ,FilterColumn );

            lblUserNumbers.Text=_dtAllUsers.Rows.Count.ToString();

        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible= false;
                cmActiveMode.Visible = true;
                cmActiveMode.Focus();
                cmActiveMode.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cmbFilterBy.Text != "None" );
                cmActiveMode.Visible = false;
                        
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void cmActiveMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmActiveMode.Text)
            {

            }
        }


        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
           AddUpdateUserFrm frm = new AddUpdateUserFrm();
            frm.ShowDialog();
            frmListUser_Load(null, null);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateUserFrm frm = new AddUpdateUserFrm();
            frm.ShowDialog();

            frmListUser_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInformation frm = new frmUserInformation((int)dgvUserList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateUserFrm frm = new AddUpdateUserFrm((int)dgvUserList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListUser_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure You Want to Delete This User","Delete User",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvUserList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully", "Successfully",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListUser_Load(null, null);
                }
                else
                    MessageBox.Show("User Not Deleted", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword
                ((int)dgvUserList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        
    }
}
