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
    public partial class Form8 : Form
    {
        SqlConnection con = null;
        public Form8()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
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

                    if(gen=="Male")
                        radioButton1.Checked = true;
                    else if(gen=="Female")
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

        private void Form8_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem4\dotnetlab\AnimalAlcove\AnimalAlcove\Database2.mdf;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {

              String gender,dob,post,exp, allergy;
            if (radioButton1.Checked == true)
                gender = "Male";
            else if (radioButton2.Checked == true)
                gender = "Female";
            else
                gender = "Other";

            dob = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");

            post = comboBox1.SelectedItem.ToString();

            if (checkBox1.Checked == true)
                exp = "Yes";
            else
                exp = "No";


            if (checkBox2.Checked == true)
                allergy = "Yes";
            else
                allergy = "No";

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Update volunteer_details set Gender ='"+ gender+ "',Dob ='" + dob + "', Desig = '" + post + "', Per_exp='" + exp + "', Allergy ='" + allergy + "', Contact = '" + textBox2.Text + "', Email = '"+ textBox3.Text +"',Address= '"+richTextBox1.Text+"'  where Name='" + textBox1.Text + "'", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Details Updated Successfully!!", "Confirm!!");
            con.Close();
        }
    }
}
