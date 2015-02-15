using System;
/*
    Problem 1. Say Hello

    Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.
 */
class SayHello
{
    static void Main()
    {
        SayingHello();
    }

    private static void SayingHello()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}