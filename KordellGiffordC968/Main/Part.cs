using System;
using System.Collections.Generic;
using System.Text;

namespace KordellGiffordC968.Main
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static int Count;

        public Part(string name, int stock, decimal price, int min, int max)
        {
            PartID = Count++;
            Name = name;
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
        }

    }
}
