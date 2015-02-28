using System;
using System.IO;
/*
    Problem 1. Odd lines

    Write a program that reads a text file and prints on the console its odd lines.
 */
class OddLines
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\testfile.txt");
        using (reader)
        {
            string currentLine = reader.ReadLine();
            int line = 1;
            while (currentLine!=null)
            {
                if (line % 2 != 0)
                {
                    Console.WriteLine(currentLine);
                }
                line++;
                currentLine = reader.ReadLine();
            }
        }
    }
}
