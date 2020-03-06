using System;

namespace ShopLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order(10, 20);
            Console.WriteLine("Order total cost $" + myOrder.TotalCost);
        }
    }
}