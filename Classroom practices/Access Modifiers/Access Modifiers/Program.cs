using System;
using System.Reflection;
using Test;
using Access_Modifiers.Models;
using ClassLibrary;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //string name;

            //Car car = new Car
            //{
            //    Brand = "hsgdhs",
            //    Model = "jnvjfnv",
            //};

            Car car = new Car();
            Test.Car car2 = new Test.Car();
            Animal animal = new Animal();
            Book book = new Book();
            Bird bird = new Bird();

            Console.WriteLine();
            //car.SetHorsePower(0);
            //Console.WriteLine(car.GetHorsePower());

            //car.HorsePower = 15;
            //Console.WriteLine(car.HorsePower);

            //// get private field with reflection
            //typeof(Car).GetField("horsePower", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(car, 300);
            //var horsePower = typeof(Car).GetField("horsePower", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(car);
            //Console.WriteLine(horsePower);


            Person person = new Person();
        }
    }
}
