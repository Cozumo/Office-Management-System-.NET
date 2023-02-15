using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class EMPLOYEE : Form
    {
        String PASSWORD = "1234";
        public EMPLOYEE()
        {
            InitializeComponent();
        }
        EMPLOYEEFUNCTION F2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void TXTID_TextChanged(object sender, EventArgs e)
        {
            if(TXTID.Text== "Select * from Tlbuser;") { }
        }

        private void EMPLOYEE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DATA();
        }
        public void DATA()
        {
            if (TXTPASSWORD.Text == PASSWORD)
            {
                MessageBox.Show("SUCCESSFULLY LOGIN");
                if (F2 == null)
                {
                    F2 = new EMPLOYEEFUNCTION();
                    this.Close();
                    F2.Show();
                }
                else
                {
                    F2.Activate();
                }
            }
            else
            {
                MessageBox.Show("WRONG PASSWORD");
            }
        }
        void f2_close(object sender, FormClosedEventArgs e)
        {
            F2 = null;
        }
    }
}
