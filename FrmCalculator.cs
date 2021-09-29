using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public delegate long DelegateNumber();

    public partial class FrmCalculator : Form

    {
        DelegateNumber ClearNumber;

        public FrmCalculator()
        {
            InitializeComponent();
            ClearNumber = new DelegateNumber(CalculatorClass.InitializeNumber);
            InitializeData();
          
        }

        public void InitializeData()
        {
            //Delegate Long

            txtBoxInput1.Text = Convert.ToString(ClearNumber());
            txtBoxInput2.Text = Convert.ToString(ClearNumber());

            cbOperator.Items.Clear();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

        }

     
        public class CalculatorClass
        {
            public static long InitializeNumber()
            {
                return 0;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear Long

            txtBoxInput1.Text = Convert.ToString(ClearNumber());
            txtBoxInput2.Text = Convert.ToString(ClearNumber());

            cbOperator.Items.Clear();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

            txtOutput.Text = Convert.ToString(ClearNumber());

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);
            if(cbOperator.Text == "+")
            {
                txtOutput.Text = Convert.ToString(num1 + num2);
            }
            if (cbOperator.Text == "-")
            {
                txtOutput.Text = Convert.ToString(num1 - num2);
            }
            if (cbOperator.Text == "*")
            {
                txtOutput.Text = Convert.ToString(num1 * num2);
            }
            if (cbOperator.Text == "/")
            {
                txtOutput.Text = Convert.ToString(num1 / num2);
            }
        }
    }
}
