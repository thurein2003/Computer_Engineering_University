using System;
namespace ReverseEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is just the calculation app...");
            Console.WriteLine("Write '1' For the Circle....");
            Console.WriteLine("Write '2' For the Triangle...");

            Console.Write("Write Your Options : ");
            string inpu = Console.ReadLine();

            if (inpu == "1") {
                CalForCircle();
            } else if (inpu == "2")
            {
                CalForTriangle();
            } else {
                Console.WriteLine("Write only 1 and 2");
            }


            Console.WriteLine("Thanks for using the Echtit Calculator...");
        }
        
        static void CalForCircle()
        {
            Console.WriteLine("Welcome From the Calculating the circle area...");
            Console.Write("Write the radius of the Circle : ");

            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Your Radius is {radius} and your area result is {area}");
        }

        static void CalForTriangle()
        {
            Console.WriteLine("Welcome From the Calculating the Triangle area...");
            Console.Write("Write the width of the triangle : ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write the length of the heigh : ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area2 = width * height;

            Console.WriteLine("The area of the Triangle is {0}", area2);
        }

    }
}
