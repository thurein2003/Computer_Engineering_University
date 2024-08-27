
using System;

class BooleanExpressions
{
    public static void Main(string[] args)
    {
        // Input floating point values
        Console.Write("Enter X number: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter Y number: ");
        double y = double.Parse(Console.ReadLine());

        // Output results of various boolean expressions
        Console.WriteLine("X < Y is " + (x < y));
        Console.WriteLine("X <= Y is " + (x <= y));
        Console.WriteLine("X == Y is " + (x == y));
        Console.WriteLine("X != Y is " + (x != y));
        Console.WriteLine("X > Y is " + (x > y));
        Console.WriteLine("X >= Y is " + (x >= y));

        // Combined expressions
        Console.WriteLine("X < Y && X >= Y is " + ((x < y) && (x >= y)));
        Console.WriteLine("X <= Y || X != Y is " + ((x <= y) || (x != y)));
    }
}
