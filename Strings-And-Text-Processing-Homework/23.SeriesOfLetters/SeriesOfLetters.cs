using System;
using System.Text;
/*
    Problem 23. Series of letters

    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 */
class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Please enter a string: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        result.Append(input[0]);
        char lastletter = input[0];
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != lastletter)
            {
                result.Append(input[i]);
                lastletter = input[i];
            }
        }
        Console.WriteLine("Result: " + result);

    }
}
