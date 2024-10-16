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
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        public static DataTable _dtTestTypes;
        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _dtTestTypes = clsTestTypes.GetAllTestTypes();

            dgvTestTypes.DataSource = _dtTestTypes;

            lblTestTypesNbr.Text = dgvTestTypes.Rows.Count.ToString();

            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 105;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 130;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width =450; 
                
                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 105;
            }

        }
        
        private void editApplciationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestFees frm = new frmUpdateTestFees
                ((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListTestTypes_Load(null, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
