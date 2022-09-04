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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            char[] separator = { ' ' };
            int wordscount = text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
            toolStripStatusLabel2.Text = wordscount.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //toolStripComboBox2.SelectedIndex = 0;

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            //if (toolStripComboBox2.SelectedIndex == 0)
            //{
            //    richTextBox1.Font = new Font("Arial", 10);
            //}
            //else if (toolStripComboBox2.SelectedIndex == 1)
            //{
            //    richTextBox1.Font = new Font("Calibri", 10);
            //}
            //else if (toolStripComboBox2.SelectedIndex == 2)
            //{
            //    richTextBox1.Font = new Font("Roboto", 10);
            //}
            //else if (toolStripComboBox2.SelectedIndex == 3)
            //{
            //    richTextBox1.Font = new Font("Times New Roman", 10);
            //}
            //else
            //{
            //    richTextBox1.Font = new Font("Bookman Old Style", 10);
            //}
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Bold == false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void italicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Italic == false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Underline== false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Strikeout == false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Strikeout);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Bold == false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Italic == false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Underline == false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                if (richTextBox1.SelectionFont.Strikeout == false)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Strikeout);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.Filter = "text files|.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
            {
                richTextBox1.Redo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanRedo == true)
            {
                richTextBox1.Redo();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.InitialDirectory = @"C:\";

            String myfilenamen = openFileDialog1.FileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            
            //richTextBox1.LoadFile(myfilenamen, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "*.txt";
            saveFileDialog.Filter = "text files|.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //code for font dialog
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}