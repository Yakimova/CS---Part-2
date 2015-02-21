using System;
/*
    Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
 */
class TriangleSurface
{
    static void Main()
    {
        //input
        Console.Write("Please enter side a of the triangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b of the triangle: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter side c of the triangle: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please enter the altitude to a: ");
        double altitude = double.Parse(Console.ReadLine());
        Console.Write("Please enter the angle between a and b in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        //calculating surface
        Console.WriteLine("The surface of the triangle calculated by side and altitude to it is: " + SurfaceBySidesAndAltitude(a, altitude));
        Console.WriteLine("The surface of the triangle calculated by three sides is: " + SurfaceByThreeSides(a, b, c));
        Console.WriteLine("The surface of the triangle calculated by two sides and the angle between them is: " + SurfaceByTwoSidesAndangle(a, b, angle));

    }
    static double SurfaceBySidesAndAltitude(double a, double altitude)
    {
        double surface = (a*altitude)/2;
        return surface;
    }
    static double SurfaceByThreeSides(double a, double b, double c)
    {
        double semiperimeter = (a + b + c) / 2;
        double surface = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        return surface;
    }
    static double SurfaceByTwoSidesAndangle(double a, double b, double angle)
    {
        angle = angle * Math.PI / 180.0;
        double surface = (Math.Sin((double)angle) * a * b) / 2.0;
        return surface;
    }

}
