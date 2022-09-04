using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnimalAlcove
{
    public partial class Form2 : Form
    {
        SqlConnection con = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar = '*';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0'; 
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Enter Valid Username or Password");
            else
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("select Password from login where UserId='" + textBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string abc = dr.GetValue(0).ToString();
                    if (textBox2.Text != abc)
                        MessageBox.Show("Invalid Username or Password");
                    else
                    {
                        //MessageBox.Show("valid");
                        //MessageBox.Show("Successfully Signed In !!\nWelcome To Animal Alcove");
                        Form5 f5 = new Form5();
                        f5.Show();
                        this.Hide();

                    }
                }
                con.Close();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }

            else if (textBox2.PasswordChar =='*')
            {
                textBox2.PasswordChar ='\0';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem4\dotnetlab\AnimalAlcove\AnimalAlcove\Database2.mdf;Integrated Security=True");
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Insert Into Login Values('"+textBox1.Text + "','" + textBox2.Text + "')",con);
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if(i!=0)
        //    {
        //        MessageBox.Show("Data Inserted into the Database");
        //    }
        //}
    }
}
