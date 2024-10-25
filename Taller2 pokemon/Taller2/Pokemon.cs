namespace PokemonGame
{
    public class Pokemon : PokemonBase
    {
        public Pokemon(string nombre, string tipo, int[] ataques, int defensa)
            : base(nombre, tipo, ataques, defensa) { }
    }
}