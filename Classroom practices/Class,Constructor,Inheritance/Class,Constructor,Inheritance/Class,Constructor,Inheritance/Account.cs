using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Constructor_Inheritance
{
    class Account
    {
        #region Homework3
        public void Login(string mail, string password)
        {
            if (mail == "cavid@code.edu.az" && password == "12345")
            {
                Console.WriteLine("Signed in");
            }
            else
            {
                Console.WriteLine("Email or password is wrong");
            }
        }
        #endregion
    }
}
