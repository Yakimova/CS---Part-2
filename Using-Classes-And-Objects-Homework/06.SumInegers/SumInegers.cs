using System;
/*
    Problem 6. Sum integers

    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.
 */
class SumInegers
{
    static void Main()
    {
        Console.Write("Please enter a sequence of positive integer values, separated by spaces: ");
        string input = Console.ReadLine(); //"43 68 9 23 318";
        string[] stringNumbers = input.Split(new char[] { ' ', '"' }, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            int number = int.Parse(stringNumbers[i]);
            sum += number;
        }
        Console.WriteLine("The sum of those integes is: " + sum);
    }
}
