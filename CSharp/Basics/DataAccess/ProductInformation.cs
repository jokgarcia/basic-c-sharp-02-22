using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.DataAccess
{
    public class ProductInformation
    {
        public decimal GetPrice(string productName)
        {
            switch (productName)
            {
                case "Samsung S10": 
                    {
                        return 20000.99m;
                    }
                case "IPhone X":
                    {
                        return 30500.99m;
                    }
                case "VIVO F15":
                    {
                        return 15500.99m;
                    }
                case "ASUS Zenfone":
                    {
                        return 12500.99m;
                    }
                default:
                    {
                        return 0.00m;
                    }
            }
        }
    }
}
