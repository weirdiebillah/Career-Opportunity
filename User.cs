using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectsSpring
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Job_category_page ob1 = new Job_category_page();
            ob1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ob2 = new Login();
            ob2.Show();
        }
    }
}
