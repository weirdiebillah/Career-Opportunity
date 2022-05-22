using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectsSpring
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ob2 = new Login();
            ob2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact ob4 = new Contact();
            ob4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration ob1 = new Registration();
            ob1.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registration ob1 = new Registration();
            ob1.Show();
        }
    }
}
