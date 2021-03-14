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
    public class MobilePhone : Product  // Inherited from the Product class
    {
        private string internalStorage;
        public string InternalStorage
        {
            get { return internalStorage; }
            set { internalStorage = value; }
        }

        private string memoryStorage;
        public string MemoryStorage
        {
            get { return memoryStorage; }
            set { memoryStorage = value; }
        }

        private string batteryCapacity;
        public string BatteryCapacity
        {
            get { return batteryCapacity; }
            set { batteryCapacity = value; }
        }

        public MobilePhone(Random rnd, string storage, string memory, string battery,
                      string name, string brand, string model, string feature, double rawPrice, int selectedPieces)
        {
            // Defining the properties of the product

            InternalStorage = storage;
            MemoryStorage = memory;
            BatteryCapacity = battery;
            
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
            return (RawPrice * 1.20 * SelectedPieces); // Returning the taxed price of the product
        }
    }
}
