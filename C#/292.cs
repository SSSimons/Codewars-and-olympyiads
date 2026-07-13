using System;

public class Test
{
    public static void Main()
    {
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else if (a < b)
        {
            Console.WriteLine(b);
        }
        else if (a == b)
        {
            Console.WriteLine(a);
        }
    }
}