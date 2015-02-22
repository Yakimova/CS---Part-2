using System;
/*
    Problem 20. Palindromes

    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */
class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', '.', '!', ',', '-', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            bool palindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1])
                {
                    palindrome = false;
                }
            }

            if (palindrome == true)
            {
                Console.WriteLine(word);
            }
        }
    }
}
