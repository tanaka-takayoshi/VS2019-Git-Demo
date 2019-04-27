using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Calculator
    {
        public int PricePerPerson { get; } = 2000;

        public int CalculatePrice(int numOfPersons)
        {
            return PricePerPerson * numOfPersons;
        }
    }
        
}
