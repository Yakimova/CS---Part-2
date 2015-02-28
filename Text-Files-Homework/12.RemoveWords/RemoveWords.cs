using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
/*
    Problem 12. Remove words

    Write a program that removes from a text file all words listed in given another text file.
    Handle all possible exceptions in your methods.
 */

class RemoveWords
{
    static void Main()
    {
        try
        {
            StreamReader readingWords = new StreamReader(@"..\..\wordsToBeRemoved.txt");
            List<string> forbidenwords = new List<string>();
            using (readingWords)
            {
                string input = readingWords.ReadToEnd();
                string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    forbidenwords.Add(words[i]);
                }
            }

            StreamReader readingtext = new StreamReader(@"..\..\initialfile.txt");
            StringBuilder text = new StringBuilder();
            text.Append(readingtext.ReadToEnd());
            readingtext.Close();
            for (int i=0; i<forbidenwords.Count; i++)
            {
                text.Replace(forbidenwords[i], "");
            }

            StreamWriter writingtext = new StreamWriter(@"..\..\initialfile.txt");
            writingtext.Write(text);
            writingtext.Close();
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
