//Megan Balcom
//CIS 199-01
//Program 4
//April 26, 2015
//This program takes the inputted values origin zip code, destination zip, length of the package, length of the package,
//width of the package, height of the package, and weight of the package. All of these values need to be valid in order
//for a package to be created and added to the list. 
//The user will then see the price of the package displayed in the listbox and the user can then choose to send the 
//package to UofL or to send the package from UofL and an updated price will be displayed in place of the original
//price. The user can also click the details button and view details about the package.  

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program_4
{
    public partial class Program_4_Form : Form //Program_4_Form "is a" Form (a.k.a GroundPackageForm)
    {
        public Program_4_Form()
        {
            InitializeComponent();
        }

        public List<GroundPackage> myPackageList = new List<GroundPackage>(); //Creates a new list called myPackageList

        //Add package button
        // Precondition:  User clicked on add package button
        // Postcondition: If user's input are an the valid data types, the bool values are true
        //                they are used in a final if statement which clears the textboxes
        //                and 
        private void addBtn_Click(object sender, EventArgs e)
        {
            int originZipInput = 0; //Origin zip inputted by the user
            int destinationZipInput = 0; //Destination zip inputted by the user
            double lengthValueInput = 0; //Length inputted by the user
            double widthValueInput = 0; //Width inputted by the user
            double heightValueInput = 0; //Height inputted by the user
            double weightValueInput = 0; //Weight inputted by the user
            bool originBool = false; //origin zips that can be parsed and are >=00000 && <= 99999
            bool destinationBool = false; //destination zips that can be parsed and are >=00000 && <=99999
            bool lengthBool = false;//length values that can be parsed and are >0
            bool widthBool = false;//width values that can be parsed and are >0
            bool heightBool = false;//height values that can be parsed and are >0
            bool weightBool = false;//weight values that can be parsed and are >0

            GroundPackage myGroundPackage; //Creates an instance of GroundPackage called myGroundPackage

            //This nested if statement tests to see if all of the 6 values can (1) be parsed and (2) if they
            //fall within the necessary range(s). If they can be parsed, the corresponding bool variable
            //of that value is true. Otherwise an error message appears and specifies what is wrong with the input.
            if (int.TryParse(originZipTxtBox.Text, out originZipInput))
            {
                if (originZipInput >= 00000 && originZipInput <= 99999)
                    originBool = true;
                else
                    MessageBox.Show("Enter a zip code between 00000 and 99999.");
            }
                else
                    MessageBox.Show("Enter a zip code between 00000 and 99999."); //try parse else


            if (int.TryParse(destinationZipTxtBox.Text, out destinationZipInput))
            {
                if (destinationZipInput >= 00000 && destinationZipInput <= 99999)
                    destinationBool = true;
                else
                    MessageBox.Show("Enter a zip code between 00000 and 99999.");
            }
                else
                    MessageBox.Show("Enter a zip code between 00000 and 99999."); //try parse else

            if (double.TryParse(lengthTxtBox.Text, out lengthValueInput))
            {
                if (lengthValueInput > 0)
                    lengthBool = true;
                else
                    MessageBox.Show("Enter a valid numeric length value.");
            }
                else
                    MessageBox.Show("Enter a valid numeric length value."); //try parse else

            if (double.TryParse(widthTxtBox.Text, out widthValueInput))
            {
                if (widthValueInput > 0)
                    widthBool = true;
                else
                    MessageBox.Show("Enter a valid numeric width value.");
            }
                else
                    MessageBox.Show("Enter a valid numeric width value."); //try parse else

            if (double.TryParse(heightTxtBox.Text, out heightValueInput))
            {
                if (heightValueInput > 0)
                    heightBool = true;
                else
                    MessageBox.Show("Enter a numeric height value.");
            }
                else
                    MessageBox.Show("Enter a valid numeric height value."); //try parse else

            if (double.TryParse(weightTxtBox.Text, out weightValueInput))
            {
                if (weightValueInput > 0)
                    weightBool = true;
                else
                    MessageBox.Show("Enter a numeric weight value.");
            }
                else
                    MessageBox.Show("Enter a numeric weight value."); //try parse else 
        
            //If all of the values can be parsed and meet the numeric requirements, then all of their respective 
            //textboxes will clear and a new ground package item will be created. 
            if (originBool && destinationBool && lengthBool && widthBool && heightBool && weightBool)
            {
                originZipTxtBox.Clear();
                destinationZipTxtBox.Clear();
                lengthTxtBox.Clear();
                widthTxtBox.Clear();
                heightTxtBox.Clear();
                weightTxtBox.Clear();

                //New ground package item created
                myGroundPackage = new GroundPackage(originZipInput, destinationZipInput, lengthValueInput,
                                                                    widthValueInput, heightValueInput, weightValueInput);
                myPackageList.Add(myGroundPackage);
                packageListBox.Items.Add(myGroundPackage.CalcCost().ToString("c")); //Displays the cost of the package
                                                                                   //in the listbox. 
            }
        }


        //Details button
        //Preconditions: A package has to have been added to the list
        //Postconditions: A message box will show the selected package's details (origin zip, length, etc.)
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex; //The index position of the package
            MessageBox.Show(myPackageList[index].ToString());
        }

        //Send to UofL button
        //Preconditions:A package has to have been added to the list
        //Postconditions: The package's destination zip will be reset and its new cost will appear in the listbox
        private void sendToLvilleBtn_Click(object sender, EventArgs e)
        {
            const int LOUISVILLE_ZIP = 40292; //Constant Louisville zip code
            int index = packageListBox.SelectedIndex; //The index position of the package
            myPackageList[index].DestinationZip = LOUISVILLE_ZIP; //Assign the Louisville zip code to the selected package's
                                                                 //destination zip
            packageListBox.Items[index] = myPackageList[index].CalcCost().ToString("c"); //Calculate the cost of the selected 
                                                                                        //package and display its price as a string
            //If the package is in the list, its price will update and be displayed 
            if (index > -1)
                MessageBox.Show("The package price will be reset and display the updated price in the listbox.");

        }
        //Send from UofL button
        //Preconditions: A package has to have been added to the list
        //Postconditions: The package's origin zip will be reset and its new cost will appear in the listbox
        private void sendFromLville_Click(object sender, EventArgs e)
        {
            const int LOUISVILLE_ZIP = 40292; //Constant Louisville zip code
            int index = packageListBox.SelectedIndex; //The index position of the package
            myPackageList[index].OriginZip = LOUISVILLE_ZIP; //Assign the Louisville zip code to the selected package's origin zip
            packageListBox.Items[index] = myPackageList[index].CalcCost().ToString("c"); //Calculate the cost of the selected
                                                                                        //package and display its price as a currency string
            //If the package is in the list, its price will update and be displayed
            if (index > -1)
                MessageBox.Show("The package price will be reset and display the updated price in the listbox.");
        }
    }
}


