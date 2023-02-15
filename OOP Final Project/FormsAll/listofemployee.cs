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
    public partial class listofemployee : Form
    {
        public listofemployee()
        {
            InitializeComponent();
        }

        private void listofemployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee eMP = new Employee();
            dataGridView1.DataSource = eMP.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMINFUNCTION am = new ADMINFUNCTION();
            am.Show();
            this.Hide();
        }
    }
}
