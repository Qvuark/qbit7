using System;
using System.Globalization;
using System.Xml.Serialization;
using System.Linq;

class qbit
{
    static void Main()
    {
        int[] RowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[,] array = new int[RowsAndCols[0], RowsAndCols[1]];
        for (int i = 0; i < RowsAndCols[0]; i++)
        {
            string[] temparray = Console.ReadLine().Split();
            for (int j = 0; j < RowsAndCols[1]; j++)
            {
                array[i, j] = int.Parse(temparray[j]);
            }
        }
        int[,] tparray = TurnArray(array);
        PrintArray(tparray);
        Console.ReadKey();
    }
    static int[,] TurnArray(int[,] array)
    {
        Console.WriteLine($"{array.GetLength(1)} {array.GetLength(0)}");
        int[,] temparray = new int[array.GetLength(1),array.GetLength(0)];
        for (int i = 0; i< array.GetLength(0); i++)
        {
            for(int j=0;j< array.GetLength(1); j++)
            {
                temparray[j,i] = array[i,j];
            }
        }
        for(int i=0;i<temparray.GetLength(0);i++)
        {
            for(int j=0;j< temparray.GetLength(1)/2;j++)
            {
                int temp = temparray[i, j];
                temparray[i, j] = temparray[i,temparray.GetLength(1)-1-j];
                temparray[i, temparray.GetLength(1) - 1 - j] = temp;
            }
        }
        return temparray;
    }
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
