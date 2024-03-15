using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());

        long resultado = CalcularProgresion(x, n);

        Console.WriteLine($"El resultado de la progresión es: {resultado}");
    }

    static long CalcularProgresion(int x, int n)
    {
        long suma = 0;
        long potencia = 1;

        for (int i = 0; i <= n; i++)
        {
            suma += potencia;
            potencia *= x;
        }

        return suma;
    }
}

