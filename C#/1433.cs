using System;

public class Test
{
    public static void Main()
    {
	        int n, m, c, i;
			n = Convert.ToInt32(Console.Read());
			m = Convert.ToInt32(Console.Read());
			c = 0;
			i = m % n;
			if (m % n == 0)
			{
			   c = m / n;
			}
			else if (m % n >= 1)
			{
			  c = (m / n) + 1;
			}
			Console.Write(c);
}
}