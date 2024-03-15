using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el año de nacimiento: ");
        int añoNacimiento = int.Parse(Console.ReadLine());

        int edad = CalcularEdad(añoNacimiento);

        Console.WriteLine($"La edad es: {edad}");
    }

    static int CalcularEdad(int añoNacimiento)
    {
        int añoActual = DateTime.Now.Year;
        int edad = añoActual - añoNacimiento;
        return edad;
    }
}

