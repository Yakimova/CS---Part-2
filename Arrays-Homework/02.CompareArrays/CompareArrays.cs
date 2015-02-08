using System;
/*
    Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.
*/
class CompareArrays
{
    static void Main()
    {
        Console.Write("Please enter the number of elements in the arrays: ");
        int elements = int.Parse(Console.ReadLine());
        int[] array1 = new int[elements];
        int[] array2 = new int[elements];
        for (int index = 0; index < elements; index++)
        {
            Console.Write("array1[{0}] = ", index);
            array1[index] = int.Parse(Console.ReadLine());
        }
        for (int index = 0; index < elements; index++)
        {
            Console.Write("array2[{0}] = ", index);
            array2[index] = int.Parse(Console.ReadLine());
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
