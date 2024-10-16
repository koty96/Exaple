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
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private static DataTable _dtLocalDrivingLicense;

        private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtLocalDrivingLicense=clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplication();

            dgvLocalDrivingList.DataSource= _dtLocalDrivingLicense;
            lblLocalLicenseNumbers.Text=dgvLocalDrivingList.Rows.Count.ToString();
            cmbFilterBy.SelectedIndex = 0;

            if(dgvLocalDrivingList.Rows.Count !=0)
            {
                dgvLocalDrivingList.Columns[0].HeaderText = "LD.LAppID";
                dgvLocalDrivingList.Columns[0].Width= 100;

                dgvLocalDrivingList.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingList.Columns[1].Width = 250;

                dgvLocalDrivingList.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingList.Columns[2].Width = 108;

                dgvLocalDrivingList.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingList.Columns[3].Width = 350;

                dgvLocalDrivingList.Columns[4].HeaderText = "Applicaiton Data";
                dgvLocalDrivingList.Columns[4].Width = 100;

                dgvLocalDrivingList.Columns[5].HeaderText = "Passed Test";
                dgvLocalDrivingList.Columns[5].Width = 100;

                dgvLocalDrivingList.Columns[6].HeaderText = "Status";
                dgvLocalDrivingList.Columns[6].Width = 100;

            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ItemName = "";
            switch (cmbFilterBy.Text)
            {
                case "LD.LAppID":
                    ItemName = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    ItemName = "NationalNo";
                    break;

                case "Full Name":
                    ItemName = "FullName";
                    break;

                case "Status":
                    ItemName = "Status";
                    break;

                default:
                    ItemName = "None";
                    break;
            }
            if (ItemName == "None" || txtFilterValue.Text.Trim() == "")
            {
                _dtLocalDrivingLicense.DefaultView.RowFilter = "";
                lblLocalLicenseNumbers.Text = 
                    _dtLocalDrivingLicense.Rows.Count.ToString();
                return;
            }

            if (ItemName == "LocalDrivingLicenseApplicationID")
                _dtLocalDrivingLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", ItemName, txtFilterValue.Text.Trim());

            else
                _dtLocalDrivingLicense.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ItemName, txtFilterValue.Text.Trim());

            lblLocalLicenseNumbers.Text = dgvLocalDrivingList.Rows.Count.ToString();

        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cmbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "LD.LAppID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
              frmNewLocalDrivingLicense frm =new frmNewLocalDrivingLicense();
               frm.ShowDialog();
            frmListLocalDrivingLicenseApplications_Load(null, null);
        }

        private void showApplicationDetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicense frm = new frmNewLocalDrivingLicense
                ((int)dgvLocalDrivingList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicenseApplications_Load(null, null);
        }

        private void showApplicaitonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenseApplicationInfo frm = new FrmLocalDrivingLicenseApplicationInfo
                ((int)dgvLocalDrivingList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You Want to Delete This Application", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.
                    DeleteLocalDrivingLicenseApplication
                    ((int)dgvLocalDrivingList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Deleted Successfully", "Successfully",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicenseApplications_Load(null, null);
                }
                else
                    MessageBox.Show("Application Not Deleted", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You Want to Cancel This Application", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
            {
                int LocalDrivingID = ((int)dgvLocalDrivingList.CurrentRow.Cells[0].Value);
                clsLocalDrivingLicenseApplication local = clsLocalDrivingLicenseApplication.Find(LocalDrivingID);
                if (local.ApplicationStatus==clsApplication.enApplicationStatus.New)
                {
                    local.Cancel();
                    MessageBox.Show("Application Cancel Successfully", "Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicenseApplications_Load(null, null);
                }
                else

                    MessageBox.Show("Application Not cancelled because " +
                    "status applicaiton already cancel or completed", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
