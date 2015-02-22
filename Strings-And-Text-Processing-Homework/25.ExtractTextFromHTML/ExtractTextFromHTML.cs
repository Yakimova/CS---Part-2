using System;
using System.Text;
/*
    Problem 25. Extract text from HTML

    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
 */
class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Please enter text from a HTML file: ");
        string input = Console.ReadLine(); //"<html><head><title>News</title></head><body><p><a href="http://academy.telerik.com">Telerik Academy </a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        int startpossition = 0;
        if (input.IndexOf("<title>") >= 0)
        {
            StringBuilder title = new StringBuilder();
            for (int i = input.IndexOf("<title>") + 7; i < input.IndexOf("</title>"); i++)
            {
                title.Append(input[i]);
            }
            Console.WriteLine("Title: " + title);
            startpossition = input.IndexOf("</title>") + 8;
        }

        bool isText = false;
        StringBuilder text = new StringBuilder();
        for (int i = startpossition; i < input.Length; i++)
        {
            if (input[i] == '<')
            {
                isText = false;
            }
            if (input[i] == '>')
            {
                isText = true;
            }
            if (isText == true && input[i] != '>')
            {
                text.Append(input[i]);
            }
        }
        Console.WriteLine("Text: " + text);
    }
}
