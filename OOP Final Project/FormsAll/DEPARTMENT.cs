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
    public partial class DEPARTMENT : Form
    {
        public DEPARTMENT()
        {
            InitializeComponent();
            Department d = new Department();
            d.Display();
            label6.Text = d.Loc();
            label8.Text = d.Hd();
            label7.Text = d.Tim();
            label9.Text = d.Ph();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            EMPLOYEEFUNCTION f = new EMPLOYEEFUNCTION();
            this.Close();
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    } 
}
