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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            if (LoginBox1.Text != "" && PassBox2.Text != "" && comboBox1.Text != "")
            {
                if (comboBox1.Text == "Company User")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from users where Username='" + LoginBox1.Text + "' and Password='" + PassBox2.Text + "' and Usertype='" + comboBox1.Text + "'", con);
                    con.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        CompanyUser cu = new CompanyUser();
                        cu.Show();
                    }
                    else
                    {
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();

                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from users where Username='" + LoginBox1.Text + "' and Password='" + PassBox2.Text + "' and Usertype='" + comboBox1.Text + "'", con);
                    con.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        User up = new User();
                        up.Show();
                    }
                    else
                    {
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ob1 = new Home();
            ob1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin ob2 = new Adminlogin();
            ob2.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void clear()
        {
            LoginBox1.Clear();
            PassBox2.Clear();
            comboBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
}
   
