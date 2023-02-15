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
    public partial class ADMINFUNCTION : Form
    {
        public ADMINFUNCTION()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 A = new Form1();
            this.Hide();
            A.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NEWEMPLOYEE Ne = new NEWEMPLOYEE();
            this.Hide();
            Ne.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            REMOVEEMPLOYEE re = new REMOVEEMPLOYEE();
            this.Hide();
            re.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listofemployee le = new listofemployee();
            this.Hide();
            le.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AttendenceEmployee aE = new AttendenceEmployee();
            this.Hide();
            aE.Show();
        }

        private void ADMINFUNCTION_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DISPLAYLEAVE le = new DISPLAYLEAVE();
            le.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EVENTMAIN uE = new EVENTMAIN();
            this.Hide();
            uE.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CONTACTAS C = new CONTACTAS();
            this.Hide();
            C.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PayCheck Pay = new PayCheck();
            Pay.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WorkDisplay Dis = new WorkDisplay();
            Dis.Show();
            this.Hide();
        }
    }    
}

    
