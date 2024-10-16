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
    public partial class ctrPersonCard : UserControl
    {
        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        private clsPerson _person;

        public clsPerson Person
        { get { return _person; } }
        
        public ctrPersonCard()
        {
            InitializeComponent();

        }

        public void ResetPersonInfo()
        {
            lblpersonID.Text = "[???]";
            lblName.Text= "[???]";
            lblNationalNo.Text = "[???]";
            lblGender.Text = "[???]";
            lblEmail.Text = "[???]";
            lblAddress.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblPhone.Text = "[???]";
            lblCountry.Text = "[???]";
            lnkEditPersonInfo.Visible = false;
            pictureBox1.Image = Properties.Resources.Male_512;
        }

        private void _LoadPersonImage()
        {
            if (_person.Gendor == 0)
                pictureBox1.Image = Properties.Resources.Male_512;
            else
                pictureBox1.Image = Properties.Resources.Female_512;

            if(_person.ImagePath!=null)
                pictureBox1.ImageLocation=_person.ImagePath;
            else
                MessageBox.Show("could not find this image: = " + _person.ImagePath,"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillPersonInfo()
        {
            _PersonID = _person.PersonID;
            lblpersonID.Text = _person.PersonID.ToString();
            lblName.Text = _person.FullName();
            lblNationalNo.Text = _person.NationalNo;
            lblGender.Text = _person.Gendor == 0 ? "Male" : "Female";
            lblEmail.Text = _person.Email;
            lblAddress.Text = _person.Address;
            lblPhone.Text=_person.Phone;
            lblDateOfBirth.Text=_person.DateOfBirth.ToShortDateString();
            lblCountry.Text = _person.CountryInfo.CountryName;
            lnkEditPersonInfo.Visible = true;
            _LoadPersonImage();
        }

        public void LoadPesonInfo(int PersonID)
        {
            _person =clsPerson.Find(PersonID);
            if (_person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person With PersonID = "+PersonID.ToString(),"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            FillPersonInfo();
        }

        public void LoadPesonInfo(string NationalNo)
        {
            _person = clsPerson.Find(NationalNo);
            if (_person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person With NationalNo = " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillPersonInfo();
        }

        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditFrm frm = new AddEditFrm(_PersonID);

            frm.ShowDialog();
            LoadPesonInfo(_PersonID);
        }
    }  
}
