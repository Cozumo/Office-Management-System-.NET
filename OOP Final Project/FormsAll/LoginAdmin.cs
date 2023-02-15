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
    public partial class LoginAdmin : Form
    {
        private static int a;

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            a = ad.Display(textBox2.Text, textBox1.Text);
            if (a > 0)
            {
                ADMINFUNCTION emp = new ADMINFUNCTION();
                this.Hide();
                emp.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 aF = new Form1();
            aF.Show();
            this.Hide();
        }
    }
}
