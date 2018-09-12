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
using System.Xml.Serialization;

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
        Form6Data data = new Form6Data();
        public bool load = false;
        public string Dir,filename;
        public Form6(bool load = false, string Dir = null, string filename = null)
        {
            InitializeComponent();
            if (load)
            {
                this.load = load;
                this.Dir = Dir;
                this.filename = filename;
                saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.FileName = filename;
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.InitialDirectory = Dir;
                Text = filename;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (load)
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Form6Data));
                    using (FileStream fs = new FileStream(Dir, FileMode.Open))
                    {
                        data = xs.Deserialize(fs) as Form6Data;
                    }
                    if (data != null)
                    {
                        textBox1.Text = data.Patronymic;
                        textBox2.Text = data.Name;
                        textBox3.Text = data.Surname;
                        textBox6.Text = data.Sex;
                        textBox5.Text = data.MTstatue;
                        dateTimePicker1.Text = data.DateBt;
                        richTextBox1.Text = data.AddInfo;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog1.FilterIndex == 1)
                {
                    saveFileDialog1.DefaultExt = "txt";
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
                    saveFileDialog1.DefaultExt = "xml";
                    data.Surname = textBox3.Text;
                    data.Name = textBox2.Text;
                    data.Patronymic = textBox1.Text;
                    data.Sex = textBox6.Text;
                    data.MTstatue = textBox5.Text;
                    data.DateBt = dateTimePicker1.Text;
                    data.AddInfo = richTextBox1.Text;
                    FileStream fs = null;
                    XmlSerializer xs = new XmlSerializer(typeof(Form6Data));

                    using (fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        xs.Serialize(fs, data);
                    }
                }
                
            }
        }
    }
}
