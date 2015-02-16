using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 8. Binary short

    Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */
class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter a 16-bit signed integer number: ");
        short number = short.Parse(Console.ReadLine());

        if (number >= 0)
        {
            PossitiveBinary(number);
        }
        else
        {
            NegativeBinary(number);
        }
    }

    private static void NegativeBinary(short number)
    {
        int newnumber = 32768 - Math.Abs(number);
        List<int> binary = new List<int>();
        while (newnumber > 0)
        {
            binary.Add(newnumber % 2);
            newnumber /= 2;
        }
        while (binary.Count < 15)
        {
            binary.Add(0);
        }
        binary.Add(1);
        binary.Reverse();
        Console.WriteLine("The binary representation is: " + string.Join("", binary));
    }

    private static void PossitiveBinary(short number)
    {
        List<int> binary = new List<int>();
        while (number > 0)
        {
            binary.Add(number % 2);
            number /= 2;
        }
        while (binary.Count<16)
        {
            binary.Add(0);
        }
        binary.Reverse();
        Console.WriteLine("The binary representation is: " + string.Join("", binary));
    }
}
