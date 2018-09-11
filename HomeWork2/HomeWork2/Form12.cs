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

namespace HomeWork2
{
    public class Data
    {
        public string[] data { get; set; }
        public string[] name { get; set; }
        public Data(int size)
        {
            data = new string[size];
            name = new string[size];
        }
        public Data()
        {
            data = new string[20];
            name = new string[20];
        }
    }
    

    public partial class Form12 : Form
    {
        public string[] text = new string[20];
        public int i = 0;
        public bool isdosth = false;
        Data data = new Data(20);
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(openFileDialog1.SafeFileName);
                text[i] = File.ReadAllText(openFileDialog1.FileName);
                data.data[i] = openFileDialog1.FileName;
                data.name[i] = openFileDialog1.SafeFileName;
                Text = data.data[i];
                i++;
                isdosth = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < 20) richTextBox1.Text = text[listBox1.SelectedIndex];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "listbox";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog1.FilterIndex == 1)
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        if (listBox1.SelectedIndex > 0) sw.WriteLine(text[listBox1.SelectedIndex]);
                    }
                }
                if(saveFileDialog1.FilterIndex == 2)
                {
                    FileStream fs = null;
                    XmlSerializer xs = new XmlSerializer(typeof(Data));

                    using (fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        xs.Serialize(fs, data);
                    }
                }
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Data));
                using (FileStream fs = new FileStream("data.xml", FileMode.Open))
                {
                    data = xs.Deserialize(fs) as Data;
                }
                if (data != null)
                {
                    for (int n = 0; n < 20; n++)
                    {
                        if (data.data[n] != null)
                        {
                            listBox1.Items.Add(data.name[n]);
                            text[i] = File.ReadAllText(data.data[n]);
                            i++;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isdosth)
            {
                DialogResult box = MessageBox.Show("info", "Do you want to save?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (box == DialogResult.Yes)
                {
                    FileStream fs = null;
                    XmlSerializer xs = new XmlSerializer(typeof(Data));

                    using (fs = new FileStream("data.xml", FileMode.Create))
                    {
                        xs.Serialize(fs, data);
                    }
                }
            }  
        }
    }
}
