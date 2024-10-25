using System;

namespace PokemonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear Pokémon
            Console.WriteLine("Ingrese los datos del Pokémon 1:");
            Pokemon pokemon1 = CrearPokemon();

            Console.WriteLine("Ingrese los datos del Pokémon 2:");
            Pokemon pokemon2 = CrearPokemon();

            // Combate
            int puntosPokemon1 = 0;
            int puntosPokemon2 = 0;

            for (int i = 0; i < 3; i++)
            {
                puntosPokemon1 += pokemon1.Atacar();
                puntosPokemon2 += pokemon2.Atacar();
            }

            Console.WriteLine($"Puntos Pokémon 1: {puntosPokemon1}");
            Console.WriteLine($"Puntos Pokémon 2: {puntosPokemon2}");

            if (puntosPokemon1 > puntosPokemon2)
                Console.WriteLine("Ganó el Pokémon 1!");
            else if (puntosPokemon2 > puntosPokemon1)
                Console.WriteLine("Ganó el Pokémon 2!");
            else
                Console.WriteLine("Empate!");
        }

        static Pokemon CrearPokemon()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "Desconocido";

            Console.Write("Tipo: ");
            string tipo = Console.ReadLine() ?? "Desconocido";

            int[] ataques = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ataque {i + 1} (0-40): ");
                ataques[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.Write("Defensa (10-35): ");
            int defensa = int.Parse(Console.ReadLine() ?? "10");

            return new Pokemon(nombre, tipo, ataques, defensa);
        }
    }
}