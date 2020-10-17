using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KordellGiffordC968.Main
{
    class Product
    {
        BindingList<Part> AssociatedParts;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int pID, string name, decimal price, int stock, int min, int max)
        {
            ProductID = pID;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {

        }

        public bool removeAssociatedPart(int number)
        {

        }

        public Part lookupAssociatedPart(int number)
        {

        }
    }
}
