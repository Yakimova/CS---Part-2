using System;
/*
Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4:
a) 	
1 	5 	9 	13
2 	6 	10 	14
3 	7 	11 	15
4 	8 	12 	16
b) 
1 	8 	9 	16
2 	7 	10 	15
3 	6 	11 	14
4 	5 	12 	13
c)
7 	11 	14 	16
4 	8 	12 	15
2 	5 	9 	13
1 	3 	6 	10
d)*	
1 	12 	11 	10
2 	13 	16 	9
3 	14 	15 	8
4 	5 	6 	7
 */
class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        //a)
        Console.WriteLine("a)");
        int value =1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = value;
                value++;
            }

        }
        //print matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //b)
        Console.WriteLine("b)");
        value = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }
        }
        //print matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //c)
        Console.WriteLine("c)");
        value = 1;
        int startcol = 0;
        int startrow = (n-1);
        int diagonal = 1;
        while (diagonal <= n)
        {
            for (int i = 1; i <= diagonal; i++)
            {
                matrix[startrow, startcol] = value;
                value++;
                startcol++;
                startrow++;
            }
            startrow = n - 1 - diagonal;
            startcol = 0;
            diagonal++;
        }
        diagonal = n - 1;
        startcol = 1;
        startrow = 0;
        while (diagonal >= 1)
        {
            for (int i = 1; i <= diagonal; i++)
            {
                matrix[startrow, startcol] = value;
                value++;
                startcol++;
                startrow++;
            }
            startrow = 0;
            startcol = (n-diagonal+1);
            diagonal--;
        }
        //print matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //d)
        Console.WriteLine("d)");
        value = 1;
        //clear the matrix
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = 0;
        //filling the matrix
        for (int i = 0; i < (n / 2); i++)
        {
            for (int row = i; row < n-i; row++)
            {
                if (matrix[row, i] == 0)
                {
                    matrix[row, i] = value;
                    value++;
                }
            }
            for (int col = 1+i; col < n-i; col++)
            {
                if (matrix[n - 1-i, col] == 0)
                {
                    matrix[n - 1-i, col] = value;
                    value++;
                }
            }
            for (int row = n - 2-i; row >= 0+i; row--)
            {
                if (matrix[row, n - 1-i] == 0)
                {
                    matrix[row, n - 1-i] = value;
                    value++;
                }
            }
            for (int col = n - 2-i; col >= 1+i; col--)
            {
                if (matrix[i, col] == 0)
                {
                    matrix[i, col] = value;
                    value++;
                }
            }
        }
        //print matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
