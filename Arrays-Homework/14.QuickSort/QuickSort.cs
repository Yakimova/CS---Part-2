using System;
/*
    Problem 14. Quick sort

    Write a program that sorts an array of strings using the Quick sort algorithm.
*/
class QuickSort
{
    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                IComparable tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
    static void Main()
    {
        //input
        Console.WriteLine("Please enter the lenght of the array of strings: ");
        int lenght = int.Parse(Console.ReadLine());
        string[] unsorted = new string[lenght];
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Please enter string {0}: ", i);
            unsorted[i] = Console.ReadLine();
        }

        //sorting
        Quicksort(unsorted, 0, unsorted.Length - 1);

        //output
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();
 
    }
}
