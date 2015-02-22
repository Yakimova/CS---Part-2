using System;
using System.Text;
/*
    Problem 15. Replace tags

    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */
class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Please enter the string: ");
        string input = Console.ReadLine();
        StringBuilder workingText = new StringBuilder();
        workingText.Append(input);
        int possition = 0;
        while (possition <=input.Length && input.IndexOf("<a href", possition)>=0)
        {
            int startpossition = input.IndexOf("<a href", possition);
            int endpossition = input.IndexOf("</a>", possition) + 3;
            possition = endpossition + 1;
            int numberOfSymbols = endpossition-startpossition+1;
            workingText.Replace("<a href", "[URL", startpossition, numberOfSymbols);
            workingText.Replace("</a>", "[/URL]", startpossition, numberOfSymbols);
            workingText.Replace(">", "]", startpossition, numberOfSymbols);
            workingText.Replace("\"", "", startpossition, numberOfSymbols);
        }
        Console.WriteLine(workingText);

    }
}