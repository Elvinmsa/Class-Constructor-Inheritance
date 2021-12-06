using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Person
    {
        protected internal int Age { get; set; }

        private protected string Name { get; set; }

    }

    public class P126
    {
        public P126()
        {
            Person person = new Person();

        }
    }
}
