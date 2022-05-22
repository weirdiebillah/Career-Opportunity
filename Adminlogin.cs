using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectsSpring
{
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");

            }
            else if (textBox1.Text == "admin")
            {
                Adminpage adm = new Adminpage();
                adm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
