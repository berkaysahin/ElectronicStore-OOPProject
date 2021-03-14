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
using System.Collections.Generic;

namespace NDPOdev3
{
    public class Cart
    {
        private double totalPrice = 0;
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public List<Product> SelectedProducts = new List<Product>(); // List object to keep selected products 

        public void AddToCart(Product urun) // Adds item to the cart 
        {
            TotalPrice += urun.IncludeTax(); // The total amount is calculated with the prices of the products including tax. 
            urun.StockCount -= urun.SelectedPieces; // The number of products taken from the stock is reduced
            SelectedProducts.Add(urun); // The selected product has been added to the list
        }

        public void ClearCart(Form1 f1, LedTV led, Fridge fridge, Laptop laptop, MobilePhone phone) // Since the items on the form will also change when emptying the basket, we have taken the form itself as a parameter
        {
            for (int i = 0; i < SelectedProducts.Count; i++)
            {
                if (f1.lstProducts.Items[i].ToString() == "Fridge") // If the item on the list is a fridge 
                    fridge.StockCount += Convert.ToInt32(f1.lstCount.Items[i].ToString()); // Returning the number of products to stocks
                else if (f1.lstProducts.Items[i].ToString() == "Mobile Phone") // If the item on the list is a mobile phone 
                    phone.StockCount += Convert.ToInt32(f1.lstCount.Items[i].ToString()); // Returning the number of products to stocks
                else if (f1.lstProducts.Items[i].ToString() == "Laptop") // If the item on the list is a laptop
                    laptop.StockCount += Convert.ToInt32(f1.lstCount.Items[i].ToString()); // Returning the number of products to stocks
                else // LedTv
                    led.StockCount += Convert.ToInt32(f1.lstCount.Items[i].ToString()); // Returning the number of products to stocks
            }

            // EMPTYING THE CONTENTS OF THE LIST
            f1.lstCount.Items.Clear();
            f1.lstTaxIncludedPrice.Items.Clear();
            f1.lstProducts.Items.Clear();

            f1.lblTotalPrice.Text = "0 TL";

            // Current stock quantities are printed 
            f1.lblLedTVStock.Text = led.StockCount.ToString();
            f1.lblFridgeStock.Text = fridge.StockCount.ToString();
            f1.lblLaptopStock.Text = laptop.StockCount.ToString();
            f1.lblMobilePhoneStock.Text = phone.StockCount.ToString();

            SelectedProducts.Clear(); // Reset the selected products list
            TotalPrice = 0;
        }
    }
}