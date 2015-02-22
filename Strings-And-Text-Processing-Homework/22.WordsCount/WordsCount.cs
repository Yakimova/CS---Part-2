using System;
using System.Collections.Generic;
/*
    Problem 22. Words count

    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
 */
class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();

        string[] words = text.Split(new char[] { ' ', '.', '!', ',', '-', '?' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> uniqueWords = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (words[i] == words[j])
                {
                    isUnique = false;
                }
            }
            if (isUnique == true)
            {
                uniqueWords.Add(words[i]);
            }
        }

        int[] counter = new int[uniqueWords.Count];
        for (int i = 0; i < uniqueWords.Count; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (uniqueWords[i] == words[j])
                {
                    counter[i]++;
                }
            }
        }

        //output
        for (int i = 0; i < uniqueWords.Count; i++)
        {
            Console.WriteLine("{0} --> {1} times", uniqueWords[i], counter[i]);
        }

    }
}
