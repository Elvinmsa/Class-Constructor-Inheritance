using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    class Truck:Car
    {
        public Truck(string model, string brand):base(model, brand)
        {
            //this.Color = "Red";
            //Console.WriteLine(this.Color);
        }
    }
}
