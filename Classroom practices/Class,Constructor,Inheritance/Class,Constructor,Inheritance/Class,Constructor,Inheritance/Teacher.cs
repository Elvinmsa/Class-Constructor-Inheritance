using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Constructor_Inheritance
{
    class Teacher:Person
    {
        public string prefession;
        public Teacher(int num):base(num)
        {
            this.age = num;
        }
    }
}
