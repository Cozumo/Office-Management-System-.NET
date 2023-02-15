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
    public partial class WorkDisplay : Form
    {
        private int sno;
        public WorkDisplay()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkStats wS = new WorkStats();
            dataGridView1.DataSource = wS.Dis_all();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADMINFUNCTION aF = new ADMINFUNCTION();
            aF.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
