namespace PokemonGame
{
    public interface IPokemon
    {
        string Nombre { get; }
        string Tipo { get; }
        int Atacar();
        int Defender();
    }
}