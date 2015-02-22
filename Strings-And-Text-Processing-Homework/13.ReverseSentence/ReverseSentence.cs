using System;
using System.Text;
/*
    Problem 13. Reverse sentence

    Write a program that reverses the words in given sentence.
 */
class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Please enter a sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[]{' ', '.', '!', ',', '?'}, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            result.Append(words[words.Length - 1 - i]);
            result.Append(" ");
        }
        Console.WriteLine(result);
    }
}
