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
using System.Windows.Forms;

namespace NDPOdev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // OBJECTS ARE IDENTIFIED
        Random rnd;
        LedTV ledtv;
        Fridge fridge;
        Laptop laptop;
        MobilePhone mobilePhone;
        Cart cart = new Cart();
        private void Form1_Load(object sender, EventArgs e)
        {
            // OBJECTS CREATED
            rnd = new Random();

            ledtv = new LedTV(rnd, "49 inç", "4K Ultra HD", "Led TV", "LG", "49SM8200PLA", "4K NanoCell Led TV", 4000, 0);
            fridge = new Fridge(rnd, "505 L", "A++", "Fridge", "BEKO", "970505 EI", "No Frost", 3500, 0);
            laptop = new Laptop(rnd, "15,6 inç", "1920x1080", "256 GB SSD", "16 GB", "62 WH", "Laptop", "MONSTER", "Abra A5 V9.2.2", "Gaming Laptop", 6000, 0);
            mobilePhone = new MobilePhone(rnd, "256 GB", "8 GB", "4200 mAh", "Mobile Phone", "HUAWEI", "P30 PRO", "3-Camera Phone", 2500, 0);

            // THE PRICES OF THE PRODUCTS AND THE NUMBER OF STOCKS ARE PRINTED ON THE LABELS ON THE FORM
            lblLedTVPrice.Text = ledtv.RawPrice.ToString();
            lblLedTVStock.Text = ledtv.StockCount.ToString();

            lblFridgePrice.Text = fridge.RawPrice.ToString();
            lblFridgeStock.Text = fridge.StockCount.ToString();

            lblLaptopPrice.Text = laptop.RawPrice.ToString();
            lblLaptopStock.Text = laptop.StockCount.ToString();

            lblMobilePhonePrice.Text = mobilePhone.RawPrice.ToString();
            lblMobilePhoneStock.Text = mobilePhone.StockCount.ToString();
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (cart.SelectedProducts.Count > 0) // Is there any product in the basket?
            {
                MessageBox.Show("You need to clean the cart first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); // If there are items in the basket, we warn them to be cleaned.
            }
            else
            {
                // The number of pieces of the products to be added to the basket is taken.
                int _ledtv = Convert.ToInt32(LedTVQty.Value), _fridge = Convert.ToInt32(FridgeQty.Value), _laptop = Convert.ToInt32(LaptopQty.Value), _mobilePhone = Convert.ToInt32(MobilePhoneQty.Value);

                // Checking if the product is in stock
                if (_ledtv > ledtv.StockCount || _fridge > fridge.StockCount || _laptop > laptop.StockCount || _mobilePhone > mobilePhone.StockCount)
                {
                    MessageBox.Show("Out of stock!");
                }
                else
                {
                    // TRANSFERRING INFORMATION ABOUT HOW MANY ARE SELECTED TO OBJECTS
                    ledtv.SelectedPieces = _ledtv;
                    fridge.SelectedPieces = _fridge;
                    laptop.SelectedPieces = _laptop;
                    mobilePhone.SelectedPieces = _mobilePhone;

                    if (_ledtv > 0) // If there was a selection of pieces from the TV
                    {
                        cart.AddToCart(ledtv); // Adding product to cart
                        lstCount.Items.Add(_ledtv); // The number of products added is written to the list in the form
                        lstProducts.Items.Add(ledtv.Name); // The added product name is written to the list in the form.
                        lstTaxIncludedPrice.Items.Add(ledtv.IncludeTax()); // The taxed price of the added product is written in the list on the form.
                    }
                    if (_fridge > 0) // If there was a selection of pieces from the fridge
                    {
                        cart.AddToCart(fridge); // Adding product to cart
                        lstCount.Items.Add(_fridge); // The number of products added is written to the list in the form
                        lstProducts.Items.Add(fridge.Name); // The added product name is written to the list in the form.
                        lstTaxIncludedPrice.Items.Add(fridge.IncludeTax()); // The taxed price of the added product is written in the list on the form.
                    }
                    if (_laptop > 0) // If there was a selection of pieces from the laptop
                    {
                        cart.AddToCart(laptop); // Adding product to cart
                        lstCount.Items.Add(_laptop); // The number of products added is written to the list in the form
                        lstProducts.Items.Add(laptop.Name); // The added product name is written to the list in the form.
                        lstTaxIncludedPrice.Items.Add(laptop.IncludeTax()); // The taxed price of the added product is written in the list on the form.
                    }
                    if (_mobilePhone > 0) // If there was a selection of pieces from the mobile phone
                    {
                        cart.AddToCart(mobilePhone); // Adding product to cart
                        lstCount.Items.Add(_mobilePhone); // The number of products added is written to the list in the form
                        lstProducts.Items.Add(mobilePhone.Name); // The added product name is written to the list in the form.
                        lstTaxIncludedPrice.Items.Add(mobilePhone.IncludeTax()); // The taxed price of the added product is written in the list on the form.
                    }

                    lblTotalPrice.Text = (cart.TotalPrice).ToString() + " TL"; // The calculated total price is printed on the lables on the form

                    // CURRENT STOCK QUANTITIES OF PRODUCTS ARE PRINTED ON THE FORM LABELS
                    lblLedTVStock.Text = ledtv.StockCount.ToString();
                    lblFridgeStock.Text = fridge.StockCount.ToString();
                    lblLaptopStock.Text = laptop.StockCount.ToString();
                    lblMobilePhoneStock.Text = mobilePhone.StockCount.ToString();
                }
            }
        }

        private void btnSepetiTemizle_Click(object sender, EventArgs e)
        {
            cart.ClearCart(this, ledtv, fridge, laptop, mobilePhone); // We call the emptying method in the cart class
        }
    }
}