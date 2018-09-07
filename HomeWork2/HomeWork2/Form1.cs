using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
Task 2
Write a function that “guesses” a number from 1 to 2000 conceived
by the user. MessageBox should be used for the query to the user.
Once the number is guessed, it is necessary to display the number of
queries it took to do so, and allow the user to play once again without
exiting the program (MessageBox’es should be with buttons and icons
according to the situation). 
*/


namespace HomeWork2
{
    public partial class Form1 : Form
    {
        public int Num, score = 0;
        public Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            Generated();
        }

        private void Generated()
        {
            Num = random.Next(1, 2001);
            BarNum.Minimum = 0;
            BarNum.Maximum = Num;
            BarNum.Value = 0;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                GuessButton.PerformClick();
            }
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Num == Convert.ToInt32(TextBox.Text))
                {
                    score++;
                    Score.Text = score.ToString();
                    MessageBox.Show("You Win", "detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Convert.ToInt32(TextBox.Text) >= 0 && Convert.ToInt32(TextBox.Text) <= Num)
                    {
                        BarNum.Value = Convert.ToInt32(TextBox.Text);
                    }
                    else BarNum.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
