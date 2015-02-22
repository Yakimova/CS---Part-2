using System;
/*
    Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.

    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */
class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Please enter the expression: ");
        string input = Console.ReadLine();
        if (input.IndexOf('(') == -1)
        {
            if (input.IndexOf(')') == -1)
            {
                Console.WriteLine("There are no brackets.");
            }
            else
            {
                Console.WriteLine("Incorrect expression.");
            }
        }
        else if (input.IndexOf(')') == -1)
        {
            Console.WriteLine("Incorrect expression.");
        }
        else if (input.IndexOf('(') > input.IndexOf(')'))
        {
            Console.WriteLine("Incorrect expression.");
        }
        else if (input.LastIndexOf('(') > input.LastIndexOf('('))
        {
            Console.WriteLine("Incorrect expression.");
        }
        else 
        {
            int countOpenBrackets = 0;
            int countCloseBrackets = 0;
            int possition = 0;
            while (input.IndexOf('(', possition)>=0)
            {
                possition = input.IndexOf('(', possition)+1;
                countOpenBrackets++;
            }
            possition = 0;
            while (input.IndexOf(')', possition)>=0)
            {
                possition = input.IndexOf(')', possition)+1;
                countCloseBrackets++;
            }

            if (countOpenBrackets!=countCloseBrackets)
            {
                Console.WriteLine("Incorrect expression.");
            }
            else
            {
                Console.WriteLine("Correct expression");
            }
        }
    }
}
