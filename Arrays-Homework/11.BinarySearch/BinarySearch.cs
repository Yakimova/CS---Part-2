using System;
/*
    Problem 11. Binary search

    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/
class BinarySearch
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter a sequence of numbers separater by \",\" :");
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[stringNumbers.Length];
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(stringNumbers[i]);
        }
        Console.Write("PLease enter the value of the wanted element: ");
        int value = int.Parse(Console.ReadLine());


        //sorted array
        Array.Sort(numbers);
        Console.WriteLine("The sorted array is: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i != numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        //binary search
        int startIndex = 0;
        int endIndex = numbers.Length - 1;
        int wantedIndex = -1;
        while (startIndex <= endIndex)
        {
            int middleIndex = (startIndex + endIndex) / 2;
            if (numbers[middleIndex] == value)
            {
                wantedIndex = middleIndex;
                break;
            }
            else if (numbers[middleIndex+1] == value)
            {
                wantedIndex = middleIndex+1;
                break;
            }
            else if (numbers[middleIndex] > value)
            {
                endIndex = middleIndex;
            }
            else if (numbers[middleIndex] < value)
            {
                startIndex = middleIndex;
            }
        }

        //output
        if (wantedIndex != -1)
        {
            Console.WriteLine("The index is " + wantedIndex);
        }
        else
        {
            Console.WriteLine("The is no such element");
        }
    }
}