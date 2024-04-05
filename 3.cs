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
        SumOfArray(array);
        MinAndMax(array);
        Console.ReadKey();
    }
    //static void Print2DArray(int[,] array)
    //{
    //    for (int i = 0; i < array.GetLength(0); i++)
    //    {
    //        for (int j = 0; j <= array.GetLength(1) - 1; j++)
    //        {
    //            if (j < array.GetLength(1) - 1)
    //                Console.Write(array[i, j] + " ");
    //            else
    //                Console.Write(array[i, j] + "\n");
    //        }
    //    }
    //}
    static void SumOfArray(int[,] array)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
        }
        Console.Write(sum);
    }
    static void MinAndMax(int[,] array)
    {
        int min = array[0, 0];
        int max = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                    min = array[i, j];
                if (array[i, j] > max)
                    max = array[i, j];
            }
        }
        Console.Write($" {min} {max}");
    }
}