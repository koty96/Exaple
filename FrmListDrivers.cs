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
    public partial class FrmListDrivers : Form
    {
        public FrmListDrivers()
        {
            InitializeComponent();
        }

        private DataTable _dtDrivers = clsDriver.GetAllDrivers();

        private void FrmListDrivers_Load(object sender, EventArgs e)
        {
            cmbFilterBy.SelectedIndex = 0;
            dgvDriverList.DataSource = _dtDrivers;
            lblDriverNumbers.Text = dgvDriverList.Rows.Count.ToString();

            if(dgvDriverList.Rows.Count > 0 )
            {
                dgvDriverList.Columns[0].HeaderText = "Driver ID";
                dgvDriverList.Columns[0].Width = 150;

                dgvDriverList.Columns[1].HeaderText = "Person ID";
                dgvDriverList.Columns[1].Width = 150;

                dgvDriverList.Columns[2].HeaderText = "National NO.";
                dgvDriverList.Columns[2].Width = 115;

                dgvDriverList.Columns[3].HeaderText = "Full Name";
                dgvDriverList.Columns[3].Width = 250;

                dgvDriverList.Columns[4].HeaderText = "Date ";
                dgvDriverList.Columns[4].Width = 150;

                dgvDriverList.Columns[5].HeaderText = "Active Licenses ";
                dgvDriverList.Columns[5].Width = 130;
            }
        }

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
            string ItemName = "";
            switch (cmbFilterBy.Text)
            {
                case "Driver ID":
                    ItemName = "DriverID";
                    break;
                case "Person ID":
                    ItemName = "PersonID";
                    break;
                case "National No.":
                    ItemName = "NationalNo";
                    break;
                case "Full Name":
                    ItemName = "FullName";
                    break;
       
                default:
                    ItemName = "None";
                    break;
            }

            if (ItemName == "None" || txtFilterValue.Text.Trim() == "")
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lblDriverNumbers.Text = dgvDriverList.Rows.Count.ToString();
                return;
            }
            if (ItemName == "PersonID" || ItemName == "DriverID")
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", ItemName, txtFilterValue.Text.Trim());
/*            if (ItemName == "DriverID")
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", ItemName, txtFilterValue.Text.Trim());*/
            else
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ItemName, txtFilterValue.Text.Trim());

            lblDriverNumbers.Text = dgvDriverList.Rows.Count.ToString();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
                txtFilterValue.Visible = (cmbFilterBy.SelectedItem != "None");
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetails frm = new PersonDetails
                ((int)dgvDriverList.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowPersonLicenseHistory frm = new
                FrmShowPersonLicenseHistory((int)dgvDriverList.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
