using System;
using System.IO;
using System.Collections.Generic;
/*
    Problem 6. Save sorted names

    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
 */
class SaveSortedNames
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\input.txt");
        using (reader)
        {
            List<string> names = new List<string>(); 
            string currentName = reader.ReadLine();
            while (currentName!=null)
            {
                names.Add(currentName);
                currentName = reader.ReadLine();
            }

            names.Sort();
            var writer = new StreamWriter(@"..\..\output.txt");
            using (writer)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }
        }
    }
}
