using System;
using System.IO;
using System.Text;
/*
    Problem 9. Delete odd lines

    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
 */
class DeleteOddLines
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\file.txt");
        StringBuilder text = new StringBuilder();
        int line = 1;
        using (reader)
        {
            string currentline = reader.ReadLine();
            while (currentline!=null)
            {
                if (line % 2 == 0)
                {
                    text.AppendLine(currentline);
                }
                line++;
                currentline = reader.ReadLine();
            }
        }

        var writer = new StreamWriter(@"..\..\file.txt");
        using (writer)
        {
            writer.Write(text);
        }
    }
}
