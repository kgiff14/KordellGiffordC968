using System;
using System.Collections.Generic;
using System.Text;

namespace KordellGiffordC968.Main
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string name, int stock, decimal price, int min, int max, string cName) : base(name, stock, price, min, max)
        {
            CompanyName = cName;
        }
    }
}
