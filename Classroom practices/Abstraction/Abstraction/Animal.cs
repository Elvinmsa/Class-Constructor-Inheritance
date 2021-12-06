using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Animal
    {
        public string Head { get; set; }

        public int Age { get; set; }

        public abstract void Eat();

        public virtual void GetSound()
        {
            Console.WriteLine(" Ses cixir ");
        }
    }
}
