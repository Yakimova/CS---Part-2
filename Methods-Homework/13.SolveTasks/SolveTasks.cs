using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
    Problem 13. Solve tasks

    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
 */
class SolveTasks
{
    static void Main()
    {
        byte command = Menu();
        Console.ForegroundColor = ConsoleColor.White;
        if (command == 0)
        {
           ReversingNumber();
        }
        else if (command == 1)
        {
            CalculateAverage();
        }
        else
        {
            SolveLinearEquation();
        }
    }
    private static void WriteOptions(byte command)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Please enter the task you want to solve!\n Use up and down arrow keys and enter.\n");
        string[] options = {"Reverse the digits of a number",
        "Calculate the average of a sequence of integers",
        "Solve a linear equation"};
        for (byte i = 0; i < 3; i++)
        {
            if (i == command)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[i]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(options[i]);
            }
        }
    }
    private static byte Menu()
    {
        byte command = 1;
        WriteOptions(command);


        ConsoleKeyInfo keyInfo = Console.ReadKey();
        while (keyInfo.Key!= ConsoleKey.Enter)
        {
            if (keyInfo.Key == ConsoleKey.UpArrow && command > 0)
            {
                command--;
                Console.Clear();
                WriteOptions(command);
            }
            if (keyInfo.Key == ConsoleKey.DownArrow && command <2 )
            {
                command++;
                Console.Clear();
                WriteOptions(command);
            }
            keyInfo = Console.ReadKey();
        }
        Console.Clear();
        return command;
    }
    private static void ReversingNumber()
    {
        Console.Write("Please enter an integer number >=0: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 0)
        {
            Console.WriteLine("The number should be >= 0");
            Console.Write("Please enter an integer number >=: ");
            number = int.Parse(Console.ReadLine());
        }

        List<int> digit = new List<int>();
        while (number > 0)
        {
            digit.Add(number % 10);
            number /= 10;
        }
        int result = 0;
        for (int i = 0; i < digit.Count; i++)
        {
            result += (digit[i] * (int)(Math.Pow(10, (digit.Count - i - 1))));
        }
        Console.WriteLine("The reversed number is: " + result);
    }
    private static void CalculateAverage()
    {
        Console.Write("Please enter the sequence of integers, separated by \",\": ");
        string input = Console.ReadLine();
        while (input == "")
        {
            Console.WriteLine("The sequence should not be empty");
            Console.Write("Please enter the sequence of integers, separated by \",\": ");
            input = Console.ReadLine();
        }
        string[] stringNumbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[stringNumbers.Length];
        int sum = 0;
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = int.Parse(stringNumbers[i]);
            sum += numbers[i];   
        }
        double avg = (double)sum / stringNumbers.Length;
        Console.WriteLine("The average is: " + avg);

    }
    private static void SolveLinearEquation()
    {
        Console.Write("Please enter a: ");
        double a = double.Parse(Console.ReadLine());
        while (a == 0.0)
        {
            Console.WriteLine("a should not be 0!");
            Console.WriteLine("Please enter a: ");
            a = double.Parse(Console.ReadLine());
        }
        Console.Write("Please enter b: ");
        double b = double.Parse(Console.ReadLine());
        double x = (double)(-b) / a;
        Console.WriteLine("{0} * x + {1} = 0", a, b);
        Console.WriteLine("x = {0}", x);
    }
}
