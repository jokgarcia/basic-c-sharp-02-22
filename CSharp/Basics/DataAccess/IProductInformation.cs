using System;

namespace Basics.DataAccess
{
    public interface IProductInformation
    {
        decimal ComputeDailySales(DateTime from);
        void ComputeDailySales(int quantity);
        decimal GetPrice(string productName);
        void New();
    }
}