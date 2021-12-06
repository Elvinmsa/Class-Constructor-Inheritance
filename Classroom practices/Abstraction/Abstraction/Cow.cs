using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Cow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Ot yeyir :)");
        }

        public override void GetSound()
        {
            Console.WriteLine("Mooo");
        }
    }
}
