using System;
/*
    Problem 10. Find sum in array

    Write a program that finds in given array of integers a sequence of given sum S (if present).
*/
class FindSumInArray
{
    static void Main()
    {
        //input
        Console.WriteLine("Please enter a sequence of numbers separater by \",\" :");
        string input = Console.ReadLine();
        string[] stringNumbers = input.Split(',');
        double[] numbers = new double[stringNumbers.Length];
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(stringNumbers[i]);
        }
        Console.Write("Please enter the sum: ");
        double sum = double.Parse(Console.ReadLine());


        int startindex = -1;
        int endIndex = numbers.Length;
        bool exist = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            double currentSum = 0.0;
            for (int j = i; j < numbers.Length; j++)
            {
                currentSum += numbers[j];
                if (currentSum ==sum)
                {
                    startindex = i;
                    endIndex = j;
                    exist = true;
                    break;
                }
            }

            if (exist == true)
            {
                break;
            }
        }

        //output
        if (exist == false)
        {
            Console.WriteLine("There is no such sum.");
        }
        else
        {
            for (int i = startindex; i <= endIndex; i++)
            {
                Console.Write(numbers[i] + " + ");
            }
            Console.Write("\b\b");
            Console.WriteLine("= {0}", sum);
        }
    }
}
