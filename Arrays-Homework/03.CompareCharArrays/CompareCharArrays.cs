using System;
/*
    Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/
class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Please enter the number of elements in the arrays: ");
        int elements = int.Parse(Console.ReadLine());
        char[] array1 = new char[elements];
        char[] array2 = new char[elements];
        for (int index = 0; index < elements; index++)
        {
            Console.Write("array1[{0}] = ", index);
            array1[index] = char.Parse(Console.ReadLine());
        }
        for (int index = 0; index < elements; index++)
        {
            Console.Write("array2[{0}] = ", index);
            array2[index] = char.Parse(Console.ReadLine());
        }
        bool areEqual = true;
        for (int index = 0; index < elements; index++)
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