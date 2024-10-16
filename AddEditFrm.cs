using DVLD_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddEditFrm : Form
    {
        public delegate void DataBackEventHandler(object sender, int personID);

        public event DataBackEventHandler Databack;
        public enum enMode { AddNew=0, Update=1 }
        public enMode Mode = enMode.AddNew;

        clsPerson _Person;
        int PersonID = 0;
        public AddEditFrm()
        {
            InitializeComponent();
            Mode= enMode.AddNew;
            _FillcbCountries();

        }

        public AddEditFrm(int PersonID)
        {
            this.PersonID = PersonID;
            InitializeComponent();
            Mode = enMode.Update;
        }

        private void _FillcbCountries()
        {
            DataTable dt=clsCountry.GetAllCountries();

            foreach(DataRow dr in dt.Rows)
            {
                cbCountries.Items.Add(dr["countryName"]);
            }
        }

        private void _ResetDefualtValues()
        {
            _FillcbCountries();
            cbCountries.SelectedItem = "Jordan";
            if(Mode==enMode.AddNew)
            {
                lblAddEditPerson.Text = "Adding New User";
                _Person = new clsPerson();

            }

            dateTimePicker2.MaxDate  = DateTime.Now.AddYears(-18);
            dateTimePicker2.MinDate = DateTime.Now.AddYears(-100);

            if (rdbMale.Checked)
                pictureBox1.Image = Properties.Resources.Male_512;
            else
                pictureBox1.Image= Properties.Resources.Female_512;

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationNo.Text = "";
            dateTimePicker2.Value = dateTimePicker2.MaxDate;
            rdbFemale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

        }

        private void LoadData()
        {
            if(Mode == enMode.Update)
            {
                lblAddEditPerson.Text = "Updating Person ";
                _Person = clsPerson.Find(PersonID);
            }
            if(_Person == null)
            {
                MessageBox.Show("Person Not Found Something is Error","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            cbCountries.Text = _Person.CountryInfo.CountryName;
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text= _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text= _Person.Email;
            txtNationNo.Text = _Person.NationalNo;
            dateTimePicker2.Value = _Person.DateOfBirth;
            if(_Person.Gendor==0)
            {
                pictureBox1.Image = Properties.Resources.Male_512;
                rdbMale.Checked = true;
            }    
            else
            {
                pictureBox1.Image = Properties.Resources.Female_512;
                rdbFemale.Checked = true;
            }
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;

            if(_Person.ImagePath!="")
                pictureBox1.ImageLocation = _Person.ImagePath;
            linkLabel_RemoveImage.Visible = (_Person.ImagePath != "");



        }

        private void AddEditFrm_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if(Mode== enMode.Update)
                LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == null)
                pictureBox1.Image= Properties.Resources.Male_512;

        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == null)
                pictureBox1.Image = Properties.Resources.Female_512;
        }

        private void linkLabel_RemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            if (rdbMale.Checked)
                pictureBox1.Image = Properties.Resources.Male_512;
            else
                pictureBox1.Image = Properties.Resources.Female_512;
            linkLabel_RemoveImage.Visible = false;
            _Person.ImagePath = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ImagePath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = ImagePath;
                linkLabel_RemoveImage.Visible = true;
            }
            

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtNationNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationNo, "This field is required!");

            }
            else
            {
                errorProvider1.SetError(txtNationNo, null);
            }

            if (txtNationNo.Text != _Person.NationalNo && clsPerson.IsPersonExist(txtNationNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationNo, "National Number is used for another Person!");
            }
            else
                errorProvider1.SetError(txtNationNo, null);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field Are not valid!");
                return;
            }

            int NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dateTimePicker2.Value;

            if (pictureBox1.ImageLocation != null)
                _Person.ImagePath = pictureBox1.ImageLocation.ToString();
            else
                _Person.ImagePath = "";

            if (rdbMale.Checked)
                _Person.Gendor = 0;
            else
                _Person.Gendor = 1;
            _Person.NationalityCountryID = NationalityCountryID;

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();

                Mode = enMode.Update;

                lblAddEditPerson.Text = "Update _Person";

                Databack?.Invoke(this, _Person.PersonID);

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("error:Date Is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
             


    }

}
