using System;
/*
    Problem 15.* Number calculations

    Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
    Use generic method (read in Internet about generic methods in C#).
 */
class NumberCalculations
{
    static void Main()
    {
        //input
        Console.Write("Please enter the array of integers, separated by \",\": ");
        string input = Console.ReadLine();
        string[] stringArray = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            array[i] = int.Parse(stringArray[i]);
        }
        Console.Write("Please enter \"min\", \"max\",\"sum\",\"avg\" or \"product\": ");
        string operation = Console.ReadLine();
        switch (operation)
        {
            case "min": Minumum(array); break;
            case "max": Console.WriteLine(Maximum(array)); break;
            case "sum": Console.WriteLine(Sum(array)); break;
            case "avg": Console.WriteLine(Average(array)); break;
            case "product": Console.WriteLine(Product(array)); break;
            default: Console.WriteLine("Invalid input!"); break;
        }
        /*
        //examples
        Console.WriteLine("Minumum: ");
        Console.WriteLine(Minumum(4, 8, 7, 7, 0));
        Console.WriteLine("Maximum: ");
        Console.WriteLine(Maximum(65, 90, -675, 34, 4312, 764543, 0, 75423));
        Console.WriteLine("Sum: ");
        Console.WriteLine(Sum(0, 0, 4, 7));
        Console.WriteLine("Average: ");
        Console.WriteLine(Average(4, 8, 4));
        Console.WriteLine("Product: ");
        Console.WriteLine(Product(4, 8, 7, 0, 6556));
         */
    }
    static void Minumum<T>(ref[] elements)
    {
        int min = int.MaxValue;
        foreach (int element in elements)
        {
            if (element < min)
            {
                min = element;
            }
        }
        Console.WriteLine(min);
    }
    static int Maximum(params int[] elements)
    {
        int max = int.MinValue;
        foreach (int element in elements)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }
    static int Sum(params int[] elements)
    {
        int sum = 0;
        foreach (int element in elements)
        {
            sum += element;
        }
        return sum;
    }
    static double Average(params int[] elements)
    {
        double avg = (double)Sum(elements);
        int counter = 0;
        foreach (int element in elements)
        {
            counter++;
        }
        avg /= counter;
        return avg;
    }
    static long Product(params int[] elements)
    {
        long pr = 1;
        foreach (int element in elements)
        {
            pr *= element;
        }
        return pr;
    }
}
