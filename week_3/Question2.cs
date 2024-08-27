using System;

class MathOperations
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int addition = num1 + num2;
        int subtraction = num1 - num2;
        int multiplication = num1 * num2;
        int modulus = num1 % num2;
        double division = (double)num1 / num2; 

        Console.WriteLine("The result of adding is " + addition);
        Console.WriteLine("The result of subtracting is " + subtraction);
        Console.WriteLine("The result of multiplying is " + multiplication);
        Console.WriteLine("The result of modulus is " + modulus);
        Console.WriteLine("The result of dividing is " + division);
    }
}
