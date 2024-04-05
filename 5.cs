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
        int[] rowstochange = Console.ReadLine().Split().Select(int.Parse).ToArray();
        SwapRows(ref array, rowstochange[0], rowstochange[1]);
        Print2DArray(array);
        Console.ReadKey();
    }
    static void SwapRows(ref int[,]array,int row1,int row2)
    {
        int[] tarray = new int[array.GetLength(1)];
        for (int i =0;i<array.GetLength(1);i++)
        {
            tarray[i] = array[row1-1,i];
        }
        for (int j =0;j<array.GetLength(1);j++)
        {
            array[row1 - 1, j] = array[row2-1,j];
        }
        for(int k =0;k<array.GetLength(1);k++)
        {
            array[row2 - 1, k] = tarray[k];
        }
    }
    static void Print2DArray(int[,] array)
    {
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