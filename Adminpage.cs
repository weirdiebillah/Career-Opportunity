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
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox8.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox7.Text != "")
            { 
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();

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
            cmd.Parameters.AddWithValue("@Usertype", textBox9.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Inserted");
            }
            else
            {
                MessageBox.Show("Please complete the entire form!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (textBox6.Text != "" && textBox7.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update users set Username=@Username where Password=@Password", con);

                cmd.Parameters.AddWithValue("@Username", textBox6.Text);
                cmd.Parameters.AddWithValue("@Password", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete users where Nid=@Nid", con);
            cmd.Parameters.AddWithValue("@Nid", int.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from users where Nid=@Nid ", con);
            cmd.Parameters.AddWithValue("@Nid", int.Parse(textBox5.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin ob3 = new Adminlogin();
            ob3.Show();
        }

        private void Adminpage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlDataAdapter sdal = new SqlDataAdapter("Select * from users ", con);
            DataTable dt = new DataTable();
            sdal.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox2.Text=" ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
