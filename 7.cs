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
        Avarage(array);
        Console.ReadKey();
    }
    static void Avarage(int[,] array)
    {
        double sum = 0;
        int amount = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i > j)
                {
                    sum += array[i,j];
                    amount++;
                }
            }
        }
        Console.WriteLine(sum/amount);
    }
}