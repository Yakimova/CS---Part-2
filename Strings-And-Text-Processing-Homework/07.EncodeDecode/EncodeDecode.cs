using System;
using System.Text;
/*
    Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
 */
class EncodeDecode
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string message = Console.ReadLine();
        Console.Write("Please enter a key: ");
        string key = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < message.Length; i++)
        {
            int temp = message[i]^key[i%key.Length];
            result.Append((char)temp);
        }
        Console.WriteLine("The result is: " + result);
    }
}
