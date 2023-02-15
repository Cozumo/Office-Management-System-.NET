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
    public partial class CONTACTAS : Form
    {
        static int id;

        public CONTACTAS()
        {
            InitializeComponent();
        }

        private void CONTACTAS_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contacts c = new Contacts();
            c.Insert(textBox1.Text, textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contacts c = new Contacts();
            dataGridView1.DataSource = c.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contacts c = new Contacts();
            c.Delete(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADMINFUNCTION E = new ADMINFUNCTION();
            this.Close();
            E.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
