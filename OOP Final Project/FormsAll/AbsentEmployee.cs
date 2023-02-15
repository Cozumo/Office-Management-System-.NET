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
    public partial class AbsentEmployee : Form
    {
        public AbsentEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yaha pr absent employee wali coding ayegi
            Attendence Att = new Attendence();
            dataGridView1.DataSource = Att.Ab_data();
        }

        private void AbsentEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPLOYEEFUNCTION eF = new EMPLOYEEFUNCTION();
            this.Hide();
            eF.Show();
        }
    }
}
