using System;
/*
    Problem 3. English digit

    Write a method that returns the last digit of given integer as an English word.
 */
class EnglishDigit
{
    static void Main()
    {
        Console.Write("Please enter the integer number: ");
        int number = int.Parse(Console.ReadLine()); //512;

        Console.WriteLine(ReturnLastDigitAsWord(number));
    }
    private static string ReturnLastDigitAsWord(int number)
    {
        string result;
        int digit = number % 10;
        switch (digit)
        {
            case 0: result = "zero"; break;
            case 1: result = "one"; break;
            case 2: result = "two"; break;
            case 3: result = "three"; break;
            case 4: result = "four"; break;
            case 5: result = "five"; break;
            case 6: result = "six"; break;
            case 7: result = "seven"; break;
            case 8: result = "eight"; break;
            case 9: result = "nine"; break;
            default: result = "not a digit"; break;
        }
        return result;
    }
}
