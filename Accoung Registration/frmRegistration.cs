using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accoung_Registration
{
    public delegate long DelegateNumber();
    public delegate string DelegateText();
   

    public partial class frmRegistration : Form
    {
        DelegateNumber ClearNumber;
        DelegateText ClearText;


        public frmRegistration()
        {
            InitializeComponent();
            ClearText = new DelegateText(StudentInfoClass.InitializeText);
            ClearNumber = new DelegateNumber(StudentInfoClass.InitializeNumber);
            InitializeData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear info Text
            textBoxLastName.Text = ClearText();
            textBoxFirstName.Text = ClearText();
            textBoxMiddleName.Text = ClearText();
            RtbAddress.Text = ClearText();

            //Clear info Long
            textBoxAge.Text = Convert.ToString(ClearNumber());
            textBoxStudNo.Text = Convert.ToString(ClearNumber());
            textBoxContactNo.Text = Convert.ToString(ClearNumber());

            CmbProgram.Items.Clear();
            CmbProgram.Items.Add("BSIT");
            CmbProgram.Items.Add("BSHM");
            CmbProgram.Items.Add("BSBA");
        }
        public void InitializeData()
        {
            // Delegate Long
            textBoxStudNo.Text = Convert.ToString(ClearNumber());
            textBoxContactNo.Text = Convert.ToString(ClearNumber());
            textBoxAge.Text = Convert.ToString(ClearNumber());

            // Delegate Text
            textBoxLastName.Text = ClearText();
            textBoxFirstName.Text = ClearText();
            textBoxMiddleName.Text = ClearText();
            RtbAddress.Text = ClearText();
            // BSIT , BSHM , BSBA
            CmbProgram.Items.Clear();
            CmbProgram.Items.Add("BSIT");
            CmbProgram.Items.Add("BSHM");
            CmbProgram.Items.Add("BSBA");
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            FrmConfirm FOutput = new FrmConfirm();
            FOutput.lblStudNo.Text = textBoxStudNo.Text;
            FOutput.lblProgram.Text = CmbProgram.Text;
            FOutput.lblLastName.Text = textBoxLastName.Text;
            FOutput.lblFirstName.Text = textBoxFirstName.Text;
            FOutput.lblMiddleName.Text = textBoxMiddleName.Text;
            FOutput.lblAge.Text = textBoxAge.Text;
            FOutput.lblContactNo.Text = textBoxContactNo.Text;
            FOutput.lblAddress.Text = RtbAddress.Text;
            FOutput.ShowDialog();
        }
    }
    public class StudentInfoClass
    {
        public static string InitializeText() { 
            return string.Empty;
        }
        public static long InitializeNumber()
        {
            return 0;

        }
    }
}

