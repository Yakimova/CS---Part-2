using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 5. Sort by string length

    You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */
class SortByStringLength
{
    static void Main()
    {
        //input
        Console.Write("Please enter the size ot the array of strings: ");
        int rows = int.Parse(Console.ReadLine());
        string[] array = new string[rows];
        int[] lengths = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            Console.Write("string[{0}] = ", i);
            array[i] = Console.ReadLine();
            lengths[i] = array[i].Length;
        }

        //sorting - difficult way
        for (int i = 0; i < rows; i++)
        {
            int min = lengths[i];
            int minindex = i;
            for (int j = i + 1; j < rows; j++)
            {
                if (lengths[j] < min)
                {
                    min = lengths[j];
                    minindex = j;
                }
            }
            int temp = lengths[minindex];
            lengths[minindex] = lengths[i];
            lengths[i] = temp;
            string tempstring = array[minindex];
            array[minindex] = array[i];
            array[i] = tempstring;
        }

        //sorting - easy way
        //array = array.OrderBy(a => a.Length).ToArray();

        //ouput
        Console.WriteLine("The sorted array looks like this:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}