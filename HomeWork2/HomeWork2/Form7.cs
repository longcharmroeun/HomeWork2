using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Task 2
Calculate the amount of day between the date selected using
DateTimePicker and output the result on the form using the Label
control. The main window form is to be in the form of ellipsis.*/

namespace HomeWork2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (dateTimePicker1.Value.Day - dateTimePicker2.Value.Day).ToString();
        }
    }
}
