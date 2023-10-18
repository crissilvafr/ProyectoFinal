// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Personaje prototipo = new Personaje("Héroe", "Mago");

// Clonar el personaje prototipo
Personaje clon = (Personaje)prototipo.Clonar();

clon.Nombre = "Enemigo";
clon.Tipo = "Mago oscuro";

Console.WriteLine("Personaje Original:");
prototipo.Imprimir();

Console.WriteLine("\nPersonaje Clonado:");
clon.Imprimir();