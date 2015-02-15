using System;
using System.Collections.Generic;
using System.Linq;
/*
    Problem 8. Number as array

    Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.
 */
class NumberAsArray
{
    static void Main()
    {
        //input
        byte[] firstArray = CreatingReversedArray();
        byte[] secondArray = CreatingReversedArray();
        byte[] sum = AddingArraysByDigits(firstArray, secondArray);
        if (sum[sum.Length - 1] == 0)
        {
            byte[] newSum = new byte[sum.Length - 1];
            for (int i = 0; i < sum.Length - 1; i++)
            {
                newSum[i] = sum[i];
            }
            for (int i = 0; i < sum.Length - 1; i++)
            {
                Console.Write(sum[sum.Length - 2 - i]);
            }
        }
        else
        {
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[sum.Length - 1 - i]);
            }
        }
        Console.WriteLine();
    }
    static byte[] AddingArraysByDigits(byte[] firstArray, byte[] secondArray) 
    {
        int maxLength = Math.Max(firstArray.Length, secondArray.Length);
        int minLength = Math.Min(firstArray.Length, secondArray.Length);
        byte remain = 0;
        byte[] sum = new byte[maxLength + 1];
        byte[] newFirstArray = new byte[maxLength + 1];
        for (int j = 0; j < maxLength + 1; j++)
        {
            if (j < firstArray.Length)
            {
                newFirstArray[j] = firstArray[j];
            }
            else
            {
                newFirstArray[j] = 0;
            }
        }
        byte[] newSecondArray = new byte[maxLength + 1];
        for (int j = 0; j < maxLength + 1; j++)
        {
            if (j < secondArray.Length)
            {
                newSecondArray[j] = secondArray[j];
            }
            else
            {
                newSecondArray[j] = 0;
            }
        }
        for (int k = 0; k < maxLength + 1; k++)
        {
            sum[k] = Sum(newFirstArray[k],newSecondArray[k],remain);
            if (sum[k] >= 10)
            {
                remain = 1;
                sum[k] %= 10;
            }
            else
            {
                remain = 0;
            }
        }
        return sum;

    }
    static byte Sum(byte a, byte b, byte c)
    {
        byte sum = (byte)(a + b + c);
        return sum;
    }
    private static byte[] CreatingReversedArray()
    {
        Console.Write("Please enter array of digits: ");
        string input = Console.ReadLine();
        byte[] array = new byte[input.Length];
        for (int i = 0; i<input.Length; i++)
        {
            array[i] = (byte)(input[i]-'0');
        }
        for (int i = 0; i < input.Length / 2; i++)
        {
            byte temp = array[i];
            array[i] = array[input.Length - 1 - i];
            array[input.Length - 1 - i] = temp;
        }
        return array;
    }
}