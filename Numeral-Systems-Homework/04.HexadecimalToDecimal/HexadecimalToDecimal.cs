using System;
/*
    Problem 4. Hexadecimal to decimal

    Write a program to convert hexadecimal numbers to their decimal representation.
 */
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine();
        int decimalNumber = ConvertToDecimal(hexNumber);
        Console.WriteLine("The decimal representation is: " + decimalNumber);
    }
    private static int ConvertToDecimal(string hex)
    {
        int result = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            if (hex[i] <= '9' && hex[i]>='0')
            {
                result += (int)((hex[i] - '0') * Math.Pow(16, hex.Length - 1 - i));
            }
            else 
            {
                result += (int)((hex[i] - 'A' + 10) * Math.Pow(16, hex.Length - 1 - i));
            }
        }
        return result;
    }
}
