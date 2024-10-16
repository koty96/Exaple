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
    public partial class FrmListDetainedLisense : Form
    {
        public FrmListDetainedLisense()
        {
            InitializeComponent();
        }

        private DataTable _dtDetainedLicense;

        private void FrmListDetainedLisense_Load(object sender, EventArgs e)
        {
            _dtDetainedLicense = clsDetaintedLicense.GetAllDetainedLicense();

            cmbFilterBy.SelectedIndex = 0;
            dgvDetainedLiceseList.DataSource = _dtDetainedLicense;
            lblDetainLicenseNumbers.Text = dgvDetainedLiceseList.Rows.Count.ToString();

            if(dgvDetainedLiceseList.Rows.Count > 0)
            {
                dgvDetainedLiceseList.Columns[0].HeaderText = "D.ID";
                dgvDetainedLiceseList.Columns[0].Width = 80;

                dgvDetainedLiceseList.Columns[1].HeaderText = "L.ID";
                dgvDetainedLiceseList.Columns[1].Width = 80;

                dgvDetainedLiceseList.Columns[2].HeaderText = "D.Date";
                dgvDetainedLiceseList.Columns[2].Width = 120;

                dgvDetainedLiceseList.Columns[3].HeaderText = "Is Released";
                dgvDetainedLiceseList.Columns[3].Width = 100;

                dgvDetainedLiceseList.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLiceseList.Columns[4].Width = 150;

                dgvDetainedLiceseList.Columns[5].HeaderText = "Release Date";
                dgvDetainedLiceseList.Columns[5].Width = 120;

                dgvDetainedLiceseList.Columns[6].HeaderText = "N.No";
                dgvDetainedLiceseList.Columns[6].Width = 80;

                dgvDetainedLiceseList.Columns[7].HeaderText = "Full Name";
                dgvDetainedLiceseList.Columns[7].Width = 210;

                dgvDetainedLiceseList.Columns[8].HeaderText = "Release App.ID";
                dgvDetainedLiceseList.Columns[8].Width = 120;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ItemName;

            switch(cmbFilterBy.Text)
            {
                case "Detain ID":
                    ItemName = "DetainID";
                    break;


                case "National No.":
                    ItemName = "NationalNo";
                    break;

                case "Full Name":
                    ItemName = "FullName";
                    break;

                case "Release Application ID":
                    ItemName = "ReleaseApplicationID";
                    break;

                default:
                    ItemName = "None";
                    break;
            }

            if (ItemName == "None" || txtFilterValue.Text.Trim() == "")
            {
                _dtDetainedLicense.DefaultView.RowFilter = "";
                lblDetainLicenseNumbers.Text = dgvDetainedLiceseList.Rows.Count.ToString();
                return;
            }

            if (ItemName == "DetainID" || ItemName== "ReleaseApplicationID")
                _dtDetainedLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", ItemName, txtFilterValue.Text.Trim());

            else
                _dtDetainedLicense.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ItemName, txtFilterValue.Text.Trim());

            lblDetainLicenseNumbers.Text = dgvDetainedLiceseList.Rows.Count.ToString();        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "Is Released")
            {
                txtFilterValue.Visible = false;
                cmReleaseMode.Visible = true;
                cmReleaseMode.Focus();
                cmReleaseMode.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cmbFilterBy.Text != "None");
                cmReleaseMode.Visible = false;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void cmReleaseMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string FilterColumn = "";

            switch (cmReleaseMode.Text)
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

            if (cmReleaseMode.Text == "All")
                _dtDetainedLicense.DefaultView.RowFilter = "";
            else
                _dtDetainedLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsReleased", FilterColumn);

            lblDetainLicenseNumbers.Text = dgvDetainedLiceseList.Rows.Count.ToString();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            FrmReleaseDetainedLicenseApplication frm = new FrmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
            FrmListDetainedLisense_Load(null, null);
        }

        private void btnDetainedLicense_Click(object sender, EventArgs e)
        {
            FrmDetianLicenseApplication frm = new FrmDetianLicenseApplication();
            frm.ShowDialog();
            FrmListDetainedLisense_Load(null, null);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicense license = clsLicense.Find((int)dgvDetainedLiceseList.CurrentRow.Cells[1].Value);
            PersonDetails frm = new PersonDetails(license.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDriverLicenseInfo frm = new FrmShowDriverLicenseInfo
                ((int)dgvDetainedLiceseList.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLiceseList.CurrentRow.Cells[1].Value;
            int personID = clsLicense.Find(LicenseID).DriverInfo.PersonID;
            FrmShowPersonLicenseHistory frm = new FrmShowPersonLicenseHistory
                (personID);
            frm.ShowDialog();
        }

        private void PageReleaseDetaiLicesne_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLiceseList.CurrentRow.Cells[1].Value;

                FrmReleaseDetainedLicenseApplication frm = 
                new FrmReleaseDetainedLicenseApplication(LicenseID);
                frm.ShowDialog();
                FrmListDetainedLisense_Load(null, null);

            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            PageReleaseDetaiLicesne.Enabled = !(bool)dgvDetainedLiceseList.CurrentRow.Cells[3].Value;
        }
    }
}
