using System;
using System.Text;
/*
    Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
 */
class StringLength
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        int possition = 0;
        if (input.Length <= 20)
        {
            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);
                possition++;
            }
            for (int i = possition; i < 20; i++)
            {
                result.Append("*");
            }
        }
        else
        {
            for (int i = 0; i < 20; i++)
            {
                result.Append(input[i]);
            }
        }
        Console.WriteLine("Result: " + result);
    }
}