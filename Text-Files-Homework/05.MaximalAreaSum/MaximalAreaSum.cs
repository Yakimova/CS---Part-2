using System;
using System.IO;
/*
    Problem 5. Maximal area sum

    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.
 */
class MaximalAreaSum
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\inputfile.txt");
        using (reader)
        {
            int numberOfLines = int.Parse(reader.ReadLine());
            int[,] matrix = new int[numberOfLines, numberOfLines];
            for (int i = 0; i < numberOfLines; i++)
            {
                string line = reader.ReadLine();
                string[] stringnumbers = line.Split(' ');
                for (int j = 0; j < numberOfLines; j++)
                {
                    matrix[i, j] = int.Parse(stringnumbers[j]);
                }
            }

            int maxsum = int.MinValue;
            for (int row = 0; row < numberOfLines-1; row++)
            {
                for (int col = 0; col < numberOfLines-1; col++)
                {
                    int currentsum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentsum > maxsum)
                    {
                        maxsum = currentsum;
                    }
                }
            }

            var writer = new StreamWriter(@"..\..\resultfile.txt");
            using (writer)
            {
                writer.WriteLine(maxsum);
            }
            Console.WriteLine("The result is {0} and you can see it in the file: resultfile.txt", maxsum);
        }
    }
}
