using System;
/*
    Problem 15. Prime numbers

    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/
class PrimeNumbers
{
    static void Main()
    {
        int start = 2;
        int end = 10000000;
        bool[]arePrime = new bool[end+1];
        for (int i=0; i<end+1; i++)
        {
            arePrime[i] = true;
        }
        arePrime[0] = false;
        arePrime[1] = false;
        int prime = 2;
        while (prime <= end)
        {
            Console.Write(prime+ ", ");
            for (int i = prime + 1; i < end + 1; i++)
            {
                if (i%prime==0)
                {
                    arePrime[i] = false;
                }
            }

            //finding the nex prime
            bool noNextPrime = true;
            for (int j = prime + 1; j < end + 1; j++)
            {
                if (arePrime[j] == true)
                {
                    prime = j;
                    noNextPrime = false;
                    break;
                }
            }
            if (noNextPrime == true)
                break;
        }
    }
}