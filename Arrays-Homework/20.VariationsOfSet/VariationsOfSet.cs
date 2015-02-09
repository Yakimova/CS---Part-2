using System;
/*
    Problem 20.* Variations of set

    Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
*/
class VariationsOfSet
{
    private static void Variations(int[] array, int[] newarray, int index)
    {
        if (index == newarray.Length)
        {
            Console.WriteLine("{"+ string.Join(", ", newarray)+ "}");
            return;
        }

        for (int i = 0; i < array.Length; i++)
        {
            newarray[index] = array[i];
            Variations(array, newarray, index + 1);
        }
    }
    static void Main()
    {
        //input
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());//3;
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());//2;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }

        Variations(array, new int[k], 0);
    }
}
