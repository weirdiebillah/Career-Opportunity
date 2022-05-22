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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox8.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" )
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into users values (@Name,@Address,@Phone,@Email,@Gender,@DOB,@Nid,@Username,@Password,@Usertype)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox2.Text);
            cmd.Parameters.AddWithValue("@DOB", textBox8.Text);
            cmd.Parameters.AddWithValue("@Nid", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Username", textBox6.Text);
            cmd.Parameters.AddWithValue("@Password", textBox7.Text);
            cmd.Parameters.AddWithValue("@Usertype", comboBox1.Text);
        
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Registared");
            }
            else
            {
                MessageBox.Show("Please complete the entire form!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox2.Text = "";
            textBox8.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ob1 = new Home();
            ob1.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
