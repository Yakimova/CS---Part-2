using System;
/*
    Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */
class MaximalSum
{
    static void Main()
    {
        //input
        Console.Write("Please enter n(n>=3): ");
        int n = int.Parse(Console.ReadLine());
        while (n < 3)
        {
            Console.Write("Please enter n(n>=3): ");
            n = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter m(m>=3): ");
        int m = int.Parse(Console.ReadLine());
        while (m < 3)
        {
            Console.Write("Please enter m(m>=3): ");
            m = int.Parse(Console.ReadLine());
        }
        int[,] matrix = new int[n,m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //printing the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //finding the best sum
        int bestsum = int.MinValue;
        int startrow =-1;
        int startcol =-1;
        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                int currentsum = (matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row+1, col] + matrix[row+1, col + 1] + matrix[row+1, col + 2] + matrix[row+2, col] + matrix[row+2, col + 1] + matrix[row+2, col + 2]);
                if (currentsum > bestsum)
                {
                    bestsum = currentsum;
                    startrow = row;
                    startcol = col;
                }
            }
        }

        //output
        Console.WriteLine("The best sum is " + bestsum);
        Console.WriteLine("The square 3x3 is: ");
        for (int row = startrow; row < startrow + 3; row++)
        { 
            for (int col = startcol; col<startcol+3; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
