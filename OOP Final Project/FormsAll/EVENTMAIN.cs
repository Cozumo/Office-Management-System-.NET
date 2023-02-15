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
    public partial class EVENTMAIN : Form
    {
        public EVENTMAIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            REMOVEEVENT eE = new REMOVEEVENT();
            this.Close();
            eE.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDEVENT eE = new ADDEVENT();
            this.Close();
            eE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADMINFUNCTION am = new ADMINFUNCTION();
            this.Close();
            am.Show();
        }
    }
}
