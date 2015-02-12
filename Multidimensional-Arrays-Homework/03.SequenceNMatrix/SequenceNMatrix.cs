using System;
/*
    Problem 3. Sequence n matrix

    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.
 */
class SequenceNMatrix
{
    static void Main()
    {
        //input
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine()); //3
        Console.Write("Please enter m: ");
        int m = int.Parse(Console.ReadLine()); //4
        string[,] matrix = new string[n, m]; // { {"ha", "fifi", "ho", "hi" }, {"fo", "ha", "hi", "xx" }, {"xxx", "ho", "ha", "xx" } };
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0}, {1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        //printing the matrix
        Console.WriteLine("The matrix is: ");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0, 6}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        int biggestsequence = 0;
        string biggeststring = "";

        //on the same line
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                int currentsequence = 1;
                int possition =col+1;
                while (possition < m && matrix[row, possition] == matrix[row, col])
                {
                    currentsequence++;
                    possition++;
                }
                if (currentsequence > biggestsequence)
                {
                    biggestsequence = currentsequence;
                    biggeststring = matrix[row, col];
                }
            }
        }
        //on the same column
        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n; row++)
            {
                int currentsequence = 1;
                int possition = row + 1;
                while (possition < n && matrix[possition, col] == matrix[row, col])
                {
                    currentsequence++;
                    possition++;
                }
                if (currentsequence > biggestsequence)
                {
                    biggestsequence = currentsequence;
                    biggeststring = matrix[row, col];
                }
            }
        }

        //on the same diagonal
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                int currentsequence = 1;
                int possitioncol = col + 1;
                int possitionrow = row + 1;
                while (possitioncol < m && possitionrow<n && matrix[possitionrow, possitioncol] == matrix[row, col])
                {
                    currentsequence++;
                    possitioncol++;
                    possitionrow++;
                }
                if (currentsequence > biggestsequence)
                {
                    biggestsequence = currentsequence;
                    biggeststring = matrix[row, col];
                }
            }
        }

        //output
        Console.WriteLine("Result:");
        for (int i = 0; i < biggestsequence; i++)
        {
            if (i == biggestsequence - 1)
            {
                Console.WriteLine(biggeststring);
            }
            else
            {
                Console.Write(biggeststring + ", ");
            }
        }

    }
}
