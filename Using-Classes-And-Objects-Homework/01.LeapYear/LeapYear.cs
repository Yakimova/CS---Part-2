using System;
/*
    Problem 1. Leap year

    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
 */
class LeapYear
{
    static void Main()
    {
        Console.Write("Please enter a year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        if (isLeap == true)
        {
            Console.WriteLine("{0} is leap year!", year);
        }
        else
        {
            Console.WriteLine("{0} is NOT leap year!", year);
        }
    }
}