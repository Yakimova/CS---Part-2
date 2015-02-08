using System;
/*
    Problem 5. Maximal increasing sequence

    Write a program that finds the maximal increasing sequence in an array.
*/
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of numbers separater by \",\" :");
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(',');
        double[] numbers = new double[stringNumbers.Length];
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(stringNumbers[i]);
        }

        //finding the maximal sequence
        int maximalSize = 0;
        int maximalStartIndex = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentSize = 1;
            int currentIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] == (numbers[j-1]+1))
                {
                    currentSize++;
                }
                else
                {
                    break;
                }
            }
            if (currentSize >= maximalSize)
            {
                maximalSize = currentSize;
                maximalStartIndex = currentIndex;
            }
        }

        //output
        Console.WriteLine("The maximal sequence of increasing elements is: ");
        for (int i = maximalStartIndex; i < maximalSize + maximalStartIndex; i++)
        {
            Console.Write(numbers[i]);
            if (i != maximalSize + maximalStartIndex - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine();
    }
}
