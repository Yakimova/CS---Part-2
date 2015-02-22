using System;
using System.Text;
/*
    Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.
 */
class ReverseString
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string input = Console.ReadLine();
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        string result = reversed.ToString();
        Console.WriteLine("The reversed string is: " + result);
    }
}
