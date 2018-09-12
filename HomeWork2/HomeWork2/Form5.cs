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
Task formulation.
The owner of a filling station “BestOil” ordered the following
program. When the filling station just begins its work, the owner usually
wants to get the largest possible income, which he/she plans to increase
due to additional services. Therefore, at the filling station a small cafe
will operate. But, at the same time he/she can hire only one employee to
the position of cashier, and therefore the purpose of the program is in
recording the sales of gasoline and product range in mini cafe.

 Requirements for the task.
For convenience, the window is divided into three parts: the first for
the calculations related directly to fueling of vehicles; the second for
calculating the purchase in the mini-cafe; the third part for calculating
the payment amount.
So, the first group of elements – Filling station.
ComboBox is drop-down list with a list of the available fuel. By
default, once you run the program, a certain type of fuel should be
selected in the TextBox (or, for instance, Label), the price for this type
of product should be displayed. At each change of fuel, the price in this
field will change accordingly.
Furthermore, there should a possibility of choice: buy fuel specifying
the required number of liters or specifying the sum of money for
refueling. Thus, after selecting one of the two options of the service,
the unnecessary field becomes blocked. If you enter the amount of
money, the “Amount payable” group will change its name to “Liters
paid”; instead of the sum one should display the number of liters, the
units change from “UAH” to “l” respectively.
The second group – Mini-cafe.
For convenience, all the possible goods are displayed in this part as
once. A CheckBox with the product name is provided for each product,
its price is displayed next (enabled TextBox). Upon the receipt of the
order, one should put a tick in the CheckBox next to the corresponding
product in order to be able to enter the number of units ordered.
The last – Total amount payable.
It contains a button that is responsible for the calculation and display
of amounts in the appropriate fields.
When the amount is displayed, a query to clean the form should
appear 10 seconds later (for example), that is, when the next client
appears: yes – all the fields become default, no – unchanged status
remains for 10 seconds more. When you exit the program (working
day is over) you should see a message box with the total amount of
revenue for the day. Or this amount can be directly output to the form
itself, and change after each client.
In addition, make the form look aesthetic (color, fonts, pictures...).
In case of a justified need and an interesting solution of the program
functionality it is allowed to make changes in the appearance of the
form or in the set of elements.*/

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
