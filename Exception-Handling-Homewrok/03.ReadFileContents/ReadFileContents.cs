using System;
using System.IO;
/*
    Problem 3. Read file contents

    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
 */
class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Please enter the path to a file: ");
        string path = Console.ReadLine();//@"C:\Windows\Help\bg-BG\credits.rtf";
        try
        {
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file is empty!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You cannot reach this file!");
        }
        catch
        {
            Console.WriteLine("An error occured, please try again");
        }
    }
}