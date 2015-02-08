using System;
/*
    Problem 6. Maximal K sum

    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
*/
class MaximalKSum
{
    static void Main()
    {
        //input
        Console.Write("Please enter n - the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter k (k<=n): ");
        int k = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = double.Parse(Console.ReadLine());
        }

        // create a new array, so I can change the numbers in it, without hurting the input
        double[] newArray = new double[n];
        for (int i = 0; i < n; i++)
        {
            newArray[i] = array[i];
        }
        int[] indexes = new int[k];
        for (int index = 0; index < k; index++)
        {
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (newArray[i] > max)
                {
                    max = newArray[i];
                    indexes[index] = i;
                }
            }
            newArray[indexes[index]] = double.MinValue;
        }

        //output
        Console.WriteLine();
        Console.WriteLine("The {0} elements with maximal sum are: ", k);
        double sum = 0;
        for (int i = 0; i < k; i++)
        {
            Console.Write(array[indexes[i]]);
            sum += array[indexes[i]];
            if (i == k - 1)
            {
                Console.Write(" = ");
            }
            else
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine(sum);
    }
}