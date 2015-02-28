using System;
using System.IO;
using System.Text;
/*
    Problem 11. Prefix "test"

    Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0…9, a…z, A…Z, _.
 */
class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\testfile.txt");
        StringBuilder text = new StringBuilder();
        using (reader)
        {
            string input = reader.ReadToEnd();
            text.Append(input);
            string[] words = input.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.Length>=4 && word[0] == 't' && word[1] == 'e' && word[2] == 's' && word[3] == 't')
                {
                    text.Replace(word, "");
                }
            }
        }

        StreamWriter writer = new StreamWriter(@"..\..\testfile.txt");
        using (writer)
        {
            writer.Write(text);
        }
    }
}
