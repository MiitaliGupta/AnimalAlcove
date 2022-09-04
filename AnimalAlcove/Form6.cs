using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalAlcove
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = DateTime.Now;

            comboBox1.Items.Add("Shelter Manager");
            comboBox1.Items.Add("Adoption Manager");
            comboBox1.Items.Add("Outreach Coordinator");
            comboBox1.Items.Add("Manager of Volunteer Services");
            comboBox1.Items.Add("Animal Control Officer");
            comboBox1.Items.Add("Animal Trainer");
            comboBox1.Items.Add("Animal Caretaker");
            comboBox1.Items.Add("Kennel Technician");
            comboBox1.Items.Add("Animal Technician");
            comboBox1.Items.Add("Medical Technician");
            comboBox1.Items.Add("Veterinary Technician");
            comboBox1.Items.Add("Veterinary Assistant");
            comboBox1.Items.Add("Veterinary Receptionist");
            comboBox1.Items.Add("Veterinarian");

            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Shelter Manager")
            {
                textBox2.Text = "100";
            }
            else if (comboBox1.SelectedItem.ToString() == "Adoption Manager")
            {
                textBox2.Text = "150";
            }
            else if (comboBox1.SelectedItem.ToString() == "Outreach Coordinator")
            {
                textBox2.Text = "200";
            }
            else if (comboBox1.SelectedItem.ToString() == "Manager of Volunteer Services")
            {
                textBox2.Text = "250";
            }
            else if (comboBox1.SelectedItem.ToString() == "Animal Control Officer")
            {
                textBox2.Text = "300";
            }
            else if (comboBox1.SelectedItem.ToString() == "Animal Trainer")
            {
                textBox2.Text = "350";
            }
            else if (comboBox1.SelectedItem.ToString() == "Animal Caretaker")
            {
                textBox2.Text = "400";
            }
            else if (comboBox1.SelectedItem.ToString() == "Kennel Technician")
            {
                textBox2.Text = "450";
            }
            else if (comboBox1.SelectedItem.ToString() == "Animal Technician")
            {
                textBox2.Text = "500";
            }
            else if (comboBox1.SelectedItem.ToString() == "Medical Technician")
            {
                textBox2.Text = "550";
            }
            else if (comboBox1.SelectedItem.ToString() == "Veterinary Technician")
            {
                textBox2.Text = "600";
            }
            else if (comboBox1.SelectedItem.ToString() == "Veterinary Assistant")
            {
                textBox2.Text = "650";
            }
            else if (comboBox1.SelectedItem.ToString() == "Veterinary Receptionist")
            {
                textBox2.Text = "700";
            }
            else if (comboBox1.SelectedItem.ToString() == "Veterinarian")
            {
                textBox2.Text = "750";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime day1 = Convert.ToDateTime(dateTimePicker2.Value);
            DateTime day2 = DateTime.Now;
            String days = day2.Subtract(day1).Days.ToString();
            String x = (
                            (int.Parse(numericUpDown1.Value.ToString()) * 500) + 
                            (int.Parse(days) * int.Parse(textBox2.Text))
                        ).ToString();

            textBox1.Text=x;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
