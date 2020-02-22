using Basics.DataAccess;
using Basics.Model;
using System;

namespace Basics
{
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Product product = new Product();
            ProductInformation productInformation = new ProductInformation();

            //customer.FirstName = "Jok";

            Console.WriteLine("Enter Name : ");
            customer.FirstName = Console.ReadLine();
            
            Console.WriteLine("Hello! " + customer.FirstName);

            Console.WriteLine("What is your order ? ");
            product.ProductName = Console.ReadLine();

            product.Price = productInformation.GetPrice(product.ProductName);
            
            if(product.Price > 0) 
            {
                Console.WriteLine("The Price of " + 
                                  product.ProductName 
                                  + " is " + product.Price);
            }
            else
            {
                Console.WriteLine(product.ProductName + " is Not Found");
            }
            
        }
    }
}
