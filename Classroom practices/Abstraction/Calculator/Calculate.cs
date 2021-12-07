using System;

namespace Calculator
{
    public class Calculate
    {
        public double Calculation(double n, double m, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = n + m;
                    break;
                case "-":
                    result = n - m;
                    break;
                case "*":
                    result = n * m;
                    break;
                case "/":
                    result = n / m;
                    break;
                default:
                    result = -1;
                    break;
            }
            return result;
        }
    }
}
