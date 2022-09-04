using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace AnimalAlcove
{
    public partial class Form3 : Form
    {
        SqlConnection conn;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Shelter Manager");
            comboBox1.Items.Add("Adoption Manager");
            comboBox1.Items.Add("Outreach Coordinator");
            comboBox1.Items.Add("Manager of Volunteer Services");
            comboBox1.Items.Add("Animal Control Officer");
            comboBox1.Items.Add("Animal Trainer");
            comboBox1.Items.Add("Animal Caretaker");
            comboBox1.Items.Add("Care Assistant");
            comboBox1.Items.Add("Kennel Technician");
            comboBox1.Items.Add("Animal Technician");
            comboBox1.Items.Add("Medical Technician");
            comboBox1.Items.Add("Veterinary Technician");
            comboBox1.Items.Add("Veterinary Assistant");
            comboBox1.Items.Add("Veterinary Receptionist");
            comboBox1.Items.Add("Veterinarian");

            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sem4\dotnetlab\AnimalAlcove\AnimalAlcove\Database2.mdf;Integrated Security=True");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            progressBar1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox2.Checked == false)
            {
                MessageBox.Show("You Can't be a Volunteer if you have Animal concerning Allergies");
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || richTextBox1.Text == "" || richTextBox2.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Do Not Leave any Field Empty!");
            }
            else
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

                

                conn.Open();

                SqlCommand comm1 = new SqlCommand("insert into Volunteer_details (Name,Gender,Dob,Contact,Email,Address,Desig,Why,Per_exp,Allergy) values('" + textBox1.Text + "' , '" +  gender + "' , '" + dob + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + richTextBox1.Text + "' , '" + post + "' , '" + richTextBox2.Text + "' , '" + exp + "' , '" + allergy + "')", conn);
                comm1.ExecuteNonQuery();
                MessageBox.Show("You have Successfully become a Volunteer.\nWelcome To Animal Alcove!!","Confirm!!");
                conn.Close();

            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(textBox1.Text, "^[a-zA-Z]*$").Success)
            {
                MessageBox.Show("Invalid Name");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            //ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox1, "Enter Your Name");
         }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox2, "Enter Your ContactNo");
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox3, "Enter Your EmailId");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && progressBar1.Value != 100)
            progressBar1.Value +=10;
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && progressBar1.Value != 100) 
                progressBar1.Value += 10;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && progressBar1.Value != 100) 
                progressBar1.Value += 10;
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && progressBar1.Value != 100) 
                progressBar1.Value += 20;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && progressBar1.Value != 100) 
                progressBar1.Value += 10;
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && progressBar1.Value != 100) 
                progressBar1.Value += 20;
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "" && progressBar1.Value != 100) 
                progressBar1.Value = +20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
