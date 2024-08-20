using System;
class Program
{
    static void Main(string[] args)
    {
        //variable declaration and initialization
        double fahrenheit = 350.0;
        double celsius = 0.0;
        Console.WriteLine("Please Input Your temp in fahrenheit : ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Degree in Fahrenheit : " + fahrenheit);

        //Compute degree conversion
        celsius = (((fahrenheit - 32) * 5) / 9);

        //output the calculation
        Console.WriteLine(fahrenheit + " degree Fahrenheit is equal to " + celsius + " in Celsius");

    }
}

