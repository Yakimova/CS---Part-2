using System;
/*
    Problem 4. Appearance count

    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.
 */
class AppearanceCount
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
        Console.Write("Please enter the wanted number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} appears {1} times", number, CounterOfNumberAppearance(array, number));
    }

    private static int CounterOfNumberAppearance(double[] array, double number)
    {
        int count = 0;
        foreach (double element in array)
        {
            if (element == number)
            {
                count++;
            }
        }
        return count;
    }
}
