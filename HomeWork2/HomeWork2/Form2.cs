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
 Task 3
Imagine that on the form you have a rectangle, the borders of which
are spaced by 10 pixels from the boundaries of the form working area.
You should create the following handlers:
■ Left mouse button click handler, which displays a message about
where the current point is: within the rectangle, outside, on the
border of the rectangle. If the Control (Ctrl) key is pressed when
you click the left mouse button, the application should be closed.
■ Right mouse button click handler, which in the window title bar
displays information about the size of the client (working) area of
the window in the form: Width = x, Height = y, where x and y are
relevant parameters of your window.
■ Mouse pointer move handler within the working area, which is to
display the current x and y coordinates of the mouse in the title bar.
*/

namespace HomeWork2
{
    public partial class Form2 : Form
    {
        private bool CtrlPressed;
        public Form2()
        {
            InitializeComponent();
        }
        private String CoordinatesToString(MouseEventArgs e)
        {
            return "Mouse coordinates: х=" + e.X.ToString() +
            "; y=" + e.Y.ToString();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordinatesToString(e);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && CtrlPressed) this.Close();
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    Text = CoordinatesToString(e);
                    if ((e.X < 10 || e.Y < 10
                        || e.X > Width - 10 || e.Y > Height - 10))
                    {
                        Text += "; Outside rectangle";
                    }
                    else if ((e.X > 10 && e.Y > 10
                       && e.X < Width - 10 && e.Y < Height - 10))
                    {
                        Text += "; Inside rectangle";
                    }
                    else Text += "; On rectangle";
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) this.CtrlPressed = true;
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            this.CtrlPressed = false;
        }
    }
}
