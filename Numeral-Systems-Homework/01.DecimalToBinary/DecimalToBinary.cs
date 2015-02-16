using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 1. Decimal to binary

    Write a program to convert decimal numbers to their binary representation.
 */
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        List<int> binaryNumber = ConvertToBinary(decimalNumber);
        Console.WriteLine("The binary representation is: " + string.Join("", binaryNumber));
    }

    private static List<int> ConvertToBinary(int decimalNumber)
    {
        List<int> binary = new List<int>();
        while (decimalNumber > 0)
        {
            binary.Add(decimalNumber % 2);
            decimalNumber /= 2;
        }
        binary.Reverse();
        return binary;
    }
}
