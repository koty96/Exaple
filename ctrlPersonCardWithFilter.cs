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
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int personID)
        {
            Action<int> Handler= OnPersonSelected;
            if(Handler != null)
                Handler(personID);
        }

        private bool _AddPerson = true;

        public bool AddPerson
        {
            get { return _AddPerson; }
            set
            {
                _AddPerson = value;
                btnAddPerson.Visible = _AddPerson;
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        public int PersonID
        {
            get {return  ctrPersonCard1.PersonID; }
        }

        public clsPerson PersonSelectedInfo
        {
            get { return ctrPersonCard1.Person; }
        }

        private void FindNow()
        {
            switch(cbFiler.Text)
            {
                case "PersonID":
                    ctrPersonCard1.LoadPesonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "NationalNo.":
                    ctrPersonCard1.LoadPesonInfo(txtFilterValue.Text);
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrPersonCard1.PersonID);
        }

        public void LoadPersonInfo(int personID)
        {
            cbFiler.SelectedIndex = 0;
            txtFilterValue.Text = personID.ToString();
            FindNow();

        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
             if(!this.ValidateChildren()) 
             {  
                MessageBox.Show("Some Thing Error ", "Error");
                return;
             }
             FindNow();

        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This Field is requird");

            }
            else
                errorProvider1.SetError(txtFilterValue, null);
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFiler.SelectedIndex = 0;
            txtFilterValue.Focus();
        }


        private void DataBackEvent(object sender,int PersonID)
        {
            cbFiler.SelectedIndex=1;
            txtFilterValue.Text=PersonID.ToString();
            ctrPersonCard1.LoadPesonInfo(PersonID);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddEditFrm frm=new AddEditFrm();
            frm.Databack += DataBackEvent;
            
            frm.ShowDialog();
        }
    }
}
