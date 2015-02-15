using System;
/*
    Problem 9. Sorting array

    Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
 */
class SortingArray
{
    static void Main()
    {
        //input
        Console.Write("Please enter the array of numbers, separated by \",\": ");
        string input = Console.ReadLine();
        string[] stringArray = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[stringArray.Length]; //{ 4, 7, 6, 4, -8, 1, 3, 6 };
        for (int i = 0; i < stringArray.Length; i++)
        {
            array[i] = int.Parse(stringArray[i]);
        }

        //sorted in descending order
        SortingArrayDescending(array);
        Console.WriteLine("Sorted in descending order: ");
        Console.WriteLine(String.Join(", ", array));

        //sorted in ascending order
        SortingArrayAscending(array);
        Console.WriteLine("Sorted in ascending order: ");
        Console.WriteLine(String.Join(", ", array));
    }
    static int MaximalElementfromGivenIndex(int[] array, int start)
    {
        int max = int.MinValue;
        int maxIndex = -1;
        for (int i=start; i<array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    static int[] SortingArrayDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxIndex = MaximalElementfromGivenIndex(array, i);
            int swap = array[maxIndex];
            array[maxIndex] = array[i];
            array[i] = swap;
        }
        return array;
    }
    static int[] SortingArrayAscending(int[] array)
    {
        SortingArrayDescending(array);
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 -i];
            array[array.Length - 1 -i ] = temp;
        }
        return array;
    }
}