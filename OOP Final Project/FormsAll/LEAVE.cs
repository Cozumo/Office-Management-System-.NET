using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class LAEVE : Form
    {
        public LAEVE()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Leave_Application lA = new Leave_Application();
            lA.LeaveAsk(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leave_Application lA = new Leave_Application();
            dataGridView1.DataSource = lA.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leave_Application lA = new Leave_Application();
            lA.LeaveAsk_cancel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMPLOYEEFUNCTION eF = new EMPLOYEEFUNCTION();
            this.Close();
            eF.Show();
        }
    }
}
    

