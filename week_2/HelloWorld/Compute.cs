using System;
class Program {
    static void Main(string[] args){
        int num1,num2;
        int sum,different,product;

        Console.WriteLine("Please Input your first Number : ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Input Your second Number : ");
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;
        different = num1 - num2;
        product = num1 * num2;

        Console.WriteLine("The Sum of " + num1 + "and " + num2 +"is : " + sum);
        Console.WriteLine("The different of " + num1 + "and" + num2 + "is :" + different);
        Console.WriteLine("The Product of "+ num1 + "and" + num2 + "is :" + product);
    }
}