namespace ProgramacionReto2;

using System;

static class Program
{
    static void Main()
    {
        const int dias = 5;
        const decimal tarifa = 100m;
        if (!DiasValidos(dias))
        {
            Console.WriteLine("Días no válidos");
        }
        else
        {
            decimal importe = CalcularImporte(dias, tarifa);
            MostrarImporte(importe);
            Libro libro = CrearLibro();
            Console.WriteLine($"Libro: {libro.Titulo} con pages {libro.GetPages()}");
            MostrarImporte(libro.Calcular(dias));
        }

    }

    static decimal CalcularImporte(int dias, decimal tarifa)
    {
        return dias * tarifa;
    }

    static bool DiasValidos(int dias)
    {
        return dias > 0;
    }

    static void MostrarImporte(decimal importe)
    {
        Console.WriteLine($"El importe es: {importe:C}");
    }

    static Libro CrearLibro() => new("El Quijote", 7500m, 500);
}
