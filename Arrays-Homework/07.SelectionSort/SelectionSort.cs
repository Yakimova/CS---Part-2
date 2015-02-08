using System;
/*
    Problem 7. Selection sort

    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/
class SelectionSort
{
    static void Main()
    {
        //input
        Console.Write("Please enter the number of the element in the array: ");
        int elements = int.Parse(Console.ReadLine());
        double[] array = new double[elements];
        for (int i = 0; i < elements; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = double.Parse(Console.ReadLine());
        }

        //sorting
        for (int i = 0; i < elements - 1; i++)
        {
            double min = array[i];
            int smallestIndex =i;
            for (int j = i + 1; j < elements; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    smallestIndex = j;
                }
            }
            double temp = array[i];
            array[i] = array[smallestIndex];
            array[smallestIndex] = temp;
        }

        //output
        Console.WriteLine();
        for (int i = 0; i < elements; i++)
        {
            Console.Write("array[{0}] = ", i);
            Console.WriteLine(array[i]);
        }
    }
}
