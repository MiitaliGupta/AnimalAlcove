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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }
    }
}
