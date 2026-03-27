// Swap two numbers using a third variable
using System;
class SwapNumbers
{
    public static void Swap()
    {
        int a = 10;
        int b = 20;
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}