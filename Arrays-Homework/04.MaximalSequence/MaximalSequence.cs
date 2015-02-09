using System;
/*
    Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.
 */
class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of numbers separater by \",\" :");
        string input = Console.ReadLine(); // "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        string[] stringNumbers = input.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
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
                if (numbers[j] == numbers[i])
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
        Console.WriteLine("The maximal sequence of equal elements is: ");
        for (int i = maximalStartIndex; i < maximalSize+maximalStartIndex; i++)
        {
            Console.Write(numbers[i]);
            if (i != maximalSize+maximalStartIndex - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
