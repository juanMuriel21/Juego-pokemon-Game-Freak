using System;

namespace PokemonGame
{
    public abstract class PokemonBase : IPokemon
    {
        private string nombre;
        private string tipo;
        private int[] ataques;
        private int defensa;

        protected PokemonBase(string nombre, string tipo, int[] ataques, int defensa)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.ataques = ataques;
            this.defensa = defensa;
        }

        public string Nombre => nombre;
        public string Tipo => tipo;

        public int Atacar()
        {
            Random rand = new Random();
            int ataqueSeleccionado = ataques[rand.Next(ataques.Length)];
            return ataqueSeleccionado * rand.Next(0, 2); // Multiplica por 0 o 1
        }

        public int Defender()
        {
            Random rand = new Random();
            return (int)(defensa * (rand.Next(0, 2) == 0 ? 1 : 0.5));
        }
    }
}