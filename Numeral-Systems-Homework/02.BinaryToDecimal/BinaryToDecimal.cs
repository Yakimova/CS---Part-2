using System;
/*
    Problem 2. Binary to decimal

    Write a program to convert binary numbers to their decimal representation.
 */
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = ConvertToDecimal(binaryNumber);
        Console.WriteLine("The decimal representation is: " + decimalNumber);
    }

    private static int ConvertToDecimal(string binary)
    {
        int result = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                result += (int)((binary[i] - '0') * Math.Pow(2, binary.Length - 1 - i));
            }
        }
        return result;
    }
}
