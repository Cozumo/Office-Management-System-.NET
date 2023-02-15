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
    public partial class ADMIN : Form
    {
        String PASSWORD = "1234";
        public ADMIN()
        {
            InitializeComponent();
        }

        private void TXTID_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXTPASSWORD_TextChanged(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //yaha data add ka ki coding ayegi dehko ma na coding nh ki bas method call kr waya ha
            
        }
        
        
        void f2_close(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
}
