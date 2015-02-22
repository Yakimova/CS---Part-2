using System;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;
/*
    Problem 19. Dates from text in Canada

    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.
 */
class DatesFromTextInCanada
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        Console.WriteLine("Please enter a text: ");
        string text = Console.ReadLine();
        foreach (var match in Regex.Matches(text, @"\w+\.\w+\.\w+"))
        {
            Console.WriteLine(match);
        }
    }
}
