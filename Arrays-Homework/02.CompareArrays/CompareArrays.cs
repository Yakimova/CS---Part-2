using System;
/*
    Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.
*/
class CompareArrays
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter the first array of integers, separated by \",\": ");
        string firstInput = Console.ReadLine();
        string[] firstNumbers = firstInput.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        int firstLenght = firstNumbers.Length;
        int[] firstArray = new int[firstLenght];
        for (int i = 0; i < firstLenght; i++)
        {
            firstArray[i] = int.Parse(firstNumbers[i]);
        }
        Console.WriteLine("Please enter the second array of integers, separated by \",\": ");
        string secondInput = Console.ReadLine();
        string[] secondNumbers = secondInput.Split(',');
        int secondLenght = secondNumbers.Length;
        int[] secondArray = new int[secondLenght];
        for (int i = 0; i < secondLenght; i++)
        {
            secondArray[i] = int.Parse(secondNumbers[i]);
        }
        
        //if they don't have the same number of elements, they cannot be compared element by element
        if (firstLenght != secondLenght)
        {
            Console.WriteLine("The two arrays have different number of elements!");
        }
        else
        {
            bool areEqual = true;
            for (int index = 0; index < firstLenght; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual == true)
            {
                Console.WriteLine("The two arrays are equal!");
            }
            else
            {
                Console.WriteLine("The two arrays are NOT equal!");
            }
        }
    }
}
