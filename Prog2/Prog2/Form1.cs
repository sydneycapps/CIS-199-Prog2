//B3697
//Program 2
//Oct. 19
//CIS 199-75
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }
        //Event Handler for the check your registration date and time button
        private void checkButton_Click(object sender, EventArgs e)
        {
            char initial;                                  // Variable for the user's first initial of their last name
            const string SEN_DATE = "Friday, Nov. 3";      // Senior registration date
            const string JUN_DATE = "Monday, Nov. 6";      // Junior registration date
            const string SOPH_DATE1 = "Tuesday, Nov. 7";   // The first Sophomore registration date 
            const string SOPH_DATE2 = "Wednesday, Nov. 8"; // The second Sophomore registration date 
            const string FRESH_DATE1 = "Thursday, Nov. 9"; // The first Freshman registration date 
            const string FRESH_DATE2 = "Friday, Nov. 10";  // The second Freshman registration date 
            const string TIME1 = "8:30 AM";                // The first registration time
            const string TIME2 = "10:00 AM";               // The second registration time
            const string TIME3 = "11:30 AM";               // The third registration time
            const string TIME4 = "2:00 PM";                // The fourth registration time
            const string TIME5 = "4:00 PM";                // The fifth registration time

            char.TryParse(initialBox.Text, out initial);   // Converts input into char 
            initial = char.ToUpper(initial);               // Converts the user's initial to an uppercase letter

            // Series of if-else statements to determine registration date, given class standing and initial for Freshman and Sophomores
            if (senButton.Checked)
                dateBox.Text = (SEN_DATE);
            else if (junButton.Checked)
                dateBox.Text = (JUN_DATE);
            else if (sophButton.Checked && (initial >= 'G' && initial <= 'S'))
                dateBox.Text = (SOPH_DATE2);
            else if (sophButton.Checked)
                dateBox.Text = (SOPH_DATE1);
            else if (freshButton.Checked && (initial >= 'G' && initial <= 'S'))
                dateBox.Text = (FRESH_DATE2);
            else
                dateBox.Text = (FRESH_DATE1);

            // Series of if-else statements to determine registration time, given class standing and initial
            if (((senButton.Checked || junButton.Checked) && (initial >= 'T' && initial <= 'Z')) ||
                ((sophButton.Checked || freshButton.Checked) && (initial >= 'G' && initial <= 'I') || 
                (initial >= 'T' && initial <= 'V')))
                timeBox.Text = (TIME1);
            else if (((senButton.Checked || junButton.Checked) && (initial >= 'A' && initial <= 'D')) || 
                ((sophButton.Checked || freshButton.Checked) && (initial >= 'J' && initial <= 'L') || 
                (initial >= 'W' && initial <= 'Z'))) 
                timeBox.Text = (TIME2);
            else if (((senButton.Checked || junButton.Checked) && (initial >= 'E' && initial <= 'I')) || 
                ((sophButton.Checked || freshButton.Checked) && (initial == 'A' || initial == 'B') || 
                (initial >= 'M' && initial <= 'O')))
                timeBox.Text = (TIME3);
            else if (((senButton.Checked || junButton.Checked) && (initial >= 'J' && initial <= 'O')) ||
                ((sophButton.Checked || freshButton.Checked) && (initial == 'C' || initial == 'D' || 
                initial == 'P' || initial == 'Q')))
                timeBox.Text = (TIME4);
            else
                timeBox.Text = (TIME5);
        }
    }
}
