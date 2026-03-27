// Calculate the area of a circle ($A = \pi r^2$).

using System;
class AreaOfCircle
{
    public static void Area()
    {
        double radius = 2;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The value of area is :" + area);
    }
}