﻿using System;
/*
    Problem 13.* Merge sort

    Write a program that sorts an array of integers using the Merge sort algorithm.
*/
class MergeSort
{
    static public void MainMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, eol, num, pos;
        eol = (mid - 1);
        pos = left;
        num = (right - left + 1);
        while ((left <= eol) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
            {
                temp[pos++] = numbers[left++];
            }
            else
            {
                temp[pos++] = numbers[mid++];
            }
        }
        while (left <= eol)
        {
            temp[pos++] = numbers[left++];
        }
        while (mid <= right)
        {
            temp[pos++] = numbers[mid++];
        }
        for (i = 0; i < num; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void SortMerge(int[] numbers, int left, int right)
    {
        int mid;
        if (right > left)
        {
            mid = (right + left) / 2;
            SortMerge(numbers, left, mid);
            SortMerge(numbers, (mid + 1), right);
            MainMerge(numbers, left, (mid + 1), right);
        }
    }

    static void Main()
    {
        //input
        Console.Write("Please enter the lenght of the array of integers: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] unsorted = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Please enter ineteger {0}: ", i);
            unsorted[i] = int.Parse(Console.ReadLine());
        }

        //sorting
        SortMerge(unsorted, 0, lenght - 1);

        //output
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();
    }
}
