//Megan Balcom
//CIS 199-01
//Program 3
//April 7, 2015
//This program uses range matching and a while loop to let a user determine what day and time 
//they they can register at the earliest. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class program_3_form : Form
    {
        public program_3_form()
        {
            InitializeComponent();
        }
        //Preconditions: User has to click the button, and has to have a letter inputted
        //Postconditions: Displays what day and time the user can register based on the letter entered 
        private void findRegTimeButton_Click(object sender, EventArgs e)
        {
            const string DAY1 = "April 1";  // 1st day of registration
            const string DAY2 = "April 2"; // 2nd day of registration
            const string DAY3 = "April 3"; // 3rd day of registration
            const string DAY4 = "April 6"; // 4th day of registration
            const string DAY5 = "April 7"; // 5th day of registration
            const string DAY6 = "April 8"; // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration

            lastNameStr = lastNameTxt.Text; //Assigns the entered last name to the text box the user
                                           //will input their last name into 

           
            if (lastNameStr == "") // Empty text box
                MessageBox.Show("Please enter last name!");
            else
            {
                lastNameLetterCh = lastNameStr[0]; //Takes the first letter of the entered last name

                if (!char.IsLetter(lastNameLetterCh)) //Tests to make sure it's a letter 
                    MessageBox.Show("Please ensure a letter is in first position of last name!");
                else
                {
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); //Ensures upper case

                    // Juniors and Seniors share same schedule but different days
                    if (juniorRadioButton.Checked || seniorRadioButton.Checked)
                    {
                        if (seniorRadioButton.Checked)
                            dateStr = DAY1;
                        else // Must be juniors
                            dateStr = DAY2;

                        string[] timeSlots = { TIME2, TIME3, TIME4, TIME5, TIME1 }; //Matching time slots
                                                                                    //for letter array
                        char[] JuniorSeniorLower = { 'A', 'E', 'J', 'P', 'T' }; //Lower range limit testing
                        int sub = JuniorSeniorLower.Length - 1; //the index position 

                        //loop searches the letters array until it finds the correct portion of the array
                        while (sub >= 0 && lastNameLetterCh < JuniorSeniorLower[sub])
                            --sub;
                        timeStr = timeSlots[sub];
                       
                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        if (sophomoreRadioButton.Checked)
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY4;
                            else // All other letters on previous day
                                dateStr = DAY3;
                        }
                        else // must be freshman
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY6;
                            else // All other letters on previous day
                                dateStr = DAY5;
                        }
                        char[] nameRangeLowLimit = { 'A', 'C', 'E', 'G', 'J', 'M', //lower range limits
                                                     'P', 'R', 'T', 'W' };
                        string[] timeSlots = { TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, //Matching time
                                              TIME5, TIME1, TIME2, TIME3 };            //slots for letter ranges
                        int sub = nameRangeLowLimit.Length - 1; //the index position 

                        //loop searches the letters array until it finds the correct portion of the array
                        while (sub >= 0 && lastNameLetterCh < nameRangeLowLimit[sub])
                            --sub;
                        timeStr = timeSlots[sub];
                    }

                    outputLabel.Text = dateStr + " at " + timeStr; //displays what day & time to register
                }
            }
        }
    }
}
