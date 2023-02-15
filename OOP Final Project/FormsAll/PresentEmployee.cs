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
    public partial class PresentEmployee : Form
    {
        public PresentEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yaah pr present employee wali coding ayegi
            Attendence pr = new Attendence();
            dataGridView1.DataSource = pr.Pr_data();
        }
        
        private void PresentEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPLOYEEFUNCTION em = new EMPLOYEEFUNCTION();
            this.Hide();
            em.Show();
        }
    }
}
