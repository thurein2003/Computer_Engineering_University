using System;

class PrePostFix
{
    public static void Main(string[] arg)
    {
        int i = 3, j = 7;

        Console.WriteLine(++i + " " + j--); 
        Console.WriteLine(++i + " " + j--); 
        Console.WriteLine(i-- + " " + --j); 
        Console.WriteLine(++i + " " + --j); 
    }
}



