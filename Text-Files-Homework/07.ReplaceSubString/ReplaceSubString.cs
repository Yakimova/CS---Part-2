using System;
using System.IO;
using System.Text;
/*
    Problem 7. Replace sub-string

    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    Ensure it will work with large files (e.g. 100 MB).
 */
class ReplaceSubString
{
    static void Main()
    {
         var reader = new StreamReader(@"..\..\file.txt");
         StringBuilder text = new StringBuilder();
         using (reader)
         {
             text.Append(reader.ReadToEnd());
         }
         text.Replace("start", "finish");

         var writer = new StreamWriter(@"..\..\file.txt");
         using (writer)
         {
             writer.Write(text);
         }
    }
}
