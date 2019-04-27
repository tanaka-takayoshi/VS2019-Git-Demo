using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            int persons = 3;
            var price = calc.CalculatePrice(persons);
            Console.WriteLine($"{persons}: {price}");
        }
    }
}
