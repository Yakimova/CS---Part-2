using System;
/*
    Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */
class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Please enter the first integer: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second integer: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third integer: ");
        int third = int.Parse(Console.ReadLine());

        Console.WriteLine("The largest number is: " + GetMax(GetMax(first, second),  third));
    }
    private static int GetMax(int first, int second)
    {
        int max = 0;
        if (first >= second)
        {
            max = first;
        }
        else
        {
            max = second;
        }
        return max;
    }
}
