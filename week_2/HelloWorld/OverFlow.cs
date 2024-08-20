using System;

class Program{
    static void Main(string[] args){
        int maxInt = int.MaxValue;
        Console.WriteLine("Maximum value of Integer is : " + maxInt);

        int overFlowInt = maxInt + 1;
        Console.WriteLine("Overflow value is : " + overFlowInt);

        int minInt = int.MinValue;
        Console.WriteLine("Minimum value of Integer is : " + minInt);
        
        int underFlowInt = minInt - 1;
        Console.WriteLine("UnderFlowInt value of Integer is :  " + underFlowInt);
    }

}