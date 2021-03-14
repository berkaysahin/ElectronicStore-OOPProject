/****************************************************************************
**					SAKARYA UNIVERSITY
**				FACULTY OF COMPUTER AND INFORMATION SCIENCES
**				COMPUTER ENGINEERING
**				OBJECT ORIENTED PROGRAMMING COURSE
**					2019-2020 FALL SEMESTER
**	
**				HOMEWORK NUMBER...........: 03
**				STUDENT NAME..............: BERKAY ŞAHİN
**				STUDENT NUMBER............: G191210302
**              COURSE GROUP..............: 2C Group
****************************************************************************/

using System;

namespace NDPOdev3
{
    public class LedTV : Product // Inherited from the Product class
    {
        private string screenSize;
        public string ScreenSize
        {
            get { return screenSize; }
            set { screenSize = value; }
        }

        private string screenResolution;
        public string ScreenResolution
        {
            get { return screenResolution; }
            set { screenResolution = value; }
        }


        public LedTV(Random rnd, string size, string resolution, string name,
                     string brand, string model, string feature, double rawPrice, int selectedPieces)
        {
            // Defining the properties of the product

            ScreenSize = size;
            ScreenResolution = resolution;

            Name = name;
            Brand = brand;
            Model = model;
            Feature = feature;
            RawPrice = rawPrice;
            SelectedPieces = selectedPieces;

            StockCount = rnd.Next(1, 100);
        }

        override public double IncludeTax() // Overriding the IncludeTax function in the base class
        {
            return (RawPrice * 1.18 * SelectedPieces); // Returning the taxed price of the product
        }
    }
}
