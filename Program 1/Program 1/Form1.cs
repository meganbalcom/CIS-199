//Megan Balcom
//Program #1
//CIS 199-01
//February 16, 2015
//This program calculates and displays six outputs (total square feet, number
//of gallons, hours of labor, cost of paint, cost of labor, and the total cost
//of the paint job based on three inputted values (square feet, coats desired,
//and price per gallon). 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class program1Form : Form
    {
        public program1Form()
        {
            InitializeComponent();
        }
        //This label holds the instructions on the form.
        private void instructions_label_Click(object sender, EventArgs e)
        {

        }

        private void calculateCostButton_Click(object sender, EventArgs e)
        {
            //Defined constant variables. 
            const double LABOR_RATE = 10.5; //The constant cost of labor per hour.
            const double GALLONS_REQUIRED = 325; //The number of square feet per one gallon.
            const double HOURS_REQUIRED = 8; //The number of hours required per one gallon. 
            //Other defined variables.
            double inputSqFt; //Holds the inputted square feet in the sqftInputTextBox.
            double paintPrice; //Holds the inputted price per gallon in the gallonPriceInput Textbox.
            double coatsDesired; //Holds the number of coats desired in the coatsDesired Textbox.
            double totalSqFt; //Holds the total square footage to be painted (original sq ft * coats).
            double totalGallons; //Holds the total number of gallons required.
            double totalLaborTime; //Holds the total amount of labor required.
            double totalCostOfPaint; //Holds the total cost of the paint itself.
            double laborCost; //Holds the total labor cost of the paint job.
            double totalCost; //Holds the total cost of the paint job.

            //Take the inputs and turn them into numeric values.
            inputSqFt = double.Parse(sqftInputTextBox.Text); 
            coatsDesired = double.Parse(coatsDesiredTextBox.Text);
            paintPrice = double.Parse(gallonPriceInputTextBox.Text);

            //Calculate the total number of square feet to be painted
            //and display it in an output label.
            totalSqFt = inputSqFt * coatsDesired;
            totalSqFtOutputLabel.Text = totalSqFt.ToString("F1");

            //Calculate the number of gallons required for the paint job
            //and display it in an output label.
            totalGallons = Math.Ceiling(totalSqFt / GALLONS_REQUIRED);
            numberGallonsOutputLabel.Text = totalGallons.ToString(); 

            //Calculate the hours of labor required to complete the paint job
            //and display it in an output label.
            totalLaborTime = (totalSqFt / GALLONS_REQUIRED) * HOURS_REQUIRED;
            hoursLaborOutputLabel.Text = totalLaborTime.ToString("F1");

            //Calculate the cost of paint for the paint job 
            //and display it in an output label.
            totalCostOfPaint = totalGallons * paintPrice;
            costPaintOutputLabel.Text = totalCostOfPaint.ToString("c");

            //Calculate the cost of labor
            //and display it in an output label.
            laborCost = totalLaborTime * LABOR_RATE;
            costLaborOutputLabel.Text = laborCost.ToString("c");

            //Calculate the total cost of the paint job
            //and display it in an output label.
            totalCost = totalCostOfPaint + laborCost;
            totalCostOutputLabel.Text = totalCost.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearInputButton_Click(object sender, EventArgs e)
        {
            //Clears the inputted textbox data.
            sqftInputTextBox.Clear();
            coatsDesiredTextBox.Clear();
            gallonPriceInputTextBox.Clear();
        }
    }
}
