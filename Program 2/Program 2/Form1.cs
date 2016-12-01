//Megan Balcom
//CIS 199-01
//Program #2
//March 10, 2015
//This program tells a student the earliest day and time they can
//register for classes based on the first letter of their last name
//along with their class standing. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            //Define local variables.
            //Holds the inputted letter of the last name and 
            //initializes it with the student's input.
            string lastName = lastNameTextBox.Text; 
            char lastNameLetter = lastNameTextBox.Text[0];

            //Define registration date and time strings
            string outputMessage = "The earliest date and time you can register is "; 
                                    //The beginning of the output message
            string seniorRegistrationDate = "Wednesday, April 1, 2015 "; //Senior registration date
            string juniorRegistrationDate = "Thursday, April 2, 2015 "; //Junior registration date
            string sophomoreRegistrationDate_1 = "Friday, April 3, 2015 "; //Sophomore registration date #1
            string sophomoreRegistrationDate_2 = "Monday, April 6, 2015 "; //Sophomore registration date #2
            string freshmanRegistrationDate_1 = "Tuesday, April 7, 2015 "; //Freshman registration date #1
            string freshmanRegistrationDate_2 = "Wednesday, April 8, 2015 "; //Freshman registration date #2
            string eight_30_AM = "at 8:30 AM."; //8:30 AM
            string ten_AM = "at 10:00 AM."; //10:00 AM
            string eleven_30_AM = "at 11:30 AM"; //11:30 AM
            string two_PM = "at 2:00 PM"; //2:00 PM
            string four_PM = "at 4:00 PM"; //4:00 PM

            //Test to see if the user has entered anything in the textbox,
            //if they haven't prompt them to enter a letter. And accept both 
            //upper and lowercase letters.
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a letter.");
            }
            else if (char.IsLetter(lastNameLetter))
                lastNameLetter = char.ToUpper(lastNameLetter);
                    
                

            //If the senior radio button is checked the following date and various times will be 
            //displayed based on what letter of the alphabet is entered.
            if (seniorRadioButton.Checked)
                if (lastNameLetter <= 'D')
                {
                    MessageBox.Show(outputMessage + seniorRegistrationDate + ten_AM);
                }
                else if (lastNameLetter <= 'I')
                {
                    MessageBox.Show(outputMessage + seniorRegistrationDate + eleven_30_AM);
                }
                else if (lastNameLetter <= 'O')
                {
                    MessageBox.Show(outputMessage + seniorRegistrationDate + two_PM);
                }
                else if (lastNameLetter <= 'S')
                {
                    MessageBox.Show(outputMessage + seniorRegistrationDate + four_PM);
                }
                else if (lastNameLetter <= 'T')
                {
                MessageBox.Show(outputMessage + seniorRegistrationDate + eight_30_AM);
                }

            //If the junior radio button is checked the following date and various times will be 
            //displayed based on what letter of the alphabet is entered (uppercase or lowercase).
            if (juniorRadioButton.Checked)
                if (lastNameLetter <= 'D')
                {
                    MessageBox.Show(outputMessage + juniorRegistrationDate + ten_AM);
                }
                else if (lastNameLetter <= 'I')
                {
                    MessageBox.Show(outputMessage + juniorRegistrationDate + eleven_30_AM);
                }
                else if (lastNameLetter <= 'O')
                {
                    MessageBox.Show(outputMessage + juniorRegistrationDate + two_PM);
                }
                else if (lastNameLetter <= 'S')
                {
                    MessageBox.Show(outputMessage + juniorRegistrationDate + four_PM);
                }
                else if (lastNameLetter <= 'T')
                {
                    MessageBox.Show(outputMessage + juniorRegistrationDate + eight_30_AM);
                }

            //If the sophomore radio button is checked the following date and various times will be 
            //displayed based on what letter of the alphabet is entered.
            if (sophomoreRadioButton.Checked)
                if (lastNameLetter <= 'B')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_1 + eleven_30_AM);
                }
                else if (lastNameLetter <= 'D')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_1 + two_PM);
                }
                else if (lastNameLetter <= 'F')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_1 + four_PM);
                }
                else if (lastNameLetter <= 'I')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_2 + eight_30_AM);
                }
                else if (lastNameLetter <= 'L')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_2 + ten_AM);
                }
                else if (lastNameLetter <= 'O')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_2 + eleven_30_AM);
                }
                else if (lastNameLetter <= 'Q')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_2 + two_PM);
                }
                else if (lastNameLetter <= 'S')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_2 + four_PM);
                }
                else if (lastNameLetter <= 'V')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_1 + eight_30_AM);
                }
                else if (lastNameLetter <= 'Z')
                {
                    MessageBox.Show(outputMessage + sophomoreRegistrationDate_1 + ten_AM);
                }


            //If the freshman radio button is checked the following date and various times will be 
            //displayed based on what letter of the alphabet is entered.
             if (freshmanRadioButton.Checked)
                if (lastNameLetter <= 'B')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_1 + eleven_30_AM);
                }
                else if (lastNameLetter <= 'D')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_1 + two_PM);
                }
                else if (lastNameLetter <= 'F')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_1 + four_PM);
                }
                else if (lastNameLetter <= 'I')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_2 + eight_30_AM);
                }
                else if (lastNameLetter <= 'L')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_2 + ten_AM);
                }
                else if (lastNameLetter <= 'O')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_2 + eleven_30_AM);
                }
                else if (lastNameLetter <= 'Q')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_2 + two_PM);
                }
                else if (lastNameLetter <= 'S')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_2 + four_PM);
                }
                else if (lastNameLetter <= 'V')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_1 + eight_30_AM);
                }
                else if (lastNameLetter <= 'Z')
                {
                    MessageBox.Show(outputMessage + freshmanRegistrationDate_1 + ten_AM);
                } 
           
                }
            }

        }
    

