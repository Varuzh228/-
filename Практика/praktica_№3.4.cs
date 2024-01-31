using System;

class Program
{
    static void Main()
    {
        Console.Write("10");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("10");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}