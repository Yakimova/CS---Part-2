using System;
/*
    Problem 12. Subtracting polynomials

    Extend the previous program to support also subtraction and multiplication of polynomials.
 */
class SubstractingPolynomials
{
    static void Main()
    {
        double[] firstArray = TakingCoefficients();
        double[] secondArray = TakingCoefficients(); ;

        double[] resultAddingArray = AddingArrays(firstArray, secondArray);
        Console.WriteLine("The added polynomials look like this: ");
        PrintingResult(resultAddingArray);

        double[] resultSubstractingArray = SubstractingArrays(firstArray, secondArray);
        Console.WriteLine("The substracted polynomials look like this: ");
        PrintingResult(resultSubstractingArray);

        double[] resultMultiplyingArray = MultiplyingArrays(firstArray, secondArray);
        Console.WriteLine("The multiplied polynomials look like this: ");
        PrintingResult(resultMultiplyingArray);

    }
    private static double[] TakingCoefficients()
    {
        Console.Write("Please enter the highest degree of x: ");
        int highestDegree = int.Parse(Console.ReadLine());
        double[] coefficients = new double[highestDegree + 1];
        for (int i = 0; i <= highestDegree; i++)
        {
            Console.Write("? * x^{0} ", highestDegree - i);
            coefficients[highestDegree - i] = double.Parse(Console.ReadLine());
        }
        return coefficients;
    }
    private static double[] AddingArrays(double[] firstArray, double[] secondArray)
    {
        double[] result = new double[Math.Max(firstArray.Length, secondArray.Length)];
        double[] newFirst = new double[result.Length];
        for (int i = 0; i < firstArray.Length; i++)
        {
            newFirst[i] = firstArray[i];
        }
        double[] newSecond = new double[result.Length];
        for (int i = 0; i < secondArray.Length; i++)
        {
            newSecond[i] = secondArray[i];
        }

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = newSecond[i] + newFirst[i];
        }
        return result;
    }
    private static double[] SubstractingArrays(double[] firstArray, double[] secondArray)
    {
        double[] result = new double[Math.Max(firstArray.Length, secondArray.Length)];
        double[] newFirst = new double[result.Length];
        for (int i = 0; i < firstArray.Length; i++)
        {
            newFirst[i] = firstArray[i];
        }
        double[] newSecond = new double[result.Length];
        for (int i = 0; i < secondArray.Length; i++)
        {
            newSecond[i] = secondArray[i];
        }
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = newFirst[i] - newSecond[i];
        }
        return result;
    }
    private static double[] MultiplyingArrays(double[] firstArray, double[] secondArray)
    {
        double[] result = new double[firstArray.Length + secondArray.Length - 1];
        double[,] allCoefficientsMultiplication = new double[firstArray.Length, secondArray.Length];
        for (int i = 0; i < firstArray.Length; i++)
        {
            for (int j = 0; j < secondArray.Length; j++)
            {
                allCoefficientsMultiplication[i, j] = firstArray[i] * secondArray[j];
                result[i + j] += allCoefficientsMultiplication[i, j];
            }
        }
        return result;
 
    }
    private static void PrintingResult(double[] result)
    {
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                if (result[i] >= 0 && result.Length>1)
                {
                    Console.WriteLine(" + " + result[i]);
                }
                else
                {
                    Console.WriteLine(result[i]);
                }
            }
            else if (i == result.Length - 1)
            {
                Console.Write("{0} * x^{1} ", result[i], i);
            }
            else if (result[i] < 0)
            {
                Console.Write("{0} * x^{1} ", result[i], i);
            }
            else if (result[i] != 0)
            {
                Console.Write("+ {0} * x^{1} ", result[i], i);
            }

        }
    }
}