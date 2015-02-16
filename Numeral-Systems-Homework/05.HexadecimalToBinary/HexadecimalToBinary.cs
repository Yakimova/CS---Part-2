using System;
/*
    Problem 5. Hexadecimal to binary

    Write a program to convert hexadecimal numbers to binary numbers (directly).
 */
class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine();
        string[] binary = new string[hexNumber.Length];
        for (int i = 0; i < hexNumber.Length; i++)
        {
            int digit = 0;
            if (hexNumber[i] <= '9' && hexNumber[i] >= '0')
            {
                digit = (int)(hexNumber[i] - '0');
            }
            else if (hexNumber[i] <= 'F' && hexNumber[i] >= 'A')
            {
                digit = (int)(hexNumber[i] - 'A' + 10);
            }
            binary[i] = ConvertDigitToBinary(digit);
        }
        Console.WriteLine("The binary representation is: " + string.Join("", binary));
    }
    private static string ConvertDigitToBinary(int digit)
    {
        string result = "";
        for (int i = 0; i < 4; i++)
        {
            result += (digit % 2);
            digit /= 2;
        }
        string newresult = "";
        for (int i = 0; i < 4; i++)
        {
            newresult +=result[3-i];
        }
        return newresult;
    }
}
