using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 7. Reverse number

    Write a method that reverses the digits of given decimal number.
 */
class ReverseNumber
{
    static void Main()
    {
        //input
        Console.Write("Please enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        int reversed = ReversingNumber(number);

        //output
        Console.WriteLine("The reversed number is: " + reversed);
    }

    private static int ReversingNumber(int number)
    {
        List<int> digit = new List<int>();
        while (number > 0)
        {
            digit.Add(number % 10);
            number /= 10;
        }
        int result = 0;
        for (int i = 0; i < digit.Count; i++)
        {
            result += (digit[i] * (int)(Math.Pow(10, (digit.Count - i - 1))));
        }
        return result;
    }
}
