using System;

public class Test
{

    public static void Main()
    {
        double a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Math.Sqrt(a*a + b*b);
        Console.WriteLine(c);
    }
}