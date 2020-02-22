using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Model
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Tag { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
