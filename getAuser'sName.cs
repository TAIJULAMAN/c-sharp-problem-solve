// Use Console.ReadLine() to get a user's name and age.

using System;
class GetUserNameAndAge
{
    public static void GetNameAndAge()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }
}