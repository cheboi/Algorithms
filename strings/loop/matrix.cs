using System;

public class Program
{
    static void printX(int n)
    {
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == i)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write("0");
                }

            }
            Console.WriteLine("");
        }
    }
    public static void Main()
    {
        Console.WriteLine("Hello World");
        printX(3);
    }
}