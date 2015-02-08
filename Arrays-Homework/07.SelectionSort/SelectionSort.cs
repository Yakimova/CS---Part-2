using System;
/*
    Problem 7. Selection sort

    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/
class SelectionSort
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter a sequence of numbers separater by \",\" :");
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(',');
        double[] numbers = new double[stringNumbers.Length];
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(stringNumbers[i]);
        }

        //sorting
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            double min = numbers[i];
            int smallestIndex =i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < min)
                {
                    min = numbers[j];
                    smallestIndex = j;
                }
            }
            double temp = numbers[i];
            numbers[i] = numbers[smallestIndex];
            numbers[smallestIndex] = temp;
        }

        //output
        Console.WriteLine();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("array[{0}] = ", i);
            Console.WriteLine(numbers[i]);
        }
    }
}
