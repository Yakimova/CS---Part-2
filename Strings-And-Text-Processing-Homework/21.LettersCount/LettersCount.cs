using System;
using System.Text;
/*
    Problem 21. Letters count

    Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
 */
class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();
        StringBuilder workingText = new StringBuilder();
        workingText.Append(text.ToLower());

        string allLetters = "abcdefghijklmnopqrstuvwxyz";
        int[] countingLetters = new int[26];
        for (int i = 0; i < workingText.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (workingText[i] == allLetters[j])
                {
                    countingLetters[j]++;
                }
            }
        }
        for (int i=0; i<26; i++)
        {
            if (countingLetters[i] > 0)
            {
                Console.WriteLine("{0} --> {1} times", allLetters[i], countingLetters[i]);
            }
        }
    }
}