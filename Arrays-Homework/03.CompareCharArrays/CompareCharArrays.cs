using System;
/*
    Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/
class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter the first char array: ");
        string input1 = Console.ReadLine();
        char[] array1 = input1.ToCharArray();
        Console.WriteLine("Please enter the second char array: ");
        string input2 = Console.ReadLine();
        char[] array2 = input2.ToCharArray();
        int length = Math.Min(array1.Length, array2.Length);
        bool first = true;
        for (int index = 0; index < length; index++)
        {
            if (array1[index] < array2[index])
            {
                first = false;
                break;
            }
        }
        if (first == true)
        {
            Console.WriteLine("The first array is lexicografically first! - "+ input1);
        }
        else
        {
            Console.WriteLine("The second array is lexicografically first! - " + input2);
        }
    }
}