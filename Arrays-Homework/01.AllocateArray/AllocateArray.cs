using System;
/*
    Problem 1. Allocate array

    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.
*/
class AllocateArray
{
    static void Main()
    {
        int[] array = new int[20];
        for (int index = 0; index < 20; index++)
        {
            array[index] = index * 5;
        }
        for (int index = 0; index < 20; index++)
        {
            Console.WriteLine("array[{0}] = {1}", index, array[index]);
        }
    }
}
