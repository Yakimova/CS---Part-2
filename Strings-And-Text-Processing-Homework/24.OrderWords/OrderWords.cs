using System;
/*
    Problem 24. Order words

    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */
class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Please enter a list of words, separated by spaces");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Array.Sort(words);
        Console.WriteLine(string.Join(", ", words));
    }
}