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
    public partial class DISPLAYEVENT : Form
    {
        public DISPLAYEVENT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMPLOYEEFUNCTION P = new EMPLOYEEFUNCTION();
            this.Close();
            P.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpEvents EE = new UpEvents();
            dataGridView1.DataSource = EE.Display();
        }
    }
}
