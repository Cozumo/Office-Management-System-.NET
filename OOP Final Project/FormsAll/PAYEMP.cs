﻿using System;
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
    public partial class PAYEMP : Form
    {
        public PAYEMP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payroll pay = new Payroll();
            dataGridView1.DataSource = pay.Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMPLOYEEFUNCTION eF = new EMPLOYEEFUNCTION();
            this.Hide();
            eF.Show();
        }
    }
}
