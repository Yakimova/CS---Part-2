using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 3. Decimal to hexadecimal

    Write a program to convert decimal numbers to their hexadecimal representation.
 */
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<char> hexadecimalNumber = ConvertToHexadecimal(decimalNumber);
        Console.WriteLine("The hexadecimal representation is: " + string.Join("", hexadecimalNumber));
    }

    private static List<char> ConvertToHexadecimal(int decimalNumber)
    {
        List<char> hex = new List<char>();
        while (decimalNumber > 0)
        {
            if (decimalNumber % 16<=9)
            {
                hex.Add((char)(decimalNumber % 16+'0'));
            }
            else
            {
                int digit = decimalNumber % 16;
                hex.Add((char)(digit - 10 + 'A'));
            }
            decimalNumber /= 16;
        }
        hex.Reverse();
        return hex;
    }
}
