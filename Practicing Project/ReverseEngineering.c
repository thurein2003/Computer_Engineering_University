//Thu rein oo
//7/11/2024

using System;
namespace ReverseEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptFlag = "This is Flag!";

            Console.WriteLine("Rever engineering to find the flag");

            string decryptFlag = DecryptFlag(encryptFlag);
            Console.WriteLine($"Decrypt flag : {decryptFlag}");
        }
        static string DecryptFlag(string encryptFlag)
        {
            byte[] bytes = Convert.FromBase64String(encryptFlag);
            byte[] key = new byte[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, };

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= key[i % key.Length];
            }
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

    }
}
