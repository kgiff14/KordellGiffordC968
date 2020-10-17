using KordellGiffordC968.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordC968
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.Products.Clear();
            Inventory.Products.Add(new Product("Red Bicycle", 15, 11.50M, 1, 25));
            //Inventory.Products[0].AssociatedParts.Add(new Inhouse("Wheel", 15, 12.11M, 5, 25, 101));
            //Inventory.Products[0].AssociatedParts.Add(new Inhouse("Petal", 11, 8.22M, 5, 25, 102));

            Inventory.Products.Add(new Product("Yellow Bicycle", 19, 9.66M, 1, 20));
            //Inventory.Products[1].AssociatedParts.Add(new Outsourced("Seat", 8, 4.55M, 2, 15, "Siers"));
            //Inventory.Products[1].AssociatedParts.Add(new Inhouse("Wheel", 15, 12.11M, 5, 25, 101));
            //Inventory.Products[1].AssociatedParts.Add(new Inhouse("Chain", 12, 8.33M, 5, 25, 103));

            Inventory.Products.Add(new Product("Blue Bicycle", 5, 12.77M, 1, 25));
            //Inventory.Products[2].AssociatedParts.Add(new Inhouse("Chain", 12, 8.33M, 5, 25, 103));
            //Inventory.Products[2].AssociatedParts.Add(new Inhouse("Wheel", 15, 12.11M, 5, 25, 101));

            Inventory.AllParts.Add(new Inhouse("Wheel", 15, 12.11M, 5, 25, 101));
            Inventory.AllParts.Add(new Inhouse("Petal", 11, 8.22M, 5, 25, 102));
            Inventory.AllParts.Add(new Inhouse("Chain", 12, 8.33M, 5, 25, 103));
            Inventory.AllParts.Add(new Outsourced("Seat", 8, 4.55M, 2, 15, "Siers"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
