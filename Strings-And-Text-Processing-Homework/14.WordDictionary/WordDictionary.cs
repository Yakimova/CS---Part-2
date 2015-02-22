using System;
using System.Collections.Generic;
/*
    Problem 14. Word dictionary

    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.
 */
class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary[".NET"] = "platform for applications from Microsoft";
        dictionary["CLR"] = "managed execution environment for .NET";
        dictionary["namespace"] = "hierarchical organization of classes";

        Console.Write("Please enter a word from the dictionary: ");
        string input = Console.ReadLine();
        foreach (var word in dictionary)
        {
            if (word.Key == input)
            {
                Console.WriteLine(word.Value);
            }
        }
    }
}
