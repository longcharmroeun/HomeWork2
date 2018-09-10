using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Task 6
Write a program that determines a day of the week based on the date
entered. The result is output in a text box.*/


namespace HomeWork2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.DayOfWeek.ToString();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.DayOfWeek.ToString();
        }
    }
}
