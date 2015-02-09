using System;
/*
    Problem 9. Frequent number

    Write a program that finds the most frequent number in an array.
*/
class FrequentNumber
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter a sequence of numbers separater by \",\" :");
        string input = Console.ReadLine(); //"4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3";
        string[] stringNumbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double[] numbers = new double[stringNumbers.Length];
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(stringNumbers[i]);
        }

        double frequentValue = numbers[0];
        int times = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            double currentValue = numbers[i];
            int currentTimes = 1;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] == currentValue)
                {
                    currentTimes++;
                }
            }
            if (currentTimes > times)
            {
                times = currentTimes;
                frequentValue = currentValue;
            }
        }

        //output
        Console.WriteLine("The most frequent number is {0} --> {1} times.", frequentValue, times);
    }
}