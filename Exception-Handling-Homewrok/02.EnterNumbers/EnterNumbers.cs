using System;
/*
    Problem 2. Enter numbers

    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
class EnterNumbers
{
    static void Main()
    {
        int[] numbers = new int[10];
        numbers[0] = ReadNumber(1, 100);
        for (int i = 1; i < 10; i++)
        {
            numbers[i] = ReadNumber(numbers[i-1], 100);
        }
    }
    static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            Console.WriteLine("Please enter a number in the range [{0}..{1}]", start, end);
            number = int.Parse(Console.ReadLine());
            if (number<=start || number>=end)
            {
                throw new FormatException("Invalid input number!");
            }
        }
        catch
        {
            throw new FormatException("Invalid input number!");
        }
        return number;
 
    }
}
