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
    public partial class AttendenceEmployee : Form
    {
        public AttendenceEmployee()
        {
            InitializeComponent();
        }

        private void AttendenceEmployee_Load(object sender, EventArgs e)
        {
            Attendence a = new Attendence();
            dataGridView1.DataSource = a.Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMINFUNCTION a = new ADMINFUNCTION();
            this.Close();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendence a = new Attendence();
            dataGridView1.DataSource = a.Display();
        }
    }
}
