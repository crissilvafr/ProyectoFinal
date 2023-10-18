// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to this Fantasy World!");

Personaje jugador = new Personaje("Héroe", "Caballero");

Personaje mago = (Personaje)jugador.Clonar();

mago.Nombre = "Hechicero";
mago.Tipo = "Mago oscuro";

Personaje explorador = (Personaje)jugador.Clonar();

explorador.Nombre = "Explorador";
explorador.Tipo = "Arquero";

Console.WriteLine("Personaje Original:");
jugador.MostrarInfo();

Console.WriteLine("\nPersonaje Clonado en enemigo:");
mago.MostrarInfo();

Console.WriteLine("\nPersonaje Clonado en aliado:");
mago.MostrarInfo();

