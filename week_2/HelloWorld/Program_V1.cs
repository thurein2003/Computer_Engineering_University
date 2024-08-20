using System;
namespace ConsoleApp1
{    
    class Program{        
        static void Main(string[] args)
        {
			Console.WriteLine("Go to new line \nthis is new line");
			Console.WriteLine("Tab \t");
			Console.WriteLine("Back slash \\");
			Console.WriteLine("Single quote \'" );
			Console.WriteLine("Double quote \"");

			// sample of how to use these character literal
			Console.WriteLine("\nHello!\nA program\t\"CharacterLiteral\"");

			// write a string with Unicode code
			Console.WriteLine("\n\\u0048\\u0065\\u006c\\u006c\\u006f = ");
			Console.WriteLine("\u0048\u0065\u006c\u006c\u006f");
	  }
    }
}
