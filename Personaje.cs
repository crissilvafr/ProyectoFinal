public class Personaje : IPersonajePrototipo
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }

    public Personaje(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre} \t Tipo: {Tipo}");
    }

    public IPersonajePrototipo Clonar()
    {
        return new Personaje(Nombre, Tipo);
    }
}