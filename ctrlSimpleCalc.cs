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
    public partial class ctrlSimpleCalc : UserControl
    {
        public ctrlSimpleCalc()
        {
            InitializeComponent();
        }

        public event Action<int> OnCalculationComplete;

        protected virtual void CalculationComplete(int PersonID)
        {
            Action<int> Handler = OnCalculationComplete;

            if (Handler != null)
            {
                Handler(PersonID);
            }
        }

        public float Result
        { get { return (float)Convert.ToDouble(lblResult.Text); } }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int result = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
            lblResult.Text =result.ToString();

            if(OnCalculationComplete != null)
                CalculationComplete(result);


        }

        
    }
}
