using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace OOP_Final_Project
{
    public partial class NEWEMPLOYEE : Form
    {
        public NEWEMPLOYEE()
        {
            InitializeComponent();
        }

        private void NEWEMPLOYEE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TXTNAME.Text != "" && TXTEMAIL.Text != "" && TXTADDRESS.Text != "" && TXTPASSWORD.Text != "" && comboBox1.Text != "")
                {
                    Employee Emp = new Employee();
                    Emp.Insert(TXTNAME.Text, TXTPASSWORD.Text, TXTEMAIL.Text, TXTADDRESS.Text, comboBox1.Text);
                }
                else
                {
                    MessageBox.Show("Input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ADMINFUNCTION F = new ADMINFUNCTION();
            this.Close();
            F.Show();
        }
    }
}

