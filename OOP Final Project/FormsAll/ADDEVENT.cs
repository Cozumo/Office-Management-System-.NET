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
    
    public partial class ADDEVENT : Form
    {
        public ADDEVENT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EVENTMAIN P = new EVENTMAIN();
            this.Close();
            P.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && TXTADD.Text != "")
            {
                UpEvents Events = new UpEvents();
                Events.Insert(TXTADD.Text, textBox1.Text);
            }
            else
            {
                MessageBox.Show("Input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpEvents Events = new UpEvents();
            dataGridView1.DataSource = Events.Display();
        }
    }
}
