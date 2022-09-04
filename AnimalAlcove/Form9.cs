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
    public partial class Form9 : Form
    {
        SqlConnection con = null;
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
                MessageBox.Show("Enter Valid Employee Name", "Error!!");
            else
            {

                con.Open();
                String name = textBox2.Text;
                SqlCommand cmd = new SqlCommand("select Gender,Dob,Contact,Email,Address,Desig,Per_exp,Allergy from volunteer_details where Name='" + textBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string gen = dr.GetValue(0).ToString();
                    string dob = dr.GetValue(1).ToString();
                    string num = dr.GetValue(2).ToString();
                    string email = dr.GetValue(3).ToString();
                    string add = dr.GetValue(4).ToString();
                    string desig = dr.GetValue(5).ToString();
                    string per_exp = dr.GetValue(6).ToString();
                    string all = dr.GetValue(7).ToString();

                    if (gen == "Male")
                        radioButton1.Checked = true;
                    else if (gen == "Female")
                        radioButton2.Checked = true;
                    else
                        radioButton3.Checked = true;

                    dateTimePicker1.Value = Convert.ToDateTime(dob);
                    textBox2.Text = num;
                    textBox3.Text = email;
                    richTextBox1.Text = add;
                    comboBox1.SelectedItem = desig;

                    if (per_exp == "Yes")
                        checkBox1.Checked = true;
                    else
                        checkBox1.Checked = false;

                    if (all == "Yes")
                        checkBox2.Checked = true;
                    else
                        checkBox2.Checked = false;

                }
                con.Close();
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem4\dotnetlab\AnimalAlcove\AnimalAlcove\Database2.mdf;Integrated Security=True");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("Can we confirm ? ", " Submit ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete from volunteer_details where Name = '" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                richTextBox1.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                checkBox1.Checked = false;
                checkBox2.Checked=false;
                radioButton1.Checked = false;
                radioButton2.Checked=false;
                radioButton3.Checked=false;
            }

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
