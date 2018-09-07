using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Task 5
Develop an application “runaway static” =). The essence of the
application: on the form there is a static control (“static”). The user
attempts to move the mouse pointer to the “static” and, if the pointer is
close to the static, the control runs away. The static should move only
within the form.*/


namespace HomeWork2
{
    public partial class Form4 : Form
    {
        public int x, y;
        public Random random = new Random();
        public Form4()
        {
            InitializeComponent();
            x = TextLabel.Location.X;
            y = TextLabel.Location.Y;
        }

        private void TextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if(!(x >= 0 && x < this.Width - TextLabel.Size.Width && y >= 0 && y < this.Height - TextLabel.Size.Height - 40))
            {
                TextLabel.Location = new Point(100, 100);
                x = 100;
                y = 100;
            }
            if (random.Next(1, 5) == 1)
            {
                TextLabel.Location = new Point(x -= 5, y);
            }
            else if (random.Next(1, 5) == 2)
            {
                TextLabel.Location = new Point(x += 5, y);
            }
            else if (random.Next(1, 5) == 3)
            {
                TextLabel.Location = new Point(x, y -= 5);
            }
            else if (random.Next(1, 5) == 4)
            {
                TextLabel.Location = new Point(x, y += 5);
            }
        }
    }
}
