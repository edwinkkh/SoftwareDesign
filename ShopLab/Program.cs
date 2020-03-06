using System;

namespace ShopLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order(10, 20);
            Order cloned = myOrder.clone();

            Console.WriteLine("my order cost is " + myOrder.TotalCost);
            Console.WriteLine("my order cost is " + myOrder.WeightInKG);

            Console.WriteLine("my clone order cost is " + cloned.TotalCost);
            Console.WriteLine("my clone order cost is " + cloned.WeightInKG);
        }
    }
}