using System;
/*
    Problem 19.* Permutations of set

    Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
 */
class PermutationsOfSet
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine()); //3;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }

        Permutation(array, 0, n-1);
    }

    private static void Permutation(int[] array, int index, int length)
    {
        if (index==length)
        {
            Console.WriteLine("{" + string.Join(", ", array)+ "}");
            return;
        }

        for (int i = index; i < array.Length; i++)
        {

            int temp = array[i];
            array[i] = array[index];
            array[index] = temp;
            Permutation(array, index + 1, length);
            temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
    }
}
