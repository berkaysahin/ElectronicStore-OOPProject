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

namespace NDPOdev3
{
    public abstract class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string feature;
        public string Feature
        {
            get { return feature; }
            set { feature = value; }
        }

        private int stockCount;
        public int StockCount
        {
            get { return stockCount; }
            set { stockCount = value; }
        }

        private double rawPrice;
        public double RawPrice
        {
            get { return rawPrice; }
            set { rawPrice = value; }
        }

        private int selectedPieces;
        public int SelectedPieces
        {
            get { return selectedPieces; }
            set { selectedPieces = value; }
        }

        public abstract double IncludeTax();
    }
}
