using System;
using System.IO;
using System.Text;
/*
    Problem 10. Extract text from XML

    Write a program that extracts from given XML file all the text without the tags.
 */
class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\XMLfile.xml");
        StringBuilder text = new StringBuilder();
        using (reader)
        {
            string input = reader.ReadToEnd();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    while (input[i] != '>')
                    {
                        i++;
                    }
                }
                else
                {
                    text.Append(input[i]);
                }
            }
        }

        StreamWriter writer = new StreamWriter(@"..\..\XMLfile.xml");
        using (writer)
        {
            writer.Write(text);
        }
    }
}
