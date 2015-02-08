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

        if (array1.Length != array2.Length)
        {
            Console.WriteLine("The two char arrays have different number of elements.");
        }
        else
        {
            bool areEqual = true;
            for (int index = 0; index < array1.Length; index++)
            {
                if (array1[index] != array2[index])
                {
                    areEqual = false;
                    break;
                }
            }
            if (areEqual == true)
            {
                Console.WriteLine("The two arrays are equal!");
            }
            else
            {
                Console.WriteLine("The two arrays are NOT equal!");
            }
        }
    }
}