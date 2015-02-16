using System;
/*
    Problem 6. binary to hexadecimal

    Write a program to convert binary numbers to hexadecimal numbers (directly).
 */
class BinaryToHexadecimal
{
    static void Main()
    {
        string binary = GettingBinary();
        string hex = ConvertingToHexadecimal(binary);
        Console.WriteLine("The hexadecimal representation is: " + hex);
    }
    static string GettingBinary()
    {
        Console.Write("Please enter a binary number: ");
        string binary = Console.ReadLine();
        string newbinary = "";
        int addBefore = 4 - (binary.Length % 4);
        if (addBefore == 4)
        {
            addBefore = 0;
        }
        for (int i = 0; i < addBefore; i++)
        {
            newbinary += '0';
        }
        for (int i = addBefore; i < binary.Length + addBefore; i++)
        {
            newbinary += binary[i - addBefore];
        }
        return newbinary;
    }
    static string ConvertingToHexadecimal(string newbinary)
    {
        string hex = "";
        for (int i = 0; i < newbinary.Length; i += 4)
        {
            string stringdigit = "";
            for (int j = 0; j < 4; j++)
            {
                stringdigit += newbinary[i + j];
            }
            int value = 0;
            for (int j = 0; j < 4; j++)
            {
                value += (int)((stringdigit[j] - '0') * Math.Pow(2, 3 - j));
            }
            if (value <= 9)
            {
                hex += value;
            }
            else
            {
                hex += (char)(value + 'A' - 10);
            }
        }
        return hex;
    }

}
