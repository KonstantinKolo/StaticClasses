using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    static class Orders
    {
        static Dictionary<Product, double> dict = new Dictionary<Product, double>();

        public static void SellProduct(string barcode, double quantity)
        {
            var product = dict.First(x => x.Key.Barcode == barcode);
            if (dict.ContainsKey(product.Key))
            {
                if (product.Value >= quantity)
                {
                    dict[product.Key] = product.Value - quantity;
                }
                else
                {
                    throw new ArgumentException("Not enough quantity!");
                }
            }
            else
            {
                throw new ArgumentException("Product does not exist!");
            }
        }
        public static void AddProduct(string barcode,string name,double price,double quantity)
        {
            Product product = new Product(name, barcode,quantity,price);
            //var product = dict.First(x => x.Key.Barcode == barcode);
            if (dict.ContainsKey(product))
            {
                throw new ArgumentException("Product already exists!");
            }
            else
            {
                dict.Add(product, quantity);
            }
        }
        public static void UpdateProduct(string barcode, double quantity)
        {
            var product = dict.First(x => x.Key.Barcode == barcode);
            if (dict.ContainsKey(product.Key))
            {
                dict[product.Key] = product.Value + quantity;
            }
            else
            {
                throw new ArgumentException("Product does not exist!");
            }
        }
        public static void PrintA()
        {            
            var sortedDict = new Dictionary<Product, double>(dict);
            foreach (KeyValuePair<Product, double> author in dict)
            {
                if (author.Value > 0)
                {
                    Console.WriteLine("{0} ({1:F2})", author.Key.Name, author.Key.Barcode);
                }
            }
        }
        public static void PrintU()
        {
            foreach (KeyValuePair<Product, double> author in dict.OrderBy(key => key.Key))
            {
                if (author.Value <= 0)
                {
                    Console.WriteLine("{0} ({1:F2})", author.Key.Name, author.Key.Barcode);
                }
            }
        }
        public static void PrintD()
        {
            foreach (KeyValuePair<Product, double> author in dict.OrderByDescending(value => value.Value))
            {
                Console.WriteLine("{0} ({1:F2})", author.Key.Name, author.Key.Barcode);
            }
        }
        public static void Calculate()
        {
            double finalPrice = 0;
            foreach (KeyValuePair<Product, double> author in dict)
            {
                finalPrice += author.Value * author.Key.Price;
            }          
                Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
