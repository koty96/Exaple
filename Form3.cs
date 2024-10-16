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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void SendBack_Data_Click(object sender, EventArgs e)
        {
            FindPerson frm = new FindPerson();
            frm.DataBack += Form2_DataBack;
            frm.ShowDialog();
        }

        private void Form2_DataBack(object sender,int PersonID)
        {
            textBox1.Text=PersonID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ApplicaitonID=Convert.ToInt16(textBox2.Text);
            FrmLocalDrivingLicenseApplicationInfo frm = new FrmLocalDrivingLicenseApplicationInfo(ApplicaitonID);
            frm.ShowDialog();
        }
    }
}
