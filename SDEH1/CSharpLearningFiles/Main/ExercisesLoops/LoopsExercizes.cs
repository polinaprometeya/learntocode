using System;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
 * The biggest number

Two 7s next to each other
Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.
Expected input and output
         Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 1
         Two7sNextToEachOther([ 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7]) → 3
*/

namespace Loops
{
    internal class LoopsExercizes
    {
        static void Main(string[] args)
        {
            //CONTROL
            Console.WriteLine("Deja Vacu");

            //  //LoopsExercizes - EXERSIZE-3
            Two7sNextToEachOther([8, 2, 5, 7, 9, 0, 7, 7, 3, 1]); //→ 1
            Two7sNextToEachOther([9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7]); //→ 3

            //  //LoopsExercizes - EXERSIZE-2
            //TheBiggestNumber(new int[] { 190, 291, 145, 209, 280, 200 }); //→ 291
            //TheBiggestNumber(new int[] { -9, -2, -7, -8, -4 }); //→ -2

            //  //LoopsExercizes - EXERSIZE-1
            //    multiplicationTable(4);


        }
        //  //LoopsExercizes - EXERSIZE-3
        static void Two7sNextToEachOther([8, 2, 5, 7, 9, 0, 7, 7, 3, 1])
        {

        }

        //  //LoopsExercizes - EXERSIZE-2
        //static void TheBiggestNumber(int[] biggestNumberTest)
        //{
        //    int biggestNumber = -100;
        //    //biggestNumberTest.ForEach( i => { if (i > biggestNumber) biggestNumber = i;});
        //    foreach (int i in biggestNumberTest){
        //       if (i> -101){
        //            if (i > biggestNumber) { biggestNumber = i;}
        //        } else {
        //         Console.WriteLine("Error");
        //        }
        //    }
        //    Console.WriteLine("The Result:" + biggestNumber);
        //}
        //}

        ////  //LoopsExercizes - EXERSIZE-1
        //static void multiplicationTable(int tableSize )
        //{ Console.WriteLine(multiplicationTableColumn(tableSize));}
        //
        //static int multiplicationTableRow()
        //{
        //   int[] tableArray =  new int[];
        //    for (int i = 0; i<11; i++)
        //    {
        //        Array.tableArray.Add(i+1);
        //        i++;
        //    }
        //    return tableArray;
        //}
        //
        //static int multiplicationTableColumn(int tableSize)
        //{
        //    int[] tableColumnArray =  new multiplicationTableRow();
        //    string text = "fkdfdsfdflkdkfk@dfsdfjk72388389@kdkfkdfkkl@jkdjkfjd@jjjk@";
        //    text = text.Replace("@", "@" + System.Environment.NewLine);
        //    foreach (c in tableColumnArray)
        //    {
        //    Console.WriteLine(randomNumbers[0]);
        //    }
        //}


    }
}
