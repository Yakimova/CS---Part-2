using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
/*
    Problem 13. Count words

    Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
    The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
    Handle all possible exceptions in your methods.
 */
class CountWords
{
    static void Main()
    {
        try
        {
            //getting the words
            StreamReader readingWords = new StreamReader(@"..\..\words.txt");
            List<string> words = new List<string>();
            using (readingWords)
            {
                string input = readingWords.ReadToEnd();
                string[] stringwords = input.Split(new char[] { ' ', ',', '.', '!', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < stringwords.Length; i++)
                {
                    words.Add(stringwords[i].ToLower());
                }
            }

            //taking all words from the test file
            StreamReader readingtext = new StreamReader(@"..\..\test.txt");
            List<string> allwords = new List<string>();
            using (readingtext)
            {
                string text = readingtext.ReadToEnd();
                string[] stringallwords = text.Split(new char[] { ' ', ',', '.', '!', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < stringallwords.Length; i++)
                {
                    allwords.Add(stringallwords[i].ToLower());
                }
            }

            //counting
            int[] appearence = new int[words.Count];
            for (int i = 0; i < allwords.Count; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (allwords[i] == words[j])
                    {
                        appearence[j]++;
                    }
                }
            }

            StreamWriter write = new StreamWriter(@"..\..\result.txt");
            using (write)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    int currentmax = -1;
                    int index = -1;
                    for (int j = 0; j < words.Count; j++)
                    {
                        if (appearence[j] > currentmax)
                        {
                            currentmax = appearence[j];
                            index = j;
                        }
                    }
                    write.WriteLine(words[index] + " --> " + appearence[index]);
                    appearence[index] = -1;
                }
            }
            
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file could not be found");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have access to this file");
        }
    }
}