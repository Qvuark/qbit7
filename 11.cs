using System;
using System.Globalization;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;

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
        SumOfEven(array);
        Console.ReadKey();
    }
    static void SumOfEven(int[,] array)
    {
        int sumofevenrows = 0;
        List<int> nameofanevenrow = new List<int>(); // Declaration moved to before its usage
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int even = 0;
            int noteven = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] % 2 == 1 || array[i, j] % 2 == -1)
                    noteven++;
                else
                    even++;
            }
            if (even > noteven)
            {
                sumofevenrows++;
                nameofanevenrow.Add(i);
            }
        }
        Console.WriteLine(sumofevenrows);
        for (int i = 0; i < nameofanevenrow.Count; i++) // Changed nameofanevenrow.Length to nameofanevenrow.Count
        {
            if (i == 0)
                Console.Write($"{nameofanevenrow[i] + 1}");
            else
                Console.Write($" {nameofanevenrow[i] + 1}");
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