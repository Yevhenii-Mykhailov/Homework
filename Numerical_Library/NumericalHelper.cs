using System;

namespace Numerical_Library
{
    public class NumericalHelper
    {
        public static int ConvertHoursToMinutes(int hours)
        {
            return hours * 60;
        }

        public static double CalculateFormula(int a, int b)
        {
            double numerator = 5 * a + b * b;
            double denominator = b - a;

            return Convert.ToDouble(numerator / denominator);
        }

        public static (int a, int b) SwapValues(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        public static (double dividing, double divisionRemainder) CalculateDividingAndDivisionRemainder(double a, double b)
        {
            double dividing = a / b;
            double divisionRemainder = a % b;

            return (dividing, divisionRemainder);
        }

        public static double CalculateExpressionByFormula(double a, double b, double c)
        {
            return c - b / a;
        }

        public static string GetLineEquation(double x1, double y1, double x2, double y2)
        {
            double numeratorA = y2 - y1;
            double denominatorA = x2 - x1;
            double a = numeratorA / denominatorA;

            double numeratorB = -x1 * (y2 - y1) + y1 * (x2 - x1);
            double denominatorB = x2 - x1;
            double b = numeratorB / denominatorB;

            string format = "+#.##;-#.##;(0)";
            return $"Output of Y=AX+B is: Y = " + a + "X " + b.ToString(format);
        }

        public static double GetSummOfInputBySymbol(string userValue)
        {
            string firstNumber = Convert.ToString(userValue[0]);
            string secondNumber = Convert.ToString(userValue[1]);

            double result = Convert.ToDouble(firstNumber) + Convert.ToDouble(secondNumber);
            return result;
        }
    }
}

