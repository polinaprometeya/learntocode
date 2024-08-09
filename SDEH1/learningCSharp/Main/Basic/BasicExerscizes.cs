
using System;
using System.Diagnostics;
using System.Reflection;

namespace Basic
{
    /*
     */

    //[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class BasicExerscizes
    {
        static void Main(string[] args)
        {
            //BasicExerscizes - CONTROL
            //Console.WriteLine("Hello, World! → or!!! something");

            //BasicExerscizes - EXERSIZE-1  (yes , I called the method something else)
            //randomCalculationOutput();

            //BasicExerscizes - EXERSIZE-2  (yes , I called the method something else, again.)
            //temperatureOutput(0);
            //temperatureOutput(100);
            //temperatureOutput(-300);

            //BasicExerscizes - EXERSIZE-3 
            //elementaryOperations(3, 8);

            //BasicExerscizes - EXERSIZE-4  
            //IsResultTheSame(2 + 2, 2 * 2); //→ true
            //IsResultTheSame(9 / 3, 16 - 1); //→ false

            //BasicExerscizes - EXERSIZE-5
            //ModuloOperations(8, 5, 2);

            //BasicExerscizes - EXERSIZE-6
            //TheCubeOf(2); //→ 8
            //TheCubeOf(-5.5); //→ -166.375

            //BasicExerscizes - EXERSIZE-7
            //SwapTwoNumbers(87, 45);
            //SwapTwoNumbers(-13, 2); 


        }

        //private string GetDebuggerDisplay()
        //{
        //    return ToString();
        //}

        static void SwapTwoNumbers(int a, int b)
        {
            int first = b;
            int second = a;

            Console.WriteLine("Result: " + first + "   " + second);

        }

        static void TheCubeOf(double a)
        {
            Console.WriteLine("Result: " + (a * a * a));

        }

        static void ModuloOperations(int a, int b, int c)
        {
            int modulo = a / b;
            Console.WriteLine("Result: " + modulo / c);
        }

        static void IsResultTheSame(int a, int b)
        {

            if (a == b)
            {
                Console.WriteLine("Result: " + true);
            }
            else
            {
                Console.WriteLine("Result: " + false);
            }
        }

        static void elementaryOperations(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Sum: " + simpleCalculationsSum(a, b));
                Console.WriteLine("Substraction: " + simpleCalculationsSubstraction(a, b));
                Console.WriteLine("Multiplication: " + simpleCalculationsMultiplication(a, b));
                Console.WriteLine("You cannot divide by 0 ");
            }
            else
            {
                Console.WriteLine("Sum: " + simpleCalculationsSum(a, b));
                Console.WriteLine("Substraction: " + simpleCalculationsSubstraction(a, b));
                Console.WriteLine("Multiplication: " + simpleCalculationsMultiplication(a, b));
                Console.WriteLine("Division: " + simpleCalculationsDivision(a, b));
            }
        }


        static int simpleCalculationsSum(int a, int b)
        {
            return a + b;

        }

        static int simpleCalculationsSubstraction(int a, int b)

        {
            return a - b;

        }

        static int simpleCalculationsMultiplication(int a, int b)
        {
            return a * b;

        }

        static int simpleCalculationsDivision(int a, int b)
        {
            return a / b;

        }

        static double temperatureConverter(int a)
        {
            double fahrenheit = (a * 1.8) + 32;
            return fahrenheit;
        }

        static void temperatureOutput(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Temperature below zero!");
            }
            else
            {
                Console.WriteLine("Temperature = " + temperatureConverter(a) + "F");

            }
        }

        static int addAndMultiply(int a, int b, int c)
        {
            int adition = a + b;

            var result = adition * c;

            return result;
        }

        static void randomCalculationOutput()
        {
            Console.WriteLine("result:" + "-->" + addAndMultiply(2, 4, 5));
        }

    }

}



