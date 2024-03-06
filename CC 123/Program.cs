using System;

class Program
{
    static void Main()
    {
        int m, n;
        Console.Write("Enter the value of m: ");
        m = Convert.ToInt32(Console.ReadLine());

        if (m > 0)
            n = 1;
        else if (m < 0)
            n = -1;
        else
            n = 0;

        Console.WriteLine("The value of n = " + n);
    }
}