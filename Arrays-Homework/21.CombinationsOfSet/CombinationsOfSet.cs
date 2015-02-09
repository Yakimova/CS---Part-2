using System;
/*
    Problem 21.* Combinations of set

    Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
*/
class CombinationsOfSet
{
    private static void Combinations(int[] array, int[] newarray, int index, int possition)
    {
        if (index == newarray.Length)
        {
            Console.WriteLine("{" + string.Join(", ", newarray) + "}");
            return;
        }

        for (int i = possition; i < array.Length; i++)
        {
            newarray[index] = array[i];
            possition++;
            Combinations(array, newarray, index + 1, possition);
        }
    }
    static void Main()
    {
        //input
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());//5;
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());//2;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }

        Combinations(array, new int[k], 0, 0);
    }
}
