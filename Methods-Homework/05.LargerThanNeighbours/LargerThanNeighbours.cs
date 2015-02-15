using System;
/*
    Problem 5. Larger than neighbours

    Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */
class LargerThanNeighbours
{
    static void Main()
    {
        //input
        Console.Write("Please enter the array of numbers, separated by \",\": ");
        string input = Console.ReadLine();
        string[] stringArray = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double[] array = new double[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            array[i] = double.Parse(stringArray[i]);
        }
        Console.Write("Please enter the wanted possition: ");
        int possition = int.Parse(Console.ReadLine());

        Console.WriteLine("Is the element bigger than it's neighbours?  " + ElementLargerThanNeighbours(array, possition));
    }

    private static bool ElementLargerThanNeighbours(double[] array, int possition)
    {
        bool isbigger = false;
        if (possition < array.Length - 1 && possition > 0 && array[possition - 1] < array[possition] && array[possition] > array[possition + 1])
        {
            isbigger = true;
        }
        return isbigger;
    }
}