// Swap two numbers without using a third variable
using System;
class SwapNumbers2
{
    public static void Swap2()
    {
        int a = 10;
        int b = 20;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}