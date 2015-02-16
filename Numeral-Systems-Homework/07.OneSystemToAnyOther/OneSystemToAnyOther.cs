using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 7. One system to any other

    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */
class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Please enter the base of the start system: ");
        int startbase = int.Parse(Console.ReadLine());
        Console.Write("Please enter the base of the end system: ");
        int endbase = int.Parse(Console.ReadLine());
        Console.Write("Please enter the start number: ");
        string start = Console.ReadLine();

        int decimalNumber = ConvertToDecimal(start, startbase);
        string end = ConvertToBase(decimalNumber, endbase);
        Console.WriteLine("The converted number looks like this: " + end);
    }
    private static int ConvertToDecimal(string start, int startbase)
    {
        int result = 0;
        for (int i = 0; i < start.Length; i++)
        {
            if (start[i] <= '9' && start[i] >= '0')
            {
                result += (int)((start[i] - '0') * Math.Pow(startbase, start.Length - 1 - i));
            }
            else
            {
                result += (int)((start[i] - 'A' + 10) * Math.Pow(startbase, start.Length - 1 - i));
            }
        }
        return result;
    }
    private static string ConvertToBase(int decimalNumber, int endbase)
    {
        List<char> end = new List<char>();
        while (decimalNumber > 0)
        {
            if (decimalNumber % endbase <= 9)
            {
                end.Add((char)(decimalNumber % endbase + '0'));
            }
            else 
            {
                int digit = decimalNumber % endbase;
                end.Add((char)(digit - 10 + 'A'));
            }
            decimalNumber /= endbase;
        }
        end.Reverse();
        string result = "";
        for (int i = 0; i < end.Count; i++)
        {
            result += end[i];
        }
        return result;
    }
}
