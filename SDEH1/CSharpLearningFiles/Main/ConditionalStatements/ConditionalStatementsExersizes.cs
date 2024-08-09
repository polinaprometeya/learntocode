using System;
using System.Linq;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConditionalStatements
{
    /*
If year is leap
Given a year as integer, write a method that checks if year is leap.
Expected input and output
         IfYearIsLeap(2016) → true
         IfYearIsLeap(2018) → false
     */

    internal class ConditionalStatementsExersizes
{
    static void Main(string[] args)
    {
            //CONTROL
            Console.WriteLine("Deja Vu");

            //ConditionalStatementsExersizes - EXERSIZE-1
            //AbsoluteValue(6832); //→ 6832
            //AbsoluteValue(-392); // → 392

            //ConditionalStatementsExersizes - EXERSIZE-2
            //DivisibleBy2Or3(15, 30); //→ 450
            //DivisibleBy2Or3(2, 90); //→ 180
            //DivisibleBy2Or3(7, 12); //→ 19

            //ConditionalStatementsExersizes - EXERSIZE-3
            //lettersOutput("xyz"); //→ false
            //lettersOutput("DOG"); //→ true
            //lettersOutput("L9#"); //→ false

            //ConditionalStatementsExersizes - EXERSIZE-4
            //IfGreaterThanThirdOne(new int[] { 2, 7, 12 });
            //IfGreaterThanThirdOne(new int[] { -5, -8, 50 });

            //ConditionalStatementsExersizes - EXERSIZE-5
            //IfSortedAscending(new int[] { 3, 7, 10 }); //→ true
            //IfSortedAscending(new int[] { 74, 62, 99 }); //→ false

            //ConditionalStatementsExersizes - EXERSIZE-6
            //PositiveNegativeOrZero(5.24); //→ positive
            //PositiveNegativeOrZero(0.0); //→ zero
            //PositiveNegativeOrZero(-994.53); //→ negative

            //ConditionalStatementsExersizes - EXERSIZE-7
            //IfYearIsLeap(2016); // → true
            //IfYearIsLeap(2018); // → false

        }

        //static void IfYearIsLeap(int year)
        //    {
        //        if (year % 4 == 0 || year % 400 == 0)
        //        {
        //            Console.WriteLine("It is a leap year -- so true");
        //        } else
        //        {
        //            Console.WriteLine("It is not a leap year -- so false");
        //        }
        //    }


        //static void PositiveNegativeOrZero(double positiveNegativCheck)
        //{
        //    if (positiveNegativCheck == 0)
        //    {
        //        Console.WriteLine("zero");
        //    } else if (positiveNegativCheck > 0) {
        //        Console.WriteLine("positive");
        //    } else {
        //        Console.WriteLine("negativ");
        //    }
        //}


        //static void IfSortedAscending(int[] numbersForSorting)
        //{
        //    int[] clonedInputArray = (int[])numbersForSorting.Clone();
        //    Array.Sort(clonedInputArray);
        //    //Console.WriteLine(string.Join(' ',clonedInputArray));
        //    //Console.WriteLine(string.Join(',', numbersForSorting));

        //    //You cannot use '==' to compare two arrays in c#.

        //    if (clonedInputArray.SequenceEqual(numbersForSorting))
        //    {
        //        Console.WriteLine("Result:" + true);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Result:" + false);
        //    }
        //}

        //static void IfGreaterThanThirdOne(int[] randomNumbers)
        //{

        //        int a = randomNumbers[0];
        //        int b = randomNumbers[1];
        //        int c = randomNumbers[2];
        //        if (a * b > c) { Console.WriteLine(true); } else { Console.WriteLine(false); }

        //        Console.WriteLine(randomNumbers[0]);
        //}


        //static bool IfConsistsOfUppercaseLetters(string input){
        //    bool haveUpper = true;
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (char.IsNumber(input[i]) || !char.IsUpper(input[i])) {
        //        haveUpper = false;
        //        }

        //    } return haveUpper;
        //}


        //static void DivisibleBy2Or3(int a, int b)
        //{
        //    bool checkOne = (a % 3 == 0 || a % 2 == 0) ? true : false;
        //    bool checkTwo = (b % 2 == 0 || b % 3 == 0) ? true : false;
        //    if (checkOne == true && checkTwo == true)
        //    {
        //        Console.WriteLine("Result: " + (a * b));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Result: " + (a + b));
        //    }
        //}

        //static void AbsoluteValue(int a)
        //{
        //    if (0 > a)
        //    {
        //        Console.WriteLine("Result: " + a* -1);
        //    } else
        //    {
        //        Console.WriteLine("Result: " + a );
        //    }
        //}

    }
}