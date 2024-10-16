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
    public partial class PersonDetails : Form
    {
        private int PersonID = 0;
        public PersonDetails(int PersonID)
        {
            this.PersonID = PersonID;
            InitializeComponent();
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            ctrPersonCard1.LoadPesonInfo(PersonID);
        }
    }
}
