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
    public class Fridge : Product // Inherited from the Product class
    {
        private string internalVolume;
        public string InternalVolume
        {
            get { return internalVolume; }
            set { internalVolume = value; }
        }

        private string energyClass;
        public string EnergyClass
        {
            get { return energyClass; }
            set { energyClass = value; }
        }

        public Fridge(Random rnd, string volume, string energy, string name,
                         string brand, string model, string feature, double rawPrice, int selectedPieces)
        {
            // Defining the properties of the product

            InternalVolume = volume;
            EnergyClass = energy;
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
            return (RawPrice * 1.05 * SelectedPieces); // Returning the taxed price of the product
        }
    }
}
