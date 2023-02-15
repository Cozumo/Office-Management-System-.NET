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
    public partial class DISPLAYLEAVE : Form
    {
        private int sno;
        public DISPLAYLEAVE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leave_Application lA = new Leave_Application();
            dataGridView1.DataSource = lA.Dis_all();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMINFUNCTION am = new ADMINFUNCTION();
            am.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leave_Application lA = new Leave_Application();
            lA.Leave_Delete(sno);
            dataGridView1.DataSource = lA.Dis_all();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
