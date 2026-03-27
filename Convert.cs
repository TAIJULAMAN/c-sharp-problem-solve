//  Convert a string "123" to an int and add 10 to it.

using System;
class ConvertStringToInt
{
    public static void Convert()
    {
        string numberAsString = "123";
        int number = int.Parse(numberAsString);
        int result = number + 10;
        Console.WriteLine("The result is: " + result);
    }
}