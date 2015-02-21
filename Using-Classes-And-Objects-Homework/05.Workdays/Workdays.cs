using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 5. Workdays

    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */
class Workdays
{
    static void Main()
    {
        Console.Write("Please enter a future date in the format (dd/mm/yyyy): ");
        string input = Console.ReadLine();
        string[] temp = input.Split('/');
        int day = int.Parse(temp[0]);
        int month = int.Parse(temp[1]);
        int year = int.Parse(temp[2]);
        DateTime wantedDate = new DateTime(year, month, day);

        DateTime dateNow = DateTime.Today;

        List<DateTime> holidays = new List<DateTime>() { new DateTime(2015, 3, 2), new DateTime(2015, 3, 3), new DateTime(2015, 04, 10), new DateTime(2015, 04, 11), new DateTime(2015, 04, 12), new DateTime(2015, 04, 13) };
        int numberOfWorkDays = 0;
        for (DateTime i = dateNow; i <= wantedDate; i = i.AddDays(1))
        {
            bool isHoliday = false;
            if ((int)i.DayOfWeek != 0 && (int)i.DayOfWeek != 6)
            {
                for (int j = 0; j < holidays.Count; j++)
                {
                    if (holidays[j] == i)
                    {
                        isHoliday = true;
                    }
                }
            }
            if (isHoliday == false)
            {
                numberOfWorkDays++;
            }
        }
        Console.WriteLine("The numbers of work days in that period is: " + numberOfWorkDays);
    }
}
