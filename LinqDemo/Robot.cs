using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    class Robot
    {

        public Robot(string model, int price)
        {
            Model = model;
            Price = price;
        }
        public string Model { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Model: {Model}. Price {Price}";
        }
    }
}
