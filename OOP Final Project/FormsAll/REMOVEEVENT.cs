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
    public partial class REMOVEEVENT : Form
    {
        private static int sno;
        public REMOVEEVENT()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpEvents eve = new UpEvents();
            dataGridView1.DataSource = eve.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpEvents eve = new UpEvents();
            eve.Delete(sno);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EVENTMAIN am = new EVENTMAIN();
            this.Close();
            am.Show();
        }
    }
}
