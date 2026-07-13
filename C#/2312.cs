using System;

public class Test
{
    public static void Main()
    {
        int k, sec, thir, last, number, o;
        k = Convert.ToInt32(Console.ReadLine());
        o = k;
        number = 0;
        sec = 0;
        thir = 0;
        last = 0;
          if (k >= 1000 && k <= 9999)
        {
            thir = k;
            sec = k;
            last = k % 10;
            sec = sec / 100;
            sec = sec % 10;
            thir = thir / 10;
            thir = thir % 10;
            k = k / 1000;
            number = k + sec + thir + last;
        }
          else if (k >= 100 && k <= 999)
        {
            thir = k;
            sec = k;
            thir = k % 10;
            sec = sec / 10;
            sec = sec % 10;
            k = k / 100;
            number = k + sec + thir;
        }
          else if (k >= 10 && k <= 99)
        {
            sec = k;
            sec = sec % 10;
            k = k / 10;
            number = k + sec;
        }
          else if (k >= 0 && k <= 9)
        {
            number = k;
        }
        Console.WriteLine(number);
    }
}