using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
/*
    Problem 16.* Subset with sum S

    We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.
 */
class SubsetWithSumS
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter teh array of ingeres, separated by \",\": ");
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(',');
        int[] numbers = new int[stringNumbers.Length];
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = int.Parse(stringNumbers[i]);
        }
        Console.Write("Please enter a number s: ");
        int s = int.Parse(Console.ReadLine());

        //not solved




    }
}
