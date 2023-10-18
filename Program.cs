// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Personaje jugador = new Personaje("Héroe", "Mago");

Personaje enemigo = (Personaje)jugador.Clonar();

enemigo.Nombre = "Enemigo";
enemigo.Tipo = "Mago oscuro";

Personaje aliado = (Personaje)jugador.Clonar();

aliado.Nombre = "Aliado";
aliado.Tipo = "Hechicero";

Console.WriteLine("Personaje Original:");
jugador.Imprimir();

Console.WriteLine("\nPersonaje Clonado en enemigo:");
enemigo.Imprimir();

Console.WriteLine("\nPersonaje Clonado en aliado:");
enemigo.Imprimir();