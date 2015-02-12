using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 4. Binary search

    Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/
class BinarySearch
{
    static void Main()
    {
        //input
        Console.Write("Please enter the number of the integers - n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter an integer - k: ");
        int k = int.Parse(Console.ReadLine());

        //sorting the array
        Array.Sort(array);
        Console.WriteLine(String.Join(", ", array));

        // finding the largest number <=k
        bool found = false;
        while (found == false)
        {
            int result = Array.BinarySearch(array, k);
            if (result < 0)
            {
                k--;
            }
            else
            {
                Console.WriteLine("The largest number that is <=k is : {0}. It is on possition {1} ", k, Array.BinarySearch(array, k));
                found = true;
            }
        }
    }
}
