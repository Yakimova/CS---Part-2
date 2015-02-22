using System;
using System.Text;
/*
    Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
 */
class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            result.Append(String.Format("\\u{0:X4}", (int)input[i]));
        }
        Console.WriteLine(result);
    }
}
