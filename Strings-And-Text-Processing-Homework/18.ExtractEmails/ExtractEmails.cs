using System;
using System.Text.RegularExpressions;
/*
    Problem 18. Extract e-mails

    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */
class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();
        foreach (var match in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(match);
        }
    }
}
