using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Controle : Form
    {
        HomeWork home = new HomeWork();
        public const int size = 13;
        public Controle()
        {
            InitializeComponent();
        }

        private void Controle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                listBox1.Items.Add($"HomeWork{ i}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < size)
            {
                richTextBox1.Text = home.info[listBox1.SelectedIndex];
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
                if (listBox1.SelectedIndex >= -0 && listBox1.SelectedIndex < size)
                {
                    if (listBox1.SelectedIndex == 0) MessageBox.Show("Easy I did not do it", "Easy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if(listBox1.SelectedIndex == 1)
                    {
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                    }
                    else if(listBox1.SelectedIndex == 2)
                    {
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 3)
                    {
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 4)
                    {
                        Form4 form4 = new Form4();
                        form4.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 5)
                    {
                        Form9 form9 = new Form9();
                        form9.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 6)
                    {
                        Form10 form10 = new Form10();
                        form10.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 7)
                    {
                        Form5 form5 = new Form5();
                        form5.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 8)
                    {
                        Form6 form6 = new Form6();
                        form6.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 9)
                    {
                        Form7 form7 = new Form7();
                        form7.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 10)
                    {
                        Form8 form8 = new Form8();
                        form8.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 11)
                    {
                        Form11 form11 = new Form11();
                        form11.ShowDialog();
                    }
                    else if (listBox1.SelectedIndex == 12)
                    {
                        Form12 form12 = new Form12();
                        form12.ShowDialog();
                    }
                }
            }
        }
    }
}
