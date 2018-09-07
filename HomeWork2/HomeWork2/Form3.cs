using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Task 4
Develop an application created on the basis of the form.
■ The user “clicks” on the form with the left mouse button and,
without releasing the button, moves the mouse over the form, and
when releasing the button a “static” should be created according
to the received coordinates of a rectangle (you, for sure, know that
two points are enough to create a rectangle on a plane); the “static”
should contain its sequence number (the order of appearance on
the form).
■ Minimal size of the “static” is 10х10; while trying to create a smaller
element the user should see a warning.
■ If you right-click over the surface of the “static”, information about
the area and its coordinates (on the form) should appear in the
window title bar. If in the point of click there are several “statics”,
the preference is given to the “static” with the highest sequence
number.
■ When you double-click with the left mouse button over the “static”
surface it should disappear from the form. If in the point of click
there are several “statics”, the preference is given to the “static” with
the lowest sequence number.*/


namespace HomeWork2
{
    public partial class Form3 : Form
    {
        MouseEventArgs startPoint;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            Label label = new Label();
            label.Width = Math.Abs(e.X - startPoint.X);
            label.Height = Math.Abs(e.Y - startPoint.Y);
            label.Location = new Point(Math.Min(startPoint.X, e.X)
                , Math.Min(startPoint.Y, e.Y));
            label.BackColor = Color.Red;
            label.MouseDown += new MouseEventHandler(Label_MouseDown);
            this.Controls.Add(label);
            if (label.Width <= 10 && label.Height <= 10) 
            {
                MessageBox.Show("Warning", "Minimal size of the “static” is 10х10", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Label label = (Label)sender;
                Text = $"Location: (X={label.Location.X},Y=" +
                    $"{label.Location.Y})";
            } 
        }

    }
}
