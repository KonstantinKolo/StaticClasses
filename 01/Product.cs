using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Product
    {
        private string name;
        private string barcode;
        private double price;
        private double quantity;

        public Product(string name,string barcode, double quantity, double price)
        {
            this.Name = name;
            this.Barcode = barcode;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Barcode
        {
            get { return barcode; }
            set
            {
                barcode = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public double Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }
    }
}
