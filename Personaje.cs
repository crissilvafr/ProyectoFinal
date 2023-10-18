public class Personaje : IPrototipo
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }

    public Personaje(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre} \t Tipo: {Tipo}");
    }

    public IPrototipo Clonar()
    {
        return new Personaje(Nombre, Tipo);
    }
}