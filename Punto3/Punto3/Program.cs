using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la magnitud (r): ");
        double magnitud = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el ángulo en grados (θ): ");
        double anguloGrados = double.Parse(Console.ReadLine());

        double anguloRadianes = anguloGrados * Math.PI / 180;

        double x = magnitud * Math.Cos(anguloRadianes);
        double y = magnitud * Math.Sin(anguloRadianes);

        Console.WriteLine($"Las coordenadas rectangulares son: ({x}, {y})");
    }
}

