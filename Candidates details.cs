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
    public partial class Candidates_details : Form
    {
        public Candidates_details()
        {
            InitializeComponent();
        }

        private void Candidates_details_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Job where SCPID=@SCPID ", con);
            cmd.Parameters.AddWithValue("@SCPID", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyUser ob1 = new CompanyUser();
            ob1.Show();
        }
    }
}
