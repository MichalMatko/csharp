namespace PokemonGame
{
    public class GameEngine
    {
        public Pokemon FirstPokemon { get; set; }
        public Pokemon SecondPokemon { get; set; }
        public GameEngine()
        {
            FirstPokemon = new Pokemon("Pikachu");
            SecondPokemon = new Pokemon("Charizard");
        }
    }
}
