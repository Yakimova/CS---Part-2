using System;
using System.IO;
using System.Text;
/*
    Problem 8. Replace whole word

    Modify the solution of the previous problem to replace only whole words (not strings).
 */
class ReplaceWholeWord
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\file.txt");
        
        StringBuilder text = new StringBuilder();
        using (reader)
        {
            text.Append(reader.ReadToEnd());
        }
        text.Replace(" start ", " finish ");
        text.Replace(" start,", " finish,");
        text.Replace(" start.", " finish.");
        text.Replace("Start ", "Finish ");

        var writer = new StreamWriter(@"..\..\file.txt");
        using (writer)
        {
            writer.Write(text);
        }
    }
}
