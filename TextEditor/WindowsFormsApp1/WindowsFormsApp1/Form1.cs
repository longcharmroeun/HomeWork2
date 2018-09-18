using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool istextwrite = false, isopenfile = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                if (!isopenfile) isopenfile = true;
            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName,richTextBox1.Lines);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(openFileDialog1.FileName, richTextBox1.Lines);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (istextwrite && isopenfile)
            {
                MessageBoxManager.Yes = "Save";
                MessageBoxManager.No = "Don't Save";
                MessageBoxManager.Register();
                DialogResult result = MessageBox.Show($"Do you to save changes to \n{openFileDialog1.FileName}", "Notpage", MessageBoxButtons.YesNoCancel);
                MessageBoxManager.Unregister();
                if(result == DialogResult.Yes)
                {
                    File.WriteAllLines(openFileDialog1.FileName, richTextBox1.Lines);
                }
                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else if (istextwrite)
            {
                MessageBoxManager.Yes = "Save";
                MessageBoxManager.No = "Don't Save";
                MessageBoxManager.Register();
                DialogResult result = MessageBox.Show($"Do you to save", "Notpage", MessageBoxButtons.YesNoCancel);
                MessageBoxManager.Unregister();
                if (result == DialogResult.Yes)
                {
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (istextwrite && isopenfile)
            {
                MessageBoxManager.Yes = "Save";
                MessageBoxManager.No = "Don't Save";
                MessageBoxManager.Register();
                DialogResult result = MessageBox.Show($"Do you to save changes to \n{openFileDialog1.FileName}", "Notpage", MessageBoxButtons.YesNoCancel);
                MessageBoxManager.Unregister();
                if (result == DialogResult.Yes)
                {
                    File.WriteAllLines(openFileDialog1.FileName, richTextBox1.Lines);
                    istextwrite = false;
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    istextwrite = false;
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                form1.ShowDialog();
                this.Close();

            }
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 100);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordToolStripMenuItem.Checked == false) wordToolStripMenuItem.Checked = true;
            else if (wordToolStripMenuItem.Checked == true) wordToolStripMenuItem.Checked = false;
        }

        private void wordToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (wordToolStripMenuItem.Checked == true) richTextBox1.WordWrap = true;
            else if (wordToolStripMenuItem.Checked == false) richTextBox1.WordWrap = false;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
            else
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!istextwrite) istextwrite = true;
        }
    }
}
