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
        EnterArray(ref array);
        PrintArray(array);
        Console.ReadKey();
    }
    static void EnterArray(ref int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                if (i < j)
                    array[i, j] = 2;
                if (i==j)
                    array[i, j] = 0;
                if (i>j)
                    array[i,j] = 1;
            }
        }
        for (int i = 0;i < array.GetLength(0);i++)
        {
            for (int j = 0;j<array.GetLength(1)/2;j++)
            {
                int temp = array[i,j];
                array[i, j] = array[i,array.GetLength(1)-j-1];
                array[i, array.GetLength(1) - j - 1] = temp;
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
