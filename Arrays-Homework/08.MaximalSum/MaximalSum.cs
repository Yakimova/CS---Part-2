using System;
/*
    Problem 8. Maximal sum

    Write a program that finds the sequence of maximal sum in given array.
*/
class MaximalSum
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

        double sum = double.MinValue;
        int startindex = -1;
        int endIndex = numbers.Length;
        for (int i = 0; i < numbers.Length; i++)
        {
            double biggestCurrentSum = 0.0;
            double currentSum = 0.0;
            for (int j = i; j < numbers.Length; j++)
            {
                currentSum += numbers[j];
                if (currentSum > biggestCurrentSum)
                {
                    biggestCurrentSum = currentSum;
                    endIndex = j;
                }
            }

            if (biggestCurrentSum > sum)
            {
                sum = biggestCurrentSum;
                startindex = i;
            }
        }

        //output
        Console.WriteLine("The maximum sum is: ");
        for (int i = startindex; i <= endIndex; i++)
        {
            Console.Write(numbers[i] + " + ");
        }
        Console.Write("\b\b");
        Console.WriteLine("= {0}", sum);

    }
}
