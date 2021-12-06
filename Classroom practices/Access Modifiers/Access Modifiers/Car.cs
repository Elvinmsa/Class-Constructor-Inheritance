using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    class Car:Person
    {
        public string Model;
        public string Brand;
        protected string color;
        private int horsePower;
        //public int Speed;
        //public readonly int Speed;
        private readonly int Speed;
        public int HorsePower
        {
            get
            {
                if (horsePower == 0)
                {
                    Console.WriteLine("Car is stopped");
                    return -1;
                }

                return horsePower;
            }
            set
            {
                if (value > 0)
                {
                    horsePower = value;
                }
            }
        }

        public Car()
        {
            Speed = 300;
            //Console.WriteLine("Car created");
        }

        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

        public string GetInfo()
        {
            return $"{Model} {Brand}";
        }

        public int GetHorsePower()
        {
            if (horsePower == 0)
            {
                Console.WriteLine("Car is stopped");
                return -1;
            }

            return horsePower;
        }

        public void SetHorsePower(int power)
        {
            if (power > 0)
            {
                horsePower = power;
            }
        }
    }
}
