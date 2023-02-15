using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project.FormsAll
{
    public partial class LOGIN : Form
    {
        private static int a;

        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User us = new User();
            a = us.Login(textBox1.Text, textBox2.Text);
            if (a > 0)
            {
                EMPLOYEEFUNCTION emp = new EMPLOYEEFUNCTION();
                this.Hide();
                emp.Show();
            }
        }
    }
}
