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
            //<<<<<<< HEAD
            //            Customer customer = new Customer();
            //            Product product = new Product();
            //            ProductInformation productInformation = new ProductInformation();
            //            Supplier supplier = new Supplier();
            //=======
            //            Customer customer = new Customer();
            //            Product product = new Product();
            //            ProductInformation productInformation = new ProductInformation();

            //            customer.FirstName = "Jok";
            //>>>>>>> 10ab7cba3088f0c7b1aa4175153246551ab91878

            //            Console.WriteLine("Enter Name : ");
            //            customer.FirstName = Console.ReadLine();

            //            Console.WriteLine("Hello! " + customer.FirstName);

            //            Console.WriteLine("What is your order ? ");
            //            product.ProductName = Console.ReadLine();

            //            product.Price = productInformation.GetPrice(product.ProductName);

            //            if (product.Price > 0)
            //            {
            //                Console.WriteLine("The Price of " +
            //                                  product.ProductName
            //                                  + " is " + product.Price);
            //            }
            //            else
            //            {
            //                Console.WriteLine(product.ProductName + " is Not Found");
            //            }

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Loop Number " + i);
                i++;
            }



        }
    }
}
