using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace KordellGiffordC968.Main
{
    class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public static int Count;

        public Product(string name, int stock, decimal price, int min, int max)
        {
            ProductID = Count++;
            Name = name;
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int number)
        {
            try
            {
                for (var i = 0; i < AssociatedParts.Count; i++)
                {
                    if (AssociatedParts[i].PartID == number)
                    {
                        AssociatedParts.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Part lookupAssociatedPart(int number)
        {
            try
            {
                return AssociatedParts[number];
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
    }
}
