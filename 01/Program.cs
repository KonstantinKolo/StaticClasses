using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] commands = input.Split(' ').ToArray();
                while (commands[0] != "Close")
                {
                    if (commands[0] == "Add")
                    {
                        Orders.AddProduct(commands[1], commands[2], double.Parse(commands[3]), double.Parse(commands[4]));
                    }
                    else if (commands[0] == "Sell")
                    {
                        Orders.SellProduct(commands[1], double.Parse(commands[2]));
                    }
                    else if (commands[0] == "Update")
                    {
                        Orders.UpdateProduct(commands[1], double.Parse(commands[2]));
                    }
                    else if (commands[0] == "PrintA")
                    {
                        Orders.PrintA();
                    }
                    else if (commands[0] == "PrintU")
                    {
                        Orders.PrintU();
                    }
                    else if (commands[0] == "PrintD")
                    {
                        Orders.PrintD();
                    }
                    else if (commands[0] == "Calculate")
                    {
                        Orders.Calculate();
                    }
                    input = Console.ReadLine();
                    commands = input.Split(' ').ToArray();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
