using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Final_Project.FormsAll;

namespace OOP_Final_Project
{
    public partial class EMPLOYEEFUNCTION : Form
    {
        public EMPLOYEEFUNCTION()
        {
            InitializeComponent();
            User U = new User();
            label5.Text = U.Add();
            label6.Text = U.Eml();
            label7.Text = U.nm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void EMPLOYEEFUNCTION_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LAEVE L = new LAEVE();
            this.Hide();
            L.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DEPARTMENT d = new DEPARTMENT();
            this.Hide();
            d.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PresentEmployee pe = new PresentEmployee();
            this.Hide();
            pe.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PAYEMP em = new PAYEMP();
            this.Hide();
            em.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DISPLAYEVENT L = new DISPLAYEVENT();
            this.Hide();
            L.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WORK w = new WORK();
            this.Hide();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendence at = new Attendence();
            at.Insert();
        }
    }
}

