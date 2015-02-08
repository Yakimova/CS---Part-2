using System;
/*  
    Problem 19.* Permutations of set

    Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
 */
class PermutationsOfSet
{
    static void Main()
    {
        Console.Write("Please enter a number n: ");
        int n = int.Parse(Console.ReadLine());

        //n! = number of permutations 
        int permutations = 1;
        for (int i = 2; i <= n; i++)
        {
            permutations *= n;
        }

        //not solved
        int[] numbers = new int[n+1];
        for (int i = 1; i <= permutations; i++)
        {
            Console.Write("{");
            if (i <= n - 1)
            {
 
            }

            Console.WriteLine("}");
        }
    }
}
