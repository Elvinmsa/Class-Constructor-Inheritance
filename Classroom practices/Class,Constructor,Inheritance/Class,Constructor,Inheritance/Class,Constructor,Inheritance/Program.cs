using System;

namespace Class_Constructor_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Rovshen";
            //string surname = "Quliyev";
            //int age = 21;

            //string name2 = "Elshen";
            //string surname2 = "Eliyev";
            //int age2 = 24;

            //Console.WriteLine($"{name} {surname}");

            //var obj1 = new
            //{
            //    name = "Rovshen",
            //    surname = "Quliyev",
            //    age = 21,
            //    address="Ehmedli",
            //};

            //var obj2 = new
            //{
            //    name = "Elshen",
            //    surname = "Eliyev",
            //    age = 24,
            //    address="Genclik",
            //};

            //Console.WriteLine($"{obj1.name} {obj1.surname}");
            //Console.WriteLine($"{obj2.name} {obj2.surname}");

            //Student st1 = new Student("Rovshen","Quliyev",21);
            //Console.WriteLine(st1.FullName());
            //Console.WriteLine(st1.FullData());

            //st1.name = "Rovshen";
            //st1.surname = "Quliyev";
            //st1.age = 21;
            //Console.WriteLine("Student full data: " + st1.FullData());


            //Student st2 = new Student(22);
            //Teacher tc1 = new Teacher(18);

            //Person p = new Person(11);

            //Console.WriteLine(p.GetAge());


            //st2.name = "Elshen";
            //st2.surname = "Eliyev";
            //st2.age = 24;
            //Console.WriteLine(st2.name + " " + st2.surname);

            #region Homework2

            //Factorial factorial = new Factorial();
            //Console.WriteLine(factorial.CalculateFactorial(5));

            #endregion

            #region Homework3
            Account account = new Account();
            account.Login("cavid@code.edu.az", "12345");
            #endregion

        }
    }
}
