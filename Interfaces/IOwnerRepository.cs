using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        // Get & Read Methods in API
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);

        // Post & Create Methods in API
        bool CreateOwner(Owner owner);

        // Put & Update Methods In API
        bool UpdateOwner(Owner owner);
        bool Save();
    }
}
