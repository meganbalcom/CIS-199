// Megan Balcom
// Program 4
// CIS 199-01
// Due: 4/26/2015

// File: GroundPackage.cs
// This file creates a GroundPackage class capable of tracking
// the origin zip code, destination zip code, length, width, height,
// and weight of a package. 

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
    public class GroundPackage
    {
        //Field
        private int _originZip; //Package's origin zip code
        private int _destinationZip; //Package's destination zip code
        private double _length; //Package's length
        private double _width; //Package's width
        private double _height; //Package's height
        private double _weight; //Package's weight

        //Constructor
        //Precondtion: o and d are both >= 00000 & <= 99999, and l, w, h, and lb are all > 0    
        //Postcondition: 
        public GroundPackage (int o, int d, double l, double w, double h, double lb)
        {
            //Use properties to set in case invalid data sent 
            OriginZip = o;
            DestinationZip = d;
            Length = l;
            Width = w;
            Height = h;
            Weight = lb;
        }

        //OriginZip property
        public int OriginZip
        {
            //Preconditions: None
            //Postconditions: The origin zip has been returned 
            get 
            { 
                return _originZip; 
            } //end get
            //Preconditions: The origin zip code is >=0 00000 and <= 99999
            //Postconditions: The origin zip code has been set to the specified value
            set 
            {
                if (value >= 00000 && value <= 99999)
                {
                    _originZip = value;
                }
               
            } //end set
        } //end month property

      
        //Destination property 
        public int DestinationZip
        {
            //Preconditions: None
            //Postconditions: The destination zip has been returned
            get 
            {
                return _destinationZip; 
            }//end get
            //Precondition:The destination zip code is >=0 and <=99999  
            //Postcondition: The destination zip code has been set to the specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                {
                    _destinationZip = value;
                }
               
                
            } //end set
        } //end Destination property
        
     
        //Length property
        public double Length
        {
            //Preconditions: None
            //Postconditions: The length value has been returned 
            get 
            {
                return _length; 
            } //end get
            //Preconditions: The length value is > 0 
            //Postconditions: The length has been set to the specified value
            set 
            {
                if (value > 0)
                {
                    _length = value;
                }
                
          } //end set
        } //end Length property

        //Width property 
        public double Width
        {
            //Preconditions: None
            //Postconditions: The width value has been returned
            get
            {
                return _width;
            } //end get
            //Preconditions: The width value is > 0 
            //Postconditions: The width has been set to the specified value
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
               
            } //end set
        } //end Width property

        //Height property
        public double Height
        {
            //Preconditions: None
            //Postconditions: The height value has been returned
            get
            {
                return _height;
            } //end get
            //Preconditions: The height value is > 0
            //Postconditions: The height has been set to the specified value
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
               
            } //end set
        } //end Height property

        //Weight property
        public double Weight
        {
            //Preconditions: None 
            //Postconditions: The weight value has been returned 
            get
            {
                return _weight;
            } //end get
            //Preconditions: The weight value is > 0 
            //Postconditions: The weight has been set to the specified value
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }

            } //end set
        } //end Weight property

        //ZoneDistance property
        const int DIVIDE_RATE = 10000;
        public int ZoneDistance
        {
            //Preconditions: None
            //Postconditions: The zone distance value has been returned
            get
            {
                return Math.Abs(_originZip - _destinationZip) / DIVIDE_RATE; 
            } //end get
        } //end ZoneDistance property

        //ToString Method 
        //Precondition: Each variable has been assigned a valid value
        //Postcondition: A string is returned that displays all of the values on separate lines
        public override string ToString()
        {
            string result =
            "Origin Zip:" + " " + OriginZip.ToString("D5") + System.Environment.NewLine + "Destination Zip:" + " " +
            DestinationZip.ToString("D5") + " " + System.Environment.NewLine + "Length:" + " " + Length.ToString() + 
            System.Environment.NewLine + "Width:" + " " + Width.ToString() + System.Environment.NewLine + "Height:" + 
            " " + Height.ToString() + System.Environment.NewLine + "Weight:" + " " + Weight.ToString() + 
            System.Environment.NewLine;

            return result;
        } //end method

        //CalcCost Method
        //Precondition: All variables have valid values
        //Postcondition: A total cost value of the package is returned 
        const double DIMENSION_RATE = 0.20; //Declares package size multiplier value
        const double ZONE_RATE = 0.50; //Declares zone distance multiplier value
        double packageCost; //holds the variable of the cost of package 
        public double CalcCost()
        {
            packageCost = DIMENSION_RATE * (Length + Width + Height) + ZONE_RATE * (ZoneDistance + 1) * (Weight);
            return packageCost;
        }
    }
}
