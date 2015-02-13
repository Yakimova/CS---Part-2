using System;
/*
    Problem 14. Quick sort

    Write a program that sorts an array of integers using the Quick sort algorithm.
*/
class QuickSort
{
    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = elements[(left + right) / 2];

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
                int temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }

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
        Console.WriteLine("Please enter the array of integers, separated by \",\": ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] unsorted = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            unsorted[i] = int.Parse(numbers[i]);
        }

        //sorting
        Quicksort(unsorted, 0, unsorted.Length - 1);

        //output
        Console.WriteLine("The sorted array looks like this: " + String.Join(", ", unsorted));
 
    }
}
