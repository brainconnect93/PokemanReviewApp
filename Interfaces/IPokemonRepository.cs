using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        // Get & Read Methods in API
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);

        // Post & Create Methods in API
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        // Post & Create Methods in API
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        // Delete Methods in API
        bool DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}
