using System;
using System.Globalization;

class qbit
{
    static void Main()
    {
        int[] RowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[,] array = new int[RowsAndCols[0],RowsAndCols[1]];
        int[] temparray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for(int i=0;i<RowsAndCols[0];i++)
        {
            for(int j=0;j< RowsAndCols[1]; j++)
            {
                int index = i * RowsAndCols[1] + j;
                array[i, j] = temparray[index];
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j <= array.GetLength(1) - 1; j++)
            {
                if (j < array.GetLength(1) - 1)
                    Console.Write(array[i, j] + " ");
                else
                    Console.Write(array[i, j] + "\n");
            }
        }
    }
}