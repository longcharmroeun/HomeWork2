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
using System.Xml.Linq;

/*Task 1
Create an application with a size of up to 720x480 pixels and place
the required controls on the main form to get information:
■ Surname;
■ Name;
■ Patronymic;
■ Sex;
■ Date of birth;
■ Marital status;
■ Additional info.
Add a Save button and button click handler to save the information
from controls to a file.*/


namespace HomeWork2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog1.FilterIndex == 1)
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.WriteLine($"Surname : {textBox3.Text}");
                        sw.WriteLine($"Name : {textBox2.Text}");
                        sw.WriteLine($"Patronymic : {textBox1.Text}");
                        sw.WriteLine($"Sex : {textBox6.Text}");
                        sw.WriteLine($"Marital status : {textBox5.Text}");
                        sw.WriteLine($"Date of birth; : {dateTimePicker1.Text}");
                        sw.WriteLine($"Additional info : {richTextBox1.Text}");
                    }
                }
                if(saveFileDialog1.FilterIndex == 2)
                {
                    XElement xml = new XElement("Persons",
                    new XElement("Person",
                    new XElement("Surname", textBox3.Text),
                    new XElement("Name", textBox2.Text),
                    new XElement("Sex", textBox6.Text),
                    new XElement("Marital_status", textBox5.Text),
                    new XElement("Date_of_birth",dateTimePicker1.Text),
                    new XElement("Additional_info",richTextBox1.Text)
                    ));
                    xml.Save(saveFileDialog1.FileName);
                }
                
            }
        }
    }
}
