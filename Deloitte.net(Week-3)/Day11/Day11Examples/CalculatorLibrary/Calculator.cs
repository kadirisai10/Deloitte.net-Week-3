using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            if (x <= 0 || y <= 0)
                throw new ArgumentException("The parameter value has to be positive");
            else
                return (x + y);
        }

        public int Sub(int x, int y)
        {
            if (x < y)
                throw new ArgumentException("Cannot Subtract lesser value from a gretaer value");
            else if (x <= 0 || y <= 0)
                throw new ArgumentException("Parameter cannot be negative");
            else
                return (x - y);
        }
    }
}
