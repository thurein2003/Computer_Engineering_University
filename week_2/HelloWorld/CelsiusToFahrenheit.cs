using System;
class Program
{
    static void Main(string[] args)
    {
        //variable declaration and initialization
        double fahrenheit = 0.0;
        double celsius = 0.0;
        Console.WriteLine("Please Input Your temp in celsius : ");
        celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Degree in Fahrenheit : " + celsius);

        //Compute degree conversion
        fahrenheit = ((celsius * 9) / 5) + 32;

        //output the calculation
        Console.WriteLine(celsius + " degree Fahrenheit is equal to " + fahrenheit + " in Celsius");

    }
}

