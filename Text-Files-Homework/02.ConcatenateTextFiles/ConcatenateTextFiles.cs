using System;
using System.IO;
/*
    Problem 2. Concatenate text files

    Write a program that concatenates two text files into another text file.
 */
class ConcatenateTextFiles
{
    static void Main()
    {
        string firstText = "";
        var firstreader = new StreamReader(@"..\..\file1.txt");
        using (firstreader)
        {
            firstText = firstreader.ReadToEnd();
        }

        string secondText = "";
        var secondreader = new StreamReader(@"..\..\file2.txt");
        using (secondreader)
        {
            secondText = secondreader.ReadToEnd();
        }

        var resultWriter = new StreamWriter(@"..\..\resultfile.txt");
        using (resultWriter)
        {
            resultWriter.WriteLine(firstText);
            resultWriter.WriteLine(secondText);
        }
    }
}
