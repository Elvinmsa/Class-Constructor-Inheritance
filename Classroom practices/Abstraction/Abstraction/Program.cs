using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal;

            //Eagle eagle = new Eagle();
            //eagle.Eat();
            //eagle.Age = 70;
            //Console.WriteLine(eagle.Age);

            //Cow cow = new Cow();
            //cow.Eat();
            //cow.GetSound();


            #region Calculator

            Console.WriteLine("1-ci ededi daxil edin");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Emeliyyat elave edin");
            string operation = Console.ReadLine();
            Console.WriteLine("2-ci ededi daxil edin");
            double m = double.Parse(Console.ReadLine());
            //double m = Convert.ToDouble(Console.ReadLine());
            Calculate calculate = new Calculate();
            var result = calculate.Calculation(n, m, operation);
            Console.WriteLine(result);

            #endregion


        }
    }
}
