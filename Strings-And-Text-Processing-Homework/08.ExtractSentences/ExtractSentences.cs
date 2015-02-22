using System;
using System.Text;
/*
    Problem 8. Extract sentences

    Write a program that extracts from a given text all sentences containing given word.

Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */
class ExtractSentences
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        StringBuilder middleWord = new StringBuilder();
        middleWord.Append(" ");
        middleWord.Append(word);
        middleWord.Append(" ");
        StringBuilder endWord = new StringBuilder();
        endWord.Append(" ");
        endWord.Append(word);
        endWord.Append(".");


        Console.WriteLine("Result: ");
        int possition = 0;
        while (text.IndexOf(".", possition) >= 0)
        {
            StringBuilder sentence = new StringBuilder();
            for (int i=possition; i<=text.IndexOf(".", possition); i++)
            {
                sentence.Append(text[i]);
            }
            string thisSentence = sentence.ToString();
            if (thisSentence.IndexOf(middleWord.ToString()) >= 0 || thisSentence.IndexOf(endWord.ToString()) >= 0)
            {
                Console.Write(thisSentence);
            }
            possition = text.IndexOf(".", possition) + 1;
        }
        Console.WriteLine();
    }
}
