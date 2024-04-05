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
        int[] colstochange = Console.ReadLine().Split().Select(int.Parse).ToArray();
        SwapCols(ref array, colstochange[0], colstochange[1]);
        Print2DArray(array);
        Console.ReadKey();
    }
    static void SwapCols(ref int[,]array,int col1,int col2)
    {
        int[] tarray = new int[array.GetLength(0)];
        for (int i =0;i<array.GetLength(0);i++)
        {
            tarray[i] = array[i,col1-1];
        }
        for (int j =0;j<array.GetLength(0);j++)
        {
            array[j,col1 - 1] = array[j,col2 - 1];
        }
        for(int k =0;k<array.GetLength(0);k++)
        {
            array[k,col2 - 1] = tarray[k];
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