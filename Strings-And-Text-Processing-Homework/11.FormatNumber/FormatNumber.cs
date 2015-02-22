using System;
/*
    Problem 11. Format number

    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    Format the output aligned right in 15 symbols.
 */
class FormatNumber
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The decimal number is: {0,15}", number);
        Console.WriteLine("The hexadecimal number is: {0,15:X}", number);
        Console.WriteLine("The percentage is: {0,15:P}", number/100.0);
        Console.WriteLine("The scientific notation is: {0,15:E}", number);
    }
}
