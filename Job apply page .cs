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
    public partial class Job_apply_page : Form
    {
        public Job_apply_page()
        {
            InitializeComponent();
        }

        private void Job_apply_page_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Show();
            Job_category_page ob1 = new Job_category_page();
            ob1.Show();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (FnamBox1.Text != "" && lnamBox5.Text != "" && fatherBox1.Text != "" && MotherBox1.Text != "" && AgeBox1.Text != "" && addrssBox2.Text != "" && GBox1.Text != "" && GraduBox1.Text != "" && masterBox8.Text != "" && othersBox2.Text != "" && PhoneBox3.Text != "" && mailBox4.Text != "" && CnameBox3.Text != "" && CpositionBox1.Text != "" && PIDBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into Job values (@Firstname,@Lastname,@Fathername,@Mothername,@Age,@Address,@Gender,@Contact,@Graduation,@Masters,@Others,@Email,@SCN,@SCP,@SCPID)", con);
                cmd.Parameters.AddWithValue("@Firstname", FnamBox1.Text);
                cmd.Parameters.AddWithValue("@Lastname", lnamBox5.Text);
                cmd.Parameters.AddWithValue("@Fathername", fatherBox1.Text);
                cmd.Parameters.AddWithValue("@Mothername", MotherBox1.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(AgeBox1.Text));
                cmd.Parameters.AddWithValue("@Address", addrssBox2.Text);
                cmd.Parameters.AddWithValue("@Gender", GBox1.Text);
                cmd.Parameters.AddWithValue("@Contact", PhoneBox3.Text);
                cmd.Parameters.AddWithValue("@Graduation", GraduBox1.Text);
                cmd.Parameters.AddWithValue("@Masters", masterBox8.Text);
                cmd.Parameters.AddWithValue("@Others", othersBox2.Text);
                cmd.Parameters.AddWithValue("@Email", mailBox4.Text);
                cmd.Parameters.AddWithValue("@SCN", CnameBox3.Text);
                cmd.Parameters.AddWithValue("@SCP", CpositionBox1.Text);
                cmd.Parameters.AddWithValue("@SCPID", PIDBox1.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucessfully Applied");
            }
            else
            {
                MessageBox.Show("Please complete the entire form!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         void clear()
        {
            FnamBox1.Clear();
            lnamBox5.Clear();
            fatherBox1.Clear();
            MotherBox1.Clear();
            AgeBox1.Clear();
            addrssBox2.Clear();
            GBox1.Text = "";
            PhoneBox3.Clear();
            GraduBox1.Clear();
            masterBox8.Clear();
            othersBox2.Clear();
            mailBox4.Clear();
            CnameBox3.Clear();
            CpositionBox1.Clear();
            PIDBox1.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
