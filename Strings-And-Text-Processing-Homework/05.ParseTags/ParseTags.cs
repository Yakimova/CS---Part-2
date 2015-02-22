using System;
using System.Text;
/*
    Problem 5. Parse tags

    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.

Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */
class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string input = Console.ReadLine();
        string upperInput = input.ToUpper();
        int possition = 0;
        StringBuilder result = new StringBuilder();
        while (input.IndexOf("<upcase>", possition) >= 0)
        {
            for (int i=possition; i< input.IndexOf("<upcase>", possition); i++)
            {
                result.Append(input[i]);
            }
            for (int i = input.IndexOf("<upcase>", possition) + 8; i < input.IndexOf("</upcase>", possition); i++)
            {
                result.Append(upperInput[i]);
            }
            possition = input.IndexOf("</upcase>", possition) + 9;
        }
        for (int i = possition; i < input.Length; i++)
        {
            result.Append(input[i]);
        }
        string output = result.ToString();
        Console.WriteLine(output);
    }
}
