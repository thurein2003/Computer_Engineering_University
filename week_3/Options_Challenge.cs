using System;

class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Please input the NUKE LAUNCH CODE: ");
        ulong code = ulong.Parse(Console.ReadLine());

        Console.Write("Please input the KEY (number): ");
        ulong key = ulong.Parse(Console.ReadLine());

        ulong ciphertext = code ^ key;

        
        Console.WriteLine("Ciphertext: " + ciphertext);
        Console.WriteLine("Original Code: " + (ciphertext ^ key));
    }
}


