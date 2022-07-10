
using System;
using Numerical_Library;

namespace Proj_Homework_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(NumericalHelper.GetSummOfInputBySymbol(-55));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

