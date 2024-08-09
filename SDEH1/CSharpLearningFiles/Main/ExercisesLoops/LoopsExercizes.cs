using System;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
 Multiplication table
Write a method that prints 10 by 10 multiplication table. Remember about readibility (spaces in the right place).
Expected input and output
1 2 3 4 5 6 7 8 9 10
2 4 6 8101214161820
3 6 912151821242730
4 81216202428323640
5 10 15 20 25 30 35 40 45 50
6 12 18 24 30 36 42 48 54 60
7 14 21 28 35 42 49 56 63 70
8 16 24 32 40 48 56 64 72 80
9 18 27 36 45 54 63 72 81 90
10 20 30 40 50 60 70 80 90 100
*/

namespace Loops
{
    internal class LoopsExercizes
    {
        static void Main(string[] args)
        {
          //CONTROL
           Console.WriteLine("Deja Su");

          //LoopsExercizes - EXERSIZE-1
            multiplicationTable(4);
        }

        static void multiplicationTable(int tableSize )
        {
            Console.WriteLine(multiplicationTableColumn(tableSize));
        }


    }

    static int multiplicationTableRow()
    {
       int[] tableArray =  new int[];
        for (int i = 0; i<11; i++)
        {
            Array.tableArray.Add(i+1);
            i++;
        }
        return tableArray;
    }

    static int multiplicationTableColumn(int tableSize)
    {
        int[] tableColumnArray =  new multiplicationTableRow();
        string text = "fkdfdsfdflkdkfk@dfsdfjk72388389@kdkfkdfkkl@jkdjkfjd@jjjk@";
        text = text.Replace("@", "@" + System.Environment.NewLine);

        foreach (c in tableColumnArray)
        {
            Console.WriteLine(randomNumbers[0]);
        }
    }


}