using System;

namespace Proj_Homework
{
    class Program
    {

        static void Task1()
        {
            // The user enters the number of hours, output the number of minutes in that number of hours.

            Console.Write("Enter number of hours: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            double minutes = hours * 60;
            Console.WriteLine("Number of minutes: " + minutes);
        }

        static void Task2()
        {
            // The user enters 2 numbers(A and B).Print the solution (5*A + B^2)/ B-A to the console.

            Console.Write("Enter number A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double numerator = 5 * a + b * b;
            double denominator = b - a;

            double result = Convert.ToDouble(numerator / denominator);

            Console.WriteLine("Result for (5*A + B^2)/ B-A is : " + result);

        }

        static void Task3()
        {
            //The user enters 2 string values ​​(A and B). Swap the contents of variables A and B


            Console.Write("Enter value A: ");
            string a = Console.ReadLine();

            Console.Write("Enter value B: ");
            string b = Console.ReadLine();

            Console.WriteLine("Strings before swap: A = " + a + " and B = " + b);

            string originalA = a;
            a = b;
            b = originalA;

            Console.WriteLine("Strings after swap: A = " + a + " and B = " + b);

        }

        static void Task4()
        {
            //The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.

            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double dividing = a / b;
            double divisionRemainder = a % b;

            Console.WriteLine("Dividing result: " + dividing);
            Console.WriteLine("Division remainder result: " + divisionRemainder);

        }

        static void Task5()
        {
            //The user enters 3 non-zero numbers (A, B and C).
            //Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.

            Console.Write("Enter number A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x = c - b / a;

            Console.WriteLine("Result X value by formula A*X+B=C is: " + x);
        }

        static void Task6()
        {
            //The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane.
            //Output the equation of a straight line in the format Y=AX+B passing through these points.

            //Користувач вводить 4 числа (X1, Y1, X2, Y2), що описують координати 2 точок на координатній площині.
            //Вивести рівняння прямої у форматі Y=AX+B, що проходить через ці точки.

            Console.Write("Enter coordinates for X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coordinates for Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coordinates for X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coordinates for Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double numeratorA = y2 - y1;
            double denominatorA = x2 - x1;
            double a = numeratorA / denominatorA;

            double numeratorB = -x1 * (y2 - y1) + y1 * (x2 - x1);
            double denominatorB = x2 - x1;
            double b = numeratorB / denominatorB;

            string format = "+#.##;-#.##;(0)";
            Console.WriteLine("Output of Y=AX+B is: Y = " + a + "X " + b.ToString(format));
        }

        static void Task7()
        {
            //The variable N stores a natural two-digit number (10-99). Write a program that
            //calculates and displays the sum of the digits of n.

            Console.Write("Enter your natural two-digit number N: ");
            string userValue = Console.ReadLine();
            double number = 0;

            for (int i = 0; i < userValue.Length; i++)
            {
                number += Convert.ToDouble(userValue[i].ToString());
            }

            Console.Write("Sum of the digits of N is: " + number);
        }


        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            Task7();
        }
    }
}

