﻿using System;
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
    public partial class FindPerson : Form
    {
        public FindPerson()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventHandler(object sender, int PersonId);

        public event DataBackEventHandler DataBack;



        private void button1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
        }
    }
}
