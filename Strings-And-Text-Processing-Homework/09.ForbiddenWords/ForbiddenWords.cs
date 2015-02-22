using System;
using System.Text;
/*
    Problem 9. Forbidden words

    We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */
class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string text = Console.ReadLine();
        StringBuilder workingText = new StringBuilder();
        workingText.Append(text);
        Console.Write("Please enter the forbidden word, seperated by \",\": ");
        string wordsInput = Console.ReadLine();
        string[] forbiddenWords = wordsInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            int lengthOfWord = forbiddenWords[i].Length;
            StringBuilder asterisks = new StringBuilder();
            for (int j=0; j<lengthOfWord; j++)
            {
                asterisks.Append('*');
            }
            workingText.Replace(forbiddenWords[i], asterisks.ToString());
        }

        string result = workingText.ToString();
        Console.WriteLine("Result: ");
        Console.WriteLine(result);
        
    }
}
