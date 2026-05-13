using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);
            Console.WriteLine(result);
        }
    }
}