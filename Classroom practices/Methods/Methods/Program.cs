using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowText();
            //ShowText();
            //ShowText();

            //Sum();

            //Sum1(5, 10);

            //Console.WriteLine(Sum2(3 ,4));

            //  int sum1 = Sum2(7, 8); // 7, 8 - arguments
            //  int sum2 = Sum2(2, 4);
            //  int result = sum1 + sum2;
            //  Console.WriteLine(result);

            //int[] ages = { 15, 18, 36, 60, 95, 33 };
            // GetAges(ages);

            //Console.WriteLine(SumNumbers(5, 15));

            //Test(7, 14);

        }

        static int Sum2(int n, int m) // n, m - parametrs
        {
            int num2 = 18;
            int sum = n + m + num2;
            return sum;
        }

        static void Sum1(int n, int m)
        {
            int sum = n + m;
            Console.WriteLine(sum);
        }

        static void ShowText()
        {
            Console.WriteLine("Hello World!");
        }

        static void Sum()
        {
            int sum = 5 + 6;
            Console.WriteLine(sum);
        }

        static void GetAges(int[] ages)
        {
            foreach (var item in ages)
            {
                bool isold = IsOld(item);
                if(isold)
                {
                    Console.WriteLine("Qocalib");
                }
                else
                {
                    Console.WriteLine("Cavandir");
                }


                
            }
        }

        static bool IsOld(int age)
        {
            if (age > 30)
                return true;

            return false;
        }

        static int SumNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        //Method overloading
        static void Test()
        {
            Console.WriteLine("Hecne yoxdur");
        }

        static void Test(int a)
        {
            Console.WriteLine(a + " var");
        }

        static void Test(int a, int b)
        {
            Console.WriteLine((a + b) + " var");
        }
    }
}
