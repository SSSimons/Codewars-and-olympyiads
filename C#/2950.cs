using System;

public class Test
{

    public static void Main()
    {
        int a, b, c, e;
        a = Convert.ToInt32(Console.ReadLine());
        b = a * 45 + (a / 2 - (a + 1) % 2) * 15 + (a / 2) * 5;
        c = b / 60 + 9;
        e = b % 60;
        Console.WriteLine(c);
        Console.WriteLine(e);
    }
}