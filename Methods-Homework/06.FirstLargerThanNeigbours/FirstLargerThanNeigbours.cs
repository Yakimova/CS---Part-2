using System;
/*
    Problem 6. First larger than neighbours

    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
    Use the method from the previous exercise.
 */
class FirstLargerThanNeigbours
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

        Console.WriteLine(FirstLargerElement(array));

    }

    private static int FirstLargerElement(double[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (ElementLargerThanNeighbours(array, i) == true)
            {
                index = i;
                break;
            }
        }
        return index;
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
