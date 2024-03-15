using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de términos de la serie:");
        int n = Convert.ToInt32(Console.ReadLine());

        double resultado = CalcularSerie(n);
        Console.WriteLine($"El resultado de la serie es: {resultado}");
    }

    static double CalcularSerie(int n)
    {
        double suma = 0;
        for (int i = 0; i < n; i++)
        {
            suma += 1 / Math.Pow(2, i);
        }
        return suma;
    }
}

