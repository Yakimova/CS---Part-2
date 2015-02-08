using System;
/*
    Problem 12. Index of letters

    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
 */
class IndexOfLetters
{
    static void Main()
    {
        //creating the array
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            // (int)'A' = 65
            alphabet[i] = (char)(i + 65);
        }

        //input
        Console.Write("Please enter a word with capital letters: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine(word[i] + "--> " + j);
                }
            }
        }
    }
}
