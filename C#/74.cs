using System;

public static class Test
{
    public static void Main()
    {
        Double a, b, c;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        a = a + b;
        c = c - a;
        if (c < 0.00000001)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
