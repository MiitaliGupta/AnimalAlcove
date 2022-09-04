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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Can we confirm ? ", " Submit ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have Successfully become a Pet Parent!!");
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox2.Items.Contains(listBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Already Exists", "Error");
            }
            else
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
                comboBox1.Items.Add(listBox1.SelectedItem.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a = listBox2.SelectedItem.ToString();
            listBox2.Items.Remove(listBox2.SelectedItem.ToString());
            comboBox1.Items.Remove(a);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Dogs")
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Staffordshire Terriers");
                listBox3.Items.Add("Jack Russell Terrier");
                listBox3.Items.Add("Dachshund");
                listBox3.Items.Add("Pit Bull");
                listBox3.Items.Add("Boxer");

            }
            else if (comboBox1.SelectedItem.ToString() == "Cats")
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Norwegian Forest Cat");
                listBox3.Items.Add("Maine Coon Cat");
                listBox3.Items.Add("Munchkin Cat");
                listBox3.Items.Add("Siamese Cat");
                listBox3.Items.Add("Persian Cat");
            }
            else if (comboBox1.SelectedItem.ToString() == "Rabbits")
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Holland Lop");
                listBox3.Items.Add("Dwarf Hotot");
                listBox3.Items.Add("Dutch Lop");
                listBox3.Items.Add("Mini Rex");
                listBox3.Items.Add("Mini Lop");
            }
            else if (comboBox1.SelectedItem.ToString() == "Guinea Pigs")
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Peruvian Satin Guinea Pig");
                listBox3.Items.Add("Abyssinian Guinea Pig");
                listBox3.Items.Add("American Guinea Pig");
                listBox3.Items.Add("Coronet Guinea Pig");
                listBox3.Items.Add("Silkie Guinea Pig");
            }
            else if (comboBox1.SelectedItem.ToString() == "Hamsters")
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Djungarian Dwarf Hamster");
                listBox3.Items.Add("Campbell's Dwarf Hamster");
                listBox3.Items.Add("Winter's White Hamster");
                listBox3.Items.Add("Chinese Dwarf Hamster");
                listBox3.Items.Add("Robo Hamster");
            }
        }
    }
}

