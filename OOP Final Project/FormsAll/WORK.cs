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
    public partial class WORK : Form
    {
        private int sno;

        public WORK()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                WorkStats wS = new WorkStats();
                wS.Insert(textBox2.Text, textBox1.Text);
            }
            else
            {
                MessageBox.Show("Input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMPLOYEEFUNCTION eF = new EMPLOYEEFUNCTION();
            this.Close();
            eF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkStats wS = new WorkStats();
            dataGridView1.DataSource = wS.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkStats wS = new WorkStats();
            wS.Delete(sno);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
