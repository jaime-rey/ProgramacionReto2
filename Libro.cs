namespace ProgramacionReto2;

public class Libro
{
    public string Titulo { get; }
    public decimal Tarifa { get; }

    private readonly int pages;

    public int GetPages() => pages * 2;

    public Libro(string titulo, decimal tarifa, int pages)
    {
        if (tarifa <= 0 || pages <= 0)
            throw new ArgumentException("La tarifa y el número de páginas deben ser mayores que cero.");
        Titulo = titulo;
        Tarifa = tarifa;
        this.pages = pages;
    }

    public decimal Calcular(int dias)
    {
        return Tarifa * dias;
    }
}
