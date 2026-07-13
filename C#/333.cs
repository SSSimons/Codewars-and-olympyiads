using System;

public class Test
{
    public static void Main()
    {
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
