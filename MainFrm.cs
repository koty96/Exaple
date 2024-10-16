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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();

        }

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
        "FirstName", "SecondName", "ThirdName", "LastName", "GendorCaption", "DateOfBirth",
        "NationalityCountryID", "Phone", "Email");



        private void _GetPeopleList()
        {
            dgvPeopleList.DataSource = _dtPeople;
            lblPeopleNumbers.Text = dgvPeopleList.RowCount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditFrm frm = new AddEditFrm();
            frm.ShowDialog();
            _GetPeopleList();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetails frm = new PersonDetails((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _GetPeopleList();

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            dgvPeopleList.DataSource = _dtPeople;
            cmbFilterBy.SelectedIndex = 0;
            lblPeopleNumbers.Text = _dtPeople.Rows.Count.ToString();

            if (dgvPeopleList.Rows.Count > 0)
            {
                dgvPeopleList.Columns[0].HeaderText = "Person ID";
                dgvPeopleList.Columns[0].Width = 110;

                dgvPeopleList.Columns[1].HeaderText = "National No.";
                dgvPeopleList.Columns[1].Width = 120;

                dgvPeopleList.Columns[2].HeaderText = "First Name";
                dgvPeopleList.Columns[2].Width = 120;

                dgvPeopleList.Columns[3].HeaderText = "Second Name";
                dgvPeopleList.Columns[3].Width = 120;

                dgvPeopleList.Columns[4].HeaderText = "Third Name";
                dgvPeopleList.Columns[4].Width = 120;

                dgvPeopleList.Columns[5].HeaderText = "Last Name";
                dgvPeopleList.Columns[5].Width = 120;

                dgvPeopleList.Columns[6].HeaderText = "Gender";
                dgvPeopleList.Columns[6].Width = 60;

                dgvPeopleList.Columns[7].HeaderText = "Date Of Birth";
                dgvPeopleList.Columns[7].Width = 120;

                dgvPeopleList.Columns[8].HeaderText = "Nationality";
                dgvPeopleList.Columns[8].Width = 120;

                dgvPeopleList.Columns[9].HeaderText = "Phone";
                dgvPeopleList.Columns[9].Width = 120;

                dgvPeopleList.Columns[10].HeaderText = "Email";
                dgvPeopleList.Columns[10].Width = 120;
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilerClumn = "";

            switch (cmbFilterBy.Text)
            {
                case "Person ID":
                    FilerClumn = "PersonID";
                    break;
                case "National No.":
                    FilerClumn = "NationalNo";
                    break;
                case "First Name":
                    FilerClumn = "FirstName";
                    break;
                case "Second Name":
                    FilerClumn = "SecondName";
                    break;

                case "Third Name":
                    FilerClumn = "ThirdName";
                    break;

                case "Last Name":
                    FilerClumn = "LastName";
                    break;

                case "Nationality":
                    FilerClumn = "CountryName";
                    break;

                case "Gendor":
                    FilerClumn = "GendorCaption";
                    break;

                case "Phone":
                    FilerClumn = "Phone";
                    break;

                case "Email":
                    FilerClumn = "Email";
                    break;

                default:
                    FilerClumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilerClumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblPeopleNumbers.Text = _dtPeople.Rows.Count.ToString();
            }

            if (FilerClumn == "PersonID")
            {
                int personID;
                if (int.TryParse(txtFilterValue.Text.Trim(), out personID))
                {
                    // For numeric filtering
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilerClumn, personID);
                }
            }
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilerClumn, txtFilterValue.Text.Trim());

            lblPeopleNumbers.Text = dgvPeopleList.Rows.Count.ToString();
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
            if (cmbFilterBy.Text == "Person ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
