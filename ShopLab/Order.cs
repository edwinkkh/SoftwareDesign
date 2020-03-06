using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLab
{
    class Order : IOrder
    {
        public Order() { }
        public Order(decimal totalCost, decimal weightInKG)
        {
            TotalCost = totalCost;
            WeightInKG = weightInKG;            
        }
        public decimal TotalCost { get; set; }
        public decimal WeightInKG { get; set; }

        public Order clone(){
            var order = new Order
            {
                TotalCost = TotalCost,
                WeightInKG = WeightInKG,
            };
            return order; 
        }
    }
}
