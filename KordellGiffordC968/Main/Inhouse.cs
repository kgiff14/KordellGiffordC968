using System;
using System.Collections.Generic;
using System.Text;

namespace KordellGiffordC968.Main
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(string name, int stock, decimal price, int min, int max, int mId) : base(name, stock, price, min, max)
        {
            MachineID = mId;
        }
    }
}
