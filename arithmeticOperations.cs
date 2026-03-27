// Perform all 5 arithmetic operations on two user-inputted numbers.

using System;
class ArithmeticOperations
{
    public static void Operation()
    {
        int number1 = 10;
        int number2 = 20;
        Console.WriteLine("number1 is :" + number1);
        Console.WriteLine("number2 is :" + number2);
        Console.WriteLine("number1 + number2 is :" + (number1 + number2));
        Console.WriteLine("number1 - number2 is :" + (number1 - number2));
        Console.WriteLine("number1 * number2 is :" + (number1 * number2));
        Console.WriteLine("number1 / number2 is :" + (number1 / number2));
        Console.WriteLine("number1 % number2 is :" + (number1 % number2));
    }
}