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
    public partial class PayCheck : Form
    {
        static int sno;

        public PayCheck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PayCheck_Load(object sender, EventArgs e)
        {
            //yaha pr paycheck wali class ki puri coding ayegi
            Payroll pa = new Payroll();
            dataGridView1.DataSource = pa.Dis_all();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payroll pa = new Payroll();
            pa.Update(textBox2.Text, sno);
            dataGridView1.DataSource = pa.Dis_all();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payroll pa = new Payroll();
            dataGridView1.DataSource = pa.Dis_all();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADMINFUNCTION adm = new ADMINFUNCTION();
            adm.Show();
            this.Hide();
        }
    } 
}

