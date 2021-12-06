using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eating meat");
        }
    }
}
