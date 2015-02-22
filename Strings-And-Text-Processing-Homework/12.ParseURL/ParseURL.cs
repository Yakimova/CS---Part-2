using System;
using System.Text;
/*
    Problem 12. Parse URL

    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 */
class ParseURL
{
    static void Main()
    {
        Console.WriteLine("PLease enter an URL address: ");
        string input = Console.ReadLine(); //"http://telerikacademy.com/Courses/Courses/Details/212";
        StringBuilder protocol = new StringBuilder();
        for (int i = 0; i < input.IndexOf("//") - 1; i++)
        {
            protocol.Append(input[i]);
        }

        StringBuilder server = new StringBuilder();
        for (int i = input.IndexOf("//") + 2; i < input.IndexOf("/", input.IndexOf("//") + 2); i++)
        {
            server.Append(input[i]);
        }

        StringBuilder resource = new StringBuilder();
        for (int i = input.IndexOf("/", input.IndexOf("//") + 2); i < input.Length; i++)
        {
            resource.Append(input[i]);
        }

        Console.WriteLine(@"[protocol] = {0}
[server] = {1}
[resource] = {2}", protocol, server, resource);
    }
}
