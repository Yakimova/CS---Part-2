using System;
using System.Globalization;
/*
    Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 */
class DateDifference
{
    static void Main()
    {
        Console.Write("Please enter the first date in the format day.month.year: ");
        string firstInput = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstInput, "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Please enter the second date in the format day.month.year: ");
        string secondInput = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(secondInput, "d.M.yyyy", CultureInfo.InvariantCulture);
        double days = (secondDate - firstDate).TotalDays;
        Console.WriteLine("The number of days is: " + days);
        
    }
}
