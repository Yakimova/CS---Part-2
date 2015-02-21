using System;
/*
    Problem 2. Random numbers

    Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */
class RandomNumbers
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Ten random numbers in the range [100, 200] are: ");
        for (int i = 1; i <= 10; i++)
        {
            // if we want 200 to be one of the numbers, we choose from, we make the interval up to 201 
            Console.WriteLine("Random number[{0}] = {1}", i, random.Next(100, 201));
        }
    }
}
