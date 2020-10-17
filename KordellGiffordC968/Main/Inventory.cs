using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KordellGiffordC968.Main
{
    static class Inventory 
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static int Index { get; set; }
        public static int IndexParts { get; set; }
        public static int IndexAssociate { get; set; }

        public static void addProduct(Product product)
        {
            Inventory.Products.Add(product);
        }

        public static bool removeProduct(int number)
        {
            if (number >= 0)
            {
                Inventory.Products.RemoveAt(number);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Product lookupProduct(int number)
        {
            try
            {
                for (var i = 0; i < Inventory.Products.Count; i++)
                {
                    if (number == Inventory.Products[i].ProductID)
                    {
                        var product = Inventory.Products[i];
                        return product;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void updateProduct(int number, Product product)
        {
            try
            {
                for (var i = 0; i < Inventory.Products.Count; i++)
                {
                    if (number == Inventory.Products[i].ProductID)
                    {
                        Inventory.Products[i] = product;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static void addPart(Part part)
        {
            Inventory.AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            if (part != null)
            {
                Inventory.AllParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Part lookupPart(int number)
        {
            try
            {
                for (var i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (number == Inventory.AllParts[i].PartID)
                    {
                        var part = Inventory.AllParts[i];
                        return part;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void updatePart(int number, Part part)
        {
            for (var i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (number == Inventory.AllParts[i].PartID)
                {
                    Inventory.AllParts[i] = part;
                }
            }
        }
    }
}
