using System;
using System.IO;
/*
    Problem 3. Line numbers

    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
 */
class LineNumbers
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\initialFile.txt");
        using (reader)
        {
            var writer = new StreamWriter(@"..\..\resultFile.txt");
            string currentLine = reader.ReadLine();
            int line = 1;
            while (currentLine != null)
            {
                writer.Write(line + ". ");
                writer.WriteLine(currentLine);
                line++;
                currentLine = reader.ReadLine();
            }
            writer.Close();
        }
    }
}
