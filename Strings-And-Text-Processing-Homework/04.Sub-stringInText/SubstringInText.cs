using System;
/*
    Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */
class SubstringInText
{
    static void Main()
    {
        Console.WriteLine("Please enter a text: ");
        string input = Console.ReadLine();
        Console.Write("Please enter the target sub-string: ");
        string target = Console.ReadLine();

        int counter = 0;
        int possition = 0;
        while (input.IndexOf(target, possition) >= 0)
        {
            counter++;
            possition = input.IndexOf(target, possition) + 1;
        }
        Console.WriteLine("Result: {0} times", counter);
    }
}
