using System;
/*
    Problem 11. Adding polynomials

    Write a method that adds two polynomials.
    Represent them as arrays of their coefficients.
 */
class AddingPolynomials
{
    static void Main()
    {
        double[] firstArray = TakingCoefficients();
        double[] secondArray = TakingCoefficients();;
        double[] resultArray = AddingArrays(firstArray, secondArray);
        PrintingResult(resultArray);
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
        for (int i=0; i<firstArray.Length; i++)
        {
            newFirst[i] = firstArray[i];
        }
        double[] newSecond = new double[result.Length];
        for (int i=0; i<secondArray.Length; i++)
        {
            newSecond[i] = secondArray[i];
        }
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = newSecond[i] + newFirst[i];
        }
        return result;
    }
    private static void PrintingResult(double[] result)
    {
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(result[i]);
            }
            else if (result[i]!= 0)
            {
                Console.Write("{0} * x^{1} + ", result[i], i);
            }

        }
    }
}
