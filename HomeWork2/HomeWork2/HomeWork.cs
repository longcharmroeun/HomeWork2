using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class HomeWork
    {
        public string[] info { get; private set; }
        public HomeWork()
        {
            info = new string[13];
            info[0] = @"Output to the screen your (brief!!!) CV using the sequence of
MessageBox’es (not less than three). And on the last title there should
be an average number of characters on the page (total number of
characters in the CV / number of MessageBox’es). ";
            info[1] = @"Write a function that “guesses” a number from 1 to 2000 conceived
by the user. MessageBox should be used for the query to the user.
Once the number is guessed, it is necessary to display the number of
queries it took to do so, and allow the user to play once again without
exiting the program (MessageBox’es should be with buttons and icons
according to the situation).";
            info[2] = @"Imagine that on the form you have a rectangle, the borders of which
are spaced by 10 pixels from the boundaries of the form working area.
You should create the following handlers:

■ Left mouse button click handler, which displays a message about
  where the current point is: within the rectangle, outside, on the
  border of the rectangle. If the Control (Ctrl) key is pressed when
  you click the left mouse button, the application should be closed.
  Imagine that on the form you have a rectangle, the borders of which
  are spaced by 10 pixels from the boundaries of the form working area.
  You should create the following handlers:

■ Left mouse button click handler, which displays a message about
   where the current point is: within the rectangle, outside, on the
   border of the rectangle. If the Control (Ctrl) key is pressed when
   you click the left mouse button, the application should be closed.";
            info[3] = @"Imagine that on the form you have a rectangle, the borders of which
are spaced by 10 pixels from the boundaries of the form working area.
You should create the following handlers:
■ Left mouse button click handler, which displays a message about
where the current point is: within the rectangle, outside, on the
border of the rectangle. If the Control (Ctrl) key is pressed when
you click the left mouse button, the application should be closed.";
            info[4] = @"Develop an application “runaway static” =). The essence of the
application: on the form there is a static control (“static”). The user
attempts to move the mouse pointer to the “static” and, if the pointer is
close to the static, the control runs away. The static should move only
within the form.";
            info[5] = @"Write a program that determines a day of the week based on the date
entered. The result is output in a text box.";
            info[6] = @"Write a program that computes how much time is left till the
specified date (the date is entered to Edit using the keyboard). Provide
the possibility of displaying the results in years, months, days, minutes,
seconds (for the first two options the answer is fractional). To switch
between the options, it is desirable to use RadioButton’s.";
            info[7] = @"Task formulation.
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
form or in the set of elements.";
            info[8] = @"Create an application with a size of up to 720x480 pixels and place
the required controls on the main form to get information:
■ Surname;
■ Name;
■ Patronymic;
■ Sex;
■ Date of birth;
■ Marital status;
■ Additional info.
Add a Save button and button click handler to save the information
from controls to a file.";
            info[9] = @"Calculate the amount of day between the date selected using
DateTimePicker and output the result on the form using the Label
control. The main window form is to be in the form of ellipsis.";
            info[10] = @"A user enters his/her date of birth in TextBox element. The program
selects and displays the specified day in the MonthCalendar control.";
            info[11] = @"Write an application that displays the amount of text read from a
file using the ProgressBar.";
            info[12] = @"Write an application-questionnaire to be filled in by the user: name,
surname, e-mail, phone number. After clicking the Add button, the
user data goes to the ListBox, wherein there is information about all
users. Also, in ListBox, when cliking a string with information about
a user, there should be the possibility to delete this user from the
collection of ListBox element, as well as to edit. Information about a
user can be edited by substituting data from ListBox to appropriate
fields for inputting new information.
Provide for:

■ Import/export of all the information about users into a text file;
■ Import/export of all the information about users into a *.xml file.";

        }
    }
}
