using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectsSpring
{
    public partial class Job_category_page : Form
    {
        public Job_category_page()
        {
            InitializeComponent();
        }

        private void Job_category_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Company where JTitle=@JTitle ", con);
            cmd.Parameters.AddWithValue("@JTitle",textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User ob1 = new User();
            ob1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Job_apply_page ob2 = new Job_apply_page();
            ob2.Show();
        }
    }
}
