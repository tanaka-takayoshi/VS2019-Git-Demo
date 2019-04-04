using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            int presons = 3;
            var price = calc.CalculatePrice(presons);
            Console.WriteLine($"{presons}: {price}");
        }
    }
}
