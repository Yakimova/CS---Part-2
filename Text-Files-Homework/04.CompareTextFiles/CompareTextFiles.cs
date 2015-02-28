using System;
using System.IO;
/*
    Problem 4. Compare text files

    Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
 */
class CompareTextFiles
{
    static void Main()
    {
        int sameLines = 0;
        int differentLines = 0;

        var firstreader = new StreamReader(@"..\..\firstFile.txt");
        using (firstreader)
        {
            string firstTextLine = firstreader.ReadLine();
            var secondreader = new StreamReader(@"..\..\secondFile.txt");
            string secondTextLine = secondreader.ReadLine();
            while (firstTextLine != null && secondTextLine!=null)
            {
                if (firstTextLine == secondTextLine)
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }
                firstTextLine = firstreader.ReadLine();
                secondTextLine = secondreader.ReadLine();
            }
            secondreader.Close();
        }

        Console.WriteLine("The number of lines that are the same is: " + sameLines);
        Console.WriteLine("The number of lines that are different is: " + differentLines);
    }
}
