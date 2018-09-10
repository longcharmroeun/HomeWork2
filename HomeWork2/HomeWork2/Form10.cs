using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Task 7
Write a program that computes how much time is left till the
specified date (the date is entered to Edit using the keyboard). Provide
the possibility of displaying the results in years, months, days, minutes,
seconds (for the first two options the answer is fractional). To switch
between the options, it is desirable to use RadioButton’s.*/


namespace HomeWork2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            var totalDays = (dateTimePicker1.Value.Date - dateTimePicker2.Value.Date).TotalDays;
            var totalYears = Math.Truncate(totalDays / 365);
            var totalMonths = Math.Truncate((totalDays % 365) / 30);
            var remainingDays = Math.Truncate((totalDays % 365) % 30);
            label1.Text = totalYears.ToString();
            label2.Text = totalMonths.ToString();
            label3.Text = remainingDays.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var totalDays = (dateTimePicker1.Value.Date - dateTimePicker2.Value.Date).TotalDays;
            var totalYears = Math.Truncate(totalDays / 365);
            var totalMonths = Math.Truncate((totalDays % 365) / 30);
            var remainingDays = Math.Truncate((totalDays % 365) % 30);
            label1.Text = totalYears.ToString();
            label2.Text = totalMonths.ToString();
            label3.Text = remainingDays.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var totalDays = (dateTimePicker1.Value.Date - dateTimePicker2.Value.Date).TotalDays;
            var totalYears = Math.Truncate(totalDays / 365);
            var totalMonths = Math.Truncate((totalDays % 365) / 30);
            var remainingDays = Math.Truncate((totalDays % 365) % 30);
            label1.Text = totalYears.ToString();
            label2.Text = totalMonths.ToString();
            label3.Text = remainingDays.ToString();
        }
    }
}
