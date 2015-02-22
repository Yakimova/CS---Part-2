using System;
using System.Globalization;
using System.Threading;
/*
    Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */
class DateInBulgarian
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =new CultureInfo("bg-BG");
        Console.WriteLine("Please enter the first date in the format day.month.year hout:minute:second: ");
        string input = Console.ReadLine(); //"22.02.2015 2:43:30";
        DateTime inputDate = DateTime.ParseExact(input, "d.M.yyyy h:m:s", CultureInfo.InvariantCulture);
        inputDate = inputDate.AddHours(6.5);
        Console.WriteLine(inputDate);
        Console.WriteLine(inputDate.ToString("dddd"));
        
    }
}
