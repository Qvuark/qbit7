using System;
using System.Globalization;
using System.Xml.Serialization;
using System.Linq;

class qbit
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int[,] array = new int[rows,rows];
        FillArraySpiral(ref array);
        PrintArray(array);
        Console.ReadKey();
    }
    static void FillArraySpiral(ref int[,] array)
    {
        int value = 1;
        int rowStart = 0, rowEnd = array.GetLength(0) - 1;
        int colStart = 0, colEnd = array.GetLength(1) - 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Fill top row
            for (int i = colStart; i <= colEnd; i++)
            {
                array[rowStart, i] = value++;
            }
            rowStart++;

            // Fill right column
            for (int i = rowStart; i <= rowEnd; i++)
            {
                array[i, colEnd] = value++;
            }
            colEnd--;

            // Fill bottom row (if applicable)
            if (rowStart <= rowEnd)
            {
                for (int i = colEnd; i >= colStart; i--)
                {
                    array[rowEnd, i] = value++;
                }
                rowEnd--;
            }

            // Fill left column (if applicable)
            if (colStart <= colEnd)
            {
                for (int i = rowEnd; i >= rowStart; i--)
                {
                    array[i, colStart] = value++;
                }
                colStart++;
            }
        }
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
