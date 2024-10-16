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
    public partial class frmListApplicationTypes : Form
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        public static DataTable _dtApplicationTypes;

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtApplicationTypes =  clsApplicationTypes.GetAllApplicationTypes();

            dgvApplicationTypes.DataSource = _dtApplicationTypes;

            lblAplicationTypesNbr.Text=dgvApplicationTypes.Rows.Count.ToString();

            if(dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 105;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 350;

                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 105;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplciationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUdateApplicationTypes frm = new frmUdateApplicationTypes
                ((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListApplicationTypes_Load(null, null);
        }
    }
}
