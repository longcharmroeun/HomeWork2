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

    public partial class Form5 : Form
    {
        public const float Regular = 4100f, MidGrade = 4200f, Premium = 4500f;
        public const float Hotdog = 5000f, hambuger = 6100f, Frenchfries = 7600f, Cocacola = 5400f;
        public Form5()
        {
            InitializeComponent();
        }

        private void Amount1_CheckedChanged(object sender, EventArgs e)
        {
            if(Amount2.Checked == true)
            {
                Amount2.Checked = false;
                if(TextAmount2.Enabled == true)
                {
                    TextAmount2.Enabled = false;
                }
            }
            if(TextAmount1.Enabled == false) TextAmount1.Enabled = true;
            if (Amount1.Checked == false)
            {
               if(TextAmount1.Enabled == true) TextAmount1.Enabled = false;
            }
        }

        private void Amount2_CheckedChanged(object sender, EventArgs e)
        {
            if (Amount1.Checked == true)
            {
                Amount1.Checked = false;
                if (TextAmount1.Enabled == true)
                {
                    TextAmount1.Enabled = false;
                }
            }
            if(TextAmount2.Enabled == false) TextAmount2.Enabled = true;
            if (Amount2.Checked == false)
            {
                if(TextAmount2.Enabled == true) TextAmount2.Enabled = false;
            }
        }
        private void TextAmount1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void TextAmount2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TextAmount2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Regular"))
                    {
                        TextAmount1.Text = String.Format("{0:f3}", (Convert.ToDouble(TextAmount2.Text) / Regular));
                        TextAmount2.Text = String.Format("{0:N}", Convert.ToDouble(TextAmount2.Text));
                        GasolinePayable.Text = TextAmount2.Text;
                    }
                    else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("MidGrade"))
                    {
                        TextAmount1.Text = String.Format("{0:f3}", (Convert.ToDouble(TextAmount2.Text) / MidGrade));
                        TextAmount2.Text = String.Format("{0:N}", Convert.ToDouble(TextAmount2.Text));
                        GasolinePayable.Text = TextAmount2.Text;
                    }
                    else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Premium"))
                    {
                        TextAmount1.Text = String.Format("{0:f3}", (Convert.ToDouble(TextAmount2.Text) / Premium));
                        TextAmount2.Text = String.Format("{0:N}", Convert.ToDouble(TextAmount2.Text));
                        GasolinePayable.Text = TextAmount2.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TextAmount1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Regular"))
                    {
                        TextAmount2.Text = String.Format("{0:N}", (Convert.ToDouble(TextAmount1.Text) * Regular));
                        GasolinePayable.Text = TextAmount2.Text;
                    }
                    else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("MidGrade"))
                    {
                        TextAmount2.Text = String.Format("{0:N}", (Convert.ToDouble(TextAmount1.Text) * MidGrade));
                        GasolinePayable.Text = TextAmount2.Text;
                    }
                    else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Premium"))
                    {
                        TextAmount2.Text = String.Format("{0:N}", (Convert.ToDouble(TextAmount1.Text) * Premium));
                        GasolinePayable.Text = TextAmount2.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if(hotdog.Checked == true)
            {
                if (hotdogamount.Enabled == false) hotdogamount.Enabled = true;
            }
            else if(hotdog.Checked == false)
            {
                if (hotdogamount.Enabled == true) {
                    hotdogamount.Enabled = false;
                    hotdogamount.Text = "0";
                } 
            }
        }

        private void hotdogamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cafepayable.Text = String.Format("{0:N}", (Convert.ToDouble(hotdogamount.Text) * Hotdog) + Convert.ToDouble(hamburgeramount.Text) * hambuger +
                    Convert.ToDouble(frenchfriesamount.Text) * Frenchfries + Convert.ToDouble(cocacolaamount.Text) * Cocacola);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hamburgeramount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cafepayable.Text = String.Format("{0:N}", (Convert.ToDouble(hotdogamount.Text) * Hotdog) + Convert.ToDouble(hamburgeramount.Text) * hambuger +
                    Convert.ToDouble(frenchfriesamount.Text) * Frenchfries + Convert.ToDouble(cocacolaamount.Text) * Cocacola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frenchfriesamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cafepayable.Text = String.Format("{0:N}", (Convert.ToDouble(hotdogamount.Text) * Hotdog) + Convert.ToDouble(hamburgeramount.Text) * hambuger +
                    Convert.ToDouble(frenchfriesamount.Text) * Frenchfries + Convert.ToDouble(cocacolaamount.Text) * Cocacola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cocacolaamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cafepayable.Text = String.Format("{0:N}", (Convert.ToDouble(hotdogamount.Text) * Hotdog) + Convert.ToDouble(hamburgeramount.Text) * hambuger +
                    Convert.ToDouble(frenchfriesamount.Text) * Frenchfries + Convert.ToDouble(cocacolaamount.Text) * Cocacola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hotdogamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void hamburgeramount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void frenchfriesamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cocacolaamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void count_Click(object sender, EventArgs e)
        {
            totaltext.Text = String.Format("{0:N}", Convert.ToDouble(GasolinePayable.Text) + Convert.ToDouble(cafepayable.Text));
        }
        private void hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if(hamburger.Checked == true)
            {
                if (hamburgeramount.Enabled == false) hamburgeramount.Enabled = true;
            }
            else if (hamburger.Checked == false)
            {
                if (hamburgeramount.Enabled == true) {
                    hamburgeramount.Enabled = false;
                    hamburgeramount.Text = "0";
                }
            }
        }

        private void frenchfries_CheckedChanged(object sender, EventArgs e)
        {
            if(frenchfries.Checked == true)
            {
                if(frenchfriesamount.Enabled == false) frenchfriesamount.Enabled = true; 
            }
            else if(frenchfries.Checked == false)
            {
                if (frenchfriesamount.Enabled == true)
                {
                    frenchfriesamount.Enabled = false;
                    frenchfriesamount.Text = "0";
                }
            }
        }

        private void cocacola_CheckedChanged(object sender, EventArgs e)
        {
            if(cocacola.Checked == true)
            {
                if (cocacolaamount.Enabled == false) cocacolaamount.Enabled = true;
            }
            else if(cocacola.Checked == false)
            {
                if (cocacolaamount.Enabled == true) {
                    cocacolaamount.Enabled = false;
                    cocacolaamount.Text = "0";
                } 
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.FindStringExact("Regular");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == comboBox1.FindStringExact("Regular"))
            {
                Price.Text = Regular.ToString();
                TextAmount2.Text = String.Format("{0:N}", (Convert.ToDouble(TextAmount1.Text) * Regular));
                TextAmount1.Text = String.Format("{0:f3}", (Convert.ToDouble(TextAmount2.Text) / Regular));
                TextAmount2.Text = String.Format("{0:N}", Convert.ToDouble(TextAmount2.Text));
                GasolinePayable.Text = TextAmount2.Text;
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("MidGrade"))
            {
                Price.Text = MidGrade.ToString();
                TextAmount2.Text = String.Format("{0:N}", (Convert.ToDouble(TextAmount1.Text) * MidGrade));
                TextAmount1.Text = String.Format("{0:f3}", (Convert.ToDouble(TextAmount2.Text) / MidGrade));
                TextAmount2.Text = String.Format("{0:N}", Convert.ToDouble(TextAmount2.Text));
                GasolinePayable.Text = TextAmount2.Text;
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Premium"))
            {
                Price.Text = Premium.ToString();
                TextAmount2.Text = String.Format("{0:N}", (Convert.ToDouble(TextAmount1.Text) * Premium));
                TextAmount1.Text = String.Format("{0:f3}", (Convert.ToDouble(TextAmount2.Text) / Premium));
                TextAmount2.Text = String.Format("{0:N}", Convert.ToDouble(TextAmount2.Text));
                GasolinePayable.Text = TextAmount2.Text;
            }
        }
    }
}
