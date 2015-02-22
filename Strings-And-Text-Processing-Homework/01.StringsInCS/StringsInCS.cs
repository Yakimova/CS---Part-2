using System;
/*
    Problem 1. Strings in C#.

    Describe the strings in C#.
    What is typical for the string data type?
    Describe the most important methods of the String class.
 */
class StringsInCS
{
    static void Main()
    {
        Console.WriteLine("A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects.");
        Console.WriteLine("Typical for the string data type is that it's length represents the number of char objects it contains.");
        Console.WriteLine(@"Some of the most important methods of the string class are: 
1. Compare
2. Concat
3. Contains
4. IndexOf
5. LastIndexOf
6. Insert
7. Join
8. Remove
9. Replace
10. Split
11. Substring
12. Trim");
    }
}
