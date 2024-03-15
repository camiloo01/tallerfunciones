using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el límite de la serie Fibonacci: ");
        int limite = int.Parse(Console.ReadLine());

        Console.WriteLine("Serie Fibonacci:");
        for (int i = 0; i < limite; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
        Console.WriteLine();
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

