using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProjectsSpring
{
    public partial class CompanyUser : Form
    {
        public CompanyUser()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Candidates_details ob1 = new Candidates_details();
            ob1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Company values (@CName, @JTitle, @JLocation, @JId,@Salary,@Contract", con);
                cmd.Parameters.AddWithValue("@CName", CnameBox3.Text);
                cmd.Parameters.AddWithValue("@JTitle", JobpositionBox1.Text);
                cmd.Parameters.AddWithValue("@JLocation", JLBox2.Text);
                cmd.Parameters.AddWithValue("@JId", int.Parse(IdforpostionBox1.Text));
                cmd.Parameters.AddWithValue("@Salary", SalaryBox4.Text);
                cmd.Parameters.AddWithValue("@Contract", contractBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucessfully Inserted");*/
            if (CnameBox3.Text != "" && JobpositionBox1.Text != "" && JLBox2.Text != "" && IdforpostionBox1.Text != "" && SalaryBox4.Text != "" && contractBox3.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Company]
           ([CName]
           ,[JTitle]
           ,[JLocation]
           ,[JId]
           ,[Salary]
           ,[Contact])
     VALUES
           ('" +CnameBox3.Text + "', '" +JobpositionBox1.Text + "', '" +JLBox2.Text + "', '" +IdforpostionBox1.Text+ "', '" +SalaryBox4.Text + "', '" +contractBox3.Text+ "' )", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Job Posted Successfully");

            }
            else
            {
                MessageBox.Show("Please complete the entire form!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CompanyUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlDataAdapter sdal = new SqlDataAdapter("Select * from Company ", con);
            DataTable dt = new DataTable();
            sdal.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ob2 = new Login();
            ob2.Show();
        }
        void clear()
        {
            CnameBox3.Clear();
            JobpositionBox1.Clear();
            JLBox2.Clear();
            IdforpostionBox1.Clear();
            SalaryBox4.Clear();
            contractBox3.Clear();
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (JobpositionBox1.Text != "" && IdforpostionBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update Company set JTitle=@JTitle where JId=@JID", con);

                cmd.Parameters.AddWithValue("@JTitle", JobpositionBox1.Text);
                cmd.Parameters.AddWithValue("@JId", int.Parse(IdforpostionBox1.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Company where JId=@JId", con);
            cmd.Parameters.AddWithValue("@JId", int.Parse(IdforpostionBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MA5U0\SQLEXPRESS;Initial Catalog=INFO;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Company where JId=@JId", con);
            cmd.Parameters.AddWithValue("@JId", int.Parse(IdforpostionBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
