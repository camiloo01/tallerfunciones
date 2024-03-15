using System;

class Program
{
    static void Main()
    {
        char opcion;

        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("a) Dividir.");
            Console.WriteLine("b) Obtener cubo.");
            Console.WriteLine("c) Cálculo de IMC (Índice de Masa Corporal).");
            Console.WriteLine("d) Salir.");
            Console.Write("Seleccione una opción: ");
            opcion = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (opcion)
            {
                case 'a':
                    Dividir();
                    break;
                case 'b':
                    ObtenerCubo();
                    break;
                case 'c':
                    CalcularIMC();
                    break;
                case 'd':
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 'd');
    }

    static void Dividir()
    {
        Console.Write("Ingrese el dividendo: ");
        double dividendo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el divisor: ");
        double divisor = double.Parse(Console.ReadLine());

        double resultado = dividendo / divisor;

        Console.WriteLine($"El resultado de la división es: {resultado}");
    }

    static void ObtenerCubo()
    {
        Console.Write("Ingrese un número: ");
        double numero = double.Parse(Console.ReadLine());

        double cubo = Math.Pow(numero, 3);

        Console.WriteLine($"El cubo del número es: {cubo}");
    }

    static void CalcularIMC()
    {
        Console.Write("Ingrese su peso en kg: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Ingrese su altura en metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / Math.Pow(altura, 2);

        Console.WriteLine($"Su índice de masa corporal (IMC) es: {imc}");
    }
}
